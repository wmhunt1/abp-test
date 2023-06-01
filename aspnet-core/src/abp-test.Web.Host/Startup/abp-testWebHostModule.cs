using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp-test.Configuration;

namespace abp-test.Web.Host.Startup
{
    [DependsOn(
       typeof(abp-testWebCoreModule))]
    public class abp-testWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abp-testWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abp-testWebHostModule).GetAssembly());
        }
    }
}
