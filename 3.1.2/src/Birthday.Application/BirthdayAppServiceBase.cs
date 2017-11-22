using Abp.Application.Services;

namespace Birthday
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BirthdayAppServiceBase : ApplicationService
    {
        protected BirthdayAppServiceBase()
        {
            LocalizationSourceName = BirthdayConsts.LocalizationSourceName;
        }
    }
}