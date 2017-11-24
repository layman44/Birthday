using Abp.Configuration;
using Abp.Domain.Services;
using Abp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday.Mail
{
    public class MailSendManager : IDomainService
    {
        private readonly IEmailSender _emailSender;

        private readonly ISettingManager _settingManager;

        public MailSendManager(IEmailSender emailSender, ISettingManager settingManager)
        {
            _emailSender = emailSender;
            _settingManager = settingManager;
        }

        public void SendMail()
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
