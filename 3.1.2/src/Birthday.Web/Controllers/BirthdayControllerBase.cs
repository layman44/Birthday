using Abp.AspNetCore.Mvc.Controllers;

namespace Birthday.Web.Controllers
{
    public abstract class BirthdayControllerBase: AbpController
    {
        protected BirthdayControllerBase()
        {
            LocalizationSourceName = BirthdayConsts.LocalizationSourceName;
        }
    }
}