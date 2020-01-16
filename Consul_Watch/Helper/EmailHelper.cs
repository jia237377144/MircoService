using Consul_Watch.Module;
using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul_Watch.Helper
{
    public class EmailHelper
    {
        public static void SendHealthEmail(EmailSettings settings, string content)
        {
            try
            {
                dynamic list = JsonConvert.DeserializeObject(content);
                if (list != null && list.Count > 0)
                {
                    var emailBody = new StringBuilder("健康检查故障:\r\n");
                    foreach (var noticy in list)
                    {
                        emailBody.AppendLine($"--------------------------------------");
                        emailBody.AppendLine($"Node:{noticy.Node}");
                        emailBody.AppendLine($"Service ID:{noticy.ServiceID}");
                        emailBody.AppendLine($"Service Name:{noticy.ServiceName}");
                        emailBody.AppendLine($"Check ID:{noticy.CheckID}");
                        emailBody.AppendLine($"Check Name:{noticy.Name}");
                        emailBody.AppendLine($"Check Status:{noticy.Status}");
                        emailBody.AppendLine($"Check Output:{noticy.Output}");
                        emailBody.AppendLine($"--------------------------------------");
                    }

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(settings.FromWho, settings.FromAccount));
                    message.To.Add(new MailboxAddress(settings.ToWho, settings.ToAccount));

                    message.Subject = settings.Subject;
                    message.Body = new TextPart("plain") { Text = emailBody.ToString() };
                    using (var client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        client.Connect(settings.SmtpServer, settings.SmtpPort, false);

                        client.AuthenticationMechanisms.Remove("XOAUTH2");

                        client.Authenticate(settings.AuthAccount, settings.AuthPassword);

                        client.Send(message);

                        client.Disconnect(true);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 邮件发送
        /// </summary>
        /// <param name="sendName">发送者名称</param>
        /// <param name="sendAccountName">发送者账号</param>
        /// <param name="smtpHost">发送者服务器地址：例如：smtp.163.com</param>
        /// <param name="smtpPort">服务器端口号：例如：25</param>
        /// <param name="authenticatePassword">发送者登录邮箱账号的客户端授权码</param>
        /// <param name="receiverAccountNameList">接收者账号</param>
        /// <param name="mailSubject">邮件主题</param>
        /// <param name="sendHtml">文本html(与sendText参数互斥，传此值则 sendText传null)</param>
        /// <param name="sendText">纯文本(与sendHtml参数互斥，传此值则 sendHtml传null)</param>
        /// <param name="accessoryList">邮件的附件</param>
        public static void SendMail(string sendName, string sendAccountName, string smtpHost, int smtpPort, string authenticatePassword, List<string> receiverAccountNameList, string mailSubject, string sendHtml, string sendText, List<MimeKit.MimePart> accessoryList = null)
        {
            var message = new MimeKit.MimeMessage();
            message.From.Add(new MimeKit.MailboxAddress(sendName, sendAccountName));
            var mailboxAddressList = new List<MailboxAddress>();
            receiverAccountNameList.ForEach(f =>
            {

                mailboxAddressList.Add(new MailboxAddress(f));
            });
            message.To.AddRange(mailboxAddressList);

            message.Subject = mailSubject;

            var alternative = new MimeKit.Multipart("alternative");
            if (!string.IsNullOrWhiteSpace(sendText))
            {
                alternative.Add(new MimeKit.TextPart("plain")
                {
                    Text = sendText
                });
            }

            if (!string.IsNullOrWhiteSpace(sendHtml))
            {
                alternative.Add(new MimeKit.TextPart("html")
                {
                    Text = sendHtml
                });
            }
            var multipart = new MimeKit.Multipart("mixed");
            multipart.Add(alternative);
            if (accessoryList != null)
            {
                accessoryList?.ForEach(f =>
                {
                    multipart.Add(f);
                });

            }
            message.Body = multipart;
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(smtpHost, smtpPort, false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(sendAccountName, authenticatePassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }

    }
}
