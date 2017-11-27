using Abp.Domain.Services;
using Abp.Net.Mail.Smtp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday.Mail
{
    public interface IMailSendManager: IDomainService, ISmtpEmailSender
    {
        void SendMail();
    }
}
