using Abp.Net.Mail;

namespace Birthday.Mail
{
    public class MailSendManager : IMailSendManager
    {
        private readonly IEmailSender _emailSender;

        public MailSendManager(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendMail()
        {
            _emailSender.Send(
                from: "348702974@qq.com",
                to: "yuchao44@163.com",
                subject: "test",
                body: "来自qq的测试邮件!",
                isBodyHtml: true
                );
        }

    }
}
