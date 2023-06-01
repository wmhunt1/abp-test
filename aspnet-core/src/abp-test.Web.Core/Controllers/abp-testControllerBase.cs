using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abp-test.Controllers
{
    public abstract class abp-testControllerBase: AbpController
    {
        protected abp-testControllerBase()
        {
            LocalizationSourceName = abp-testConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
