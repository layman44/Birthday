using Abp.Modules;
using Abp.Reflection.Extensions;
using Birthday.Localization;

namespace Birthday
{
    public class BirthdayCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BirthdayLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayCoreModule).GetAssembly());
        }
    }
}