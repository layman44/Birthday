using Abp.AspNetCore.Mvc.Views;

namespace Birthday.Web.Views
{
    public abstract class BirthdayRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BirthdayRazorPage()
        {
            LocalizationSourceName = BirthdayConsts.LocalizationSourceName;
        }
    }
}
