using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using static System.Net.Mime.MediaTypeNames;

namespace BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels
{
    internal class LoginPage: PageTest
    {
        public ILocator _usernameField => Page.GetByPlaceholder("Username");
        public ILocator _passwordField => Page.GetByPlaceholder("Password");
        public ILocator _loginButton => Page.Locator("input.submit-button.btn_action");

        public async Task StandardLogin(string username, string password)
        {
            await _usernameField.FillAsync(username);
            await _passwordField.FillAsync(password);
            await _loginButton.ClickAsync();
        }
    };


}
