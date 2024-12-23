using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels
{
    public class LoginPage : BasePage
    {
        public LoginPage(IPage page):base(page)
        {

        }

        // Locators for actions
        public ILocator _passwordField => Page.GetByPlaceholder("Password");
        public ILocator _loginButton => Page.Locator("input.submit-button.btn_action");
        public ILocator _usernameField => Page.GetByPlaceholder("Username");

        // Locators for confirmations
        public ILocator _confirmingTitle => Page.Locator("//span[@class='title']");
        public ILocator _confirmingFailMessage => Page.Locator("//div[@class='error-message-container error']");



        // Actions
        public async Task StandardLogin(string username, string password)
        {

            await _usernameField.FillAsync(username);
            await _passwordField.FillAsync(password);
            await _loginButton.ClickAsync();
        }

        public async Task LockedLogin(string username, string password)
        {
            await _usernameField.FillAsync(username);
            await _passwordField.FillAsync(password);
            await _loginButton.ClickAsync();
        }
    }
}
