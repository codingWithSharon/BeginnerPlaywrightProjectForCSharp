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
            string standardUsername = "standard_user";
            string standardPassword = "secret_sauce";

            await Page.GotoAsync("https://www.saucedemo.com/");
            await loginPage._usernameField.WaitForAsync();
            await loginPage.StandardLogin(standardUsername, standardPassword);
            await Expect(loginPage._confirmingTitle).ToHaveTextAsync("Products");
        }

        [Test]
        public async Task LockedLogin_BlockedCredentials_ShouldNotBeAbleToLogin()
        {
            LoginPage loginPage = new LoginPage(Page);
            string lockedUsername = "locked_out_user";
            string lockedPassword = "secret_sauce";
            await Page.GotoAsync("https://www.saucedemo.com/");
            await loginPage.LockedLogin(lockedUsername, lockedPassword);
            await Expect(loginPage._confirmingFailMessage).ToHaveTextAsync("Epic sadface: Sorry, this user has been locked out.");
        }
    }
}
