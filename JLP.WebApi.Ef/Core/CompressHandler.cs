using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace JLP.WebApi.Ef.Core
{
    public class CompressHandler : DelegatingHandler
    {
        private static CompressHandler _Handler;
        private CompressHandler() { }
        private static readonly Object @lock = new Object();

        public static CompressHandler GetSingleton()
        {
            if (_Handler == null)
            {
                lock (@lock)
                {
                    if (_Handler == null)
                    {
                        _Handler = new CompressHandler();
                    }
                }
            }
            return _Handler;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>((responseToCompleteTask) =>
            {
                HttpResponseMessage response = responseToCompleteTask.Result;
                string acceptedEncoding = this.GetAcceptedEncoding(response);
                if (!string.IsNullOrWhiteSpace(acceptedEncoding))
                {
                    response.Content = new CompressedHttpContent(response.Content, acceptedEncoding);
                }
                return response;
            },
            TaskContinuationOptions.OnlyOnRanToCompletion);
        }
        private string GetAcceptedEncoding(HttpResponseMessage response)
        {
            string acceptEncoding = null;
            HttpRequestMessage requestMessage = response.RequestMessage;
            if (requestMessage != null
                && requestMessage.Headers.AcceptEncoding != null
                && requestMessage.Headers.AcceptEncoding.Any())
            {
                acceptEncoding = requestMessage.Headers.AcceptEncoding.First().Value;
            }
            return acceptEncoding;
        }
    }
}