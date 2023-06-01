using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp-test.Authorization;

namespace abp-test
{
    [DependsOn(
        typeof(abp-testCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class abp-testApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<abp-testAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(abp-testApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
