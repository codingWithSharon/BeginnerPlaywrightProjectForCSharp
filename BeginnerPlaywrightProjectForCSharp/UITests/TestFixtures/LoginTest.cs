using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels;

namespace BeginnerPlaywrightProjectForCSharp.UITests.Tests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class LoginTests : Setup
    {
       
        //private LoginPage _loginPage;

        [Test]
        public async Task StandardLogin_ValidCredentials_ShouldLoginSuccessfully()
        {
            LoginPage loginPage = new LoginPage(Page);
            string username = "standard_user";
            string password = "secret_sauce";

            await Page.GotoAsync("https://www.saucedemo.com/");
            await loginPage._usernameField.WaitForAsync();
            await loginPage.StandardLogin(username, password); // Use the _loginPage initialized in Setup
            await Expect(loginPage._confirmingTitle).ToHaveTextAsync("Products"); // Assert that the confirming title has the text "Products"
        }
    }
}
