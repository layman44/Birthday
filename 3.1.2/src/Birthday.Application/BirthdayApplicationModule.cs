using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Birthday.Mail;

namespace Birthday
{
    [DependsOn(
        typeof(BirthdayCoreModule),
        typeof(BirthdayMailModule),
        typeof(AbpAutoMapperModule))]
    public class BirthdayApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayApplicationModule).GetAssembly());
        }
    }
}