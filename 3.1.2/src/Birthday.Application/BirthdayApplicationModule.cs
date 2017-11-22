using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Birthday
{
    [DependsOn(
        typeof(BirthdayCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BirthdayApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayApplicationModule).GetAssembly());
        }
    }
}