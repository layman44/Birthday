using Abp.Configuration;
using Abp.Domain.Services;
using Abp.Net.Mail;

namespace Birthday.Mail
{
    public class TaskManger : IDomainService
    {
        private readonly IEmailSender _emailSender;

        private readonly ISettingManager _settingManager;

        public TaskManger(IEmailSender emailSender, ISettingManager settingManager)
        {
            _emailSender = emailSender;
            _settingManager = settingManager;
        }

        public void Assgin()
        {
            _emailSender.Send(
                from: _settingManager.GetSettingValue(EmailSettingNames.DefaultFromAddress),
                to: "",
                subject: "",
                body: "",
                isBodyHtml: true
                );
        }
    }
}
