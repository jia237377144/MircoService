using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Consul_Watch.Helper;
using Consul_Watch.Module;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using Newtonsoft.Json;

namespace Consul_Watch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly ILogger<NotificationsController> _logger;
        public NotificationsController(ILogger<NotificationsController> logger)
        {
            this._logger = logger;
        }

        [Route("consul")]
        [HttpPost]
        public async void SendConsulHealthCheckEmail()
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    await HttpContext.Request.Body.CopyToAsync(stream);
                    var ary = stream.ToArray();
                    var str = Encoding.UTF8.GetString(ary);

                    dynamic notifications = JsonConvert.DeserializeObject(str);
                    if (notifications == null || notifications.Count == 0)
                    {
                        throw new ArgumentException();
                    }

                    var title = "XDP服务中心健康检查通知";
                    var emailBody = new StringBuilder($"<span style='font-weight:bold; color:red;'>{title}</span> : <br/>");
                    //var notifications = new List<Notification> { new Notification { Node = "windowsclient", ServiceID = "1", ServiceName = "windowsclient", CheckID = "123", Name = "windowsclient", Status = "error", Output = "error" } };
                    foreach (var notification in notifications)
                    {
                        emailBody.AppendLine($"---------------------------------------------------------<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>节点</span>:{notification.Node}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>服务ID</span>:{notification.ServiceID}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>服务名称</span>:{notification.ServiceName}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>检查ID</span>:{notification.CheckID}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>检查名称</span>:{notification.Name}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>检查状态</span>:{notification.Status}<br/>");
                        emailBody.AppendLine($"<span style='font-weight:bold;'>检查输出</span>:{notification.Output}<br/>");
                        emailBody.AppendLine($"---------------------------------------------------------<br/>");
                    }

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//第二种方式
                    this._logger.LogInformation(emailBody.ToString());
                    //this.SendEmail(emailBody.ToString());
                    //}

                }
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex.ToString());
            }
        }
        public void SendEmail(string body)
        {
            string sendName = "jlp";
            string sendAccountName = "jlp";
            string smtpHost = "smtp.qq.com";
            int smtpPort = 25;
            string authenticatePassword = "";
            List<string> receiverAccountNameList = new List<string> { "" };
            string mailSubject = "Consul 报警";
            string sendText = body;
            EmailHelper.SendMail(sendName, sendAccountName, smtpHost, smtpPort, authenticatePassword, receiverAccountNameList, mailSubject, null, sendText);
        }

        #region 邮件发送

        #endregion
    }



}