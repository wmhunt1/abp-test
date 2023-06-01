using System.Threading.Tasks;
using abp-test.Models.TokenAuth;
using abp-test.Web.Controllers;
using Shouldly;
using Xunit;

namespace abp-test.Web.Tests.Controllers
{
    public class HomeController_Tests: abp-testWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}