using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Birthday.EntityFrameworkCore
{
    [DependsOn(
        typeof(BirthdayCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BirthdayEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayEntityFrameworkCoreModule).GetAssembly());
        }
    }
}