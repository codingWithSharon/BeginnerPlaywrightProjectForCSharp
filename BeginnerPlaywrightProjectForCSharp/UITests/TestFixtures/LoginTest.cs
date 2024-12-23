using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels;

namespace BeginnerPlaywrightProjectForCSharp.UITests.Tests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class LoginTests : PageTest
    {
        [Test]
        public async Task StandardLogin_ValidCredentials_ShouldLoginSuccessfully()
        {
            LoginPage loginPage = new LoginPage();
            string username = "standard_user";
            string password = "secret_sauce";

            await Page.GotoAsync("https://www.saucedemo.com/");

            await loginPage._usernameField.FillAsync(username);
            await loginPage._passwordField.FillAsync(password);
            await loginPage._loginButton.ClickAsync();
        }
    }
}
