using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace JLP.WebApi.Ef.Core
{
    public class CookieModuleBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            bool findValue = false;

            var key = bindingContext.ModelName;
            var valueProviderResult = bindingContext.ValueProvider;

            var valueProvider = valueProviderResult.GetValue(key);

            var value = valueProvider.RawValue as string;
            if (!string.IsNullOrWhiteSpace(value))
            {
                bindingContext.Model = value;
                findValue = true;
            }
            return findValue;
        }
    }

    public class CookieValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(HttpActionContext actionContext)
        {

            var cookies = actionContext.Request.Headers.GetCookies();
            Dictionary<string, string> values = new Dictionary<string, string>(cookies.Count);
            foreach (var cookie in cookies)
            {
                foreach (var state in cookie.Cookies)
                {
                    values.Add(state.Name, state.Value);
                }
            }

            return new CookieValueProvider(values);
        }
    }

    public class CookieValueProvider : IValueProvider
    {
        private Dictionary<string, string> _value { get; }
        public CookieValueProvider(Dictionary<string, string> cookies)
        {
            this._value = cookies;
        }
        public bool ContainsPrefix(string prefix)
        {
            return this._value.Keys.Contains(prefix);
        }

        public ValueProviderResult GetValue(string key)
        {
            string value = string.Empty;
            if (this._value.TryGetValue(key, out value))
            {
                return new ValueProviderResult(value, value, CultureInfo.CurrentCulture);
            }
            return null;
        }
    }

}