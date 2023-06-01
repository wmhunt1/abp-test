using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp-test.EntityFrameworkCore;
using abp-test.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace abp-test.Web.Tests
{
    [DependsOn(
        typeof(abp-testWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class abp-testWebTestModule : AbpModule
    {
        public abp-testWebTestModule(abp-testEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abp-testWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(abp-testWebMvcModule).Assembly);
        }
    }
}