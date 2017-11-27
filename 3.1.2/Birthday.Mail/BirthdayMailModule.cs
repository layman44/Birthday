using Abp.MailKit;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Birthday.Mail
{
    [DependsOn(typeof(AbpMailKitModule))]
    public class BirthdayMailModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Settings.Providers.Add<BirthdayEmailSettingProvider>();
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayMailModule).GetAssembly());
        }
    }
}
