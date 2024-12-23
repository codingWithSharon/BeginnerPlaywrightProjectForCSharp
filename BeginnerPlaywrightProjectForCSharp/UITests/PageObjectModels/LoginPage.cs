using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels
{
    public class LoginPage : BasePage
    {
        public LoginPage(IPage page):base(page)
        {

        }
        // No need for a constructor to pass the IPage since PageTest already provides it

        // Locators
        public ILocator _confirmingTitle => Page.Locator("//span[@class='title']");
        public ILocator _passwordField => Page.GetByPlaceholder("Password");
        public ILocator _loginButton => Page.Locator("input.submit-button.btn_action");
        public ILocator _usernameField => Page.GetByPlaceholder("Username");

        // Action for standard login
        public async Task StandardLogin(string username, string password)
        {

            await _passwordField.FillAsync(password);
            await _usernameField.FillAsync(username);
            await _loginButton.ClickAsync();
        }
    }
}
