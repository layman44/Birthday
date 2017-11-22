using System.Threading.Tasks;
using Birthday.Web.Controllers;
using Shouldly;
using Xunit;

namespace Birthday.Web.Tests.Controllers
{
    public class HomeController_Tests: BirthdayWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
