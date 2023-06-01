﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abp-test.Configuration.Dto;

namespace abp-test.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : abp-testAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
