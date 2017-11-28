using Abp.Domain.Services;

namespace Birthday.Mail
{
    public interface IMailSendManager: IDomainService
    {
        void SendMail();
    }
}
