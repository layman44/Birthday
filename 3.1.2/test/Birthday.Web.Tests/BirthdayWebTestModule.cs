using System.Reflection;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Birthday.Web.Startup;

namespace Birthday.Web.Tests
{
    [DependsOn(
        typeof(BirthdayWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BirthdayWebTestModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayWebTestModule).GetAssembly());
        }
    }
}