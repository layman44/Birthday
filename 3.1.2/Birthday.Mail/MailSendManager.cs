using Abp.Configuration;
using Abp.Domain.Services;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Birthday.Mail
{
    public class MailSendManager : IMailSendManager
    {
        private readonly IEmailSender _emailSender;

        private readonly ISmtpEmailSenderConfiguration _smtpEmailSenderConfiguration;

        public MailSendManager(IEmailSender emailSender, ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration)
        {
            _emailSender = emailSender;
            _smtpEmailSenderConfiguration = smtpEmailSenderConfiguration;
        }

        public SmtpClient BuildClient()
        {
            throw new NotImplementedException();
        }

        public void Send(string to, string subject, string body, bool isBodyHtml = true)
        {
            throw new NotImplementedException();
        }

        public void Send(string from, string to, string subject, string body, bool isBodyHtml = true)
        {
            throw new NotImplementedException();
        }

        public void Send(MailMessage mail, bool normalize = true)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string to, string subject, string body, bool isBodyHtml = true)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string from, string to, string subject, string body, bool isBodyHtml = true)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(MailMessage mail, bool normalize = true)
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            var smtpClient = new SmtpEmailSender(_smtpEmailSenderConfiguration).BuildClient();
            smtpClient.Send(new MailMessage(
                from: "348702974@qq.com",
                to: "yuchao44@163.com",
                subject: "test",
                body: "来自qq的测试邮件!"
                ));
        }

    }
}
