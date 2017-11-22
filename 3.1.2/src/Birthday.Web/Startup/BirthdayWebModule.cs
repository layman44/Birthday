using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Birthday.Configuration;
using Birthday.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Birthday.Web.Startup
{
    [DependsOn(
        typeof(BirthdayApplicationModule), 
        typeof(BirthdayEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BirthdayWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BirthdayWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BirthdayConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BirthdayNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BirthdayApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BirthdayWebModule).GetAssembly());
        }
    }
}