using System.Threading.Tasks;
using abp-test.Configuration.Dto;

namespace abp-test.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
