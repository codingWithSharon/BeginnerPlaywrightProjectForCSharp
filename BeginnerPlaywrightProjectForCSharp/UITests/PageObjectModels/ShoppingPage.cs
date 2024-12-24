using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;


namespace BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels
{
    public class ShoppingPage : BasePage 
    {
        public ShoppingPage(IPage page) : base(page)
        {

        }

        // Locators for actions
        public ILocator _passwordFieldQL => Page.GetByPlaceholder("Password");
        public ILocator _loginButtonQL => Page.Locator("input.submit-button.btn_action");
        public ILocator _usernameFieldQL => Page.GetByPlaceholder("Username");

        public ILocator _SelectFilter => Page.Locator("//select[@class='product_sort_container']");
        public ILocator _aToZ => Page.Locator("//select[@class='product_sort_container']/option[@value='az']");
        public ILocator _zToA => Page.Locator("//select[@class='product_sort_container']/option[@value='za']");
        public ILocator _priceLowToHigh => Page.Locator("//select[@class='product_sort_container']/option[@value='lohi']");
        public ILocator _priceHighToLow => Page.Locator("//select[@class='product_sort_container']/option[@value='hilo']");


        
        // Locators for confirmations
        public async Task QuickLogin(string username, string password)
        {
            await _usernameFieldQL.FillAsync(username);
            await _passwordFieldQL.FillAsync(password);
            await _loginButtonQL.ClickAsync();
        }

        public async Task FilterProductResults()
        {
            await _SelectFilter.SelectOptionAsync(new[] { "lohi" });
            await _SelectFilter.SelectOptionAsync(new[] { "hilo" });
            await _SelectFilter.SelectOptionAsync(new[] { "za" });
            await _SelectFilter.SelectOptionAsync(new[] { "az" });
        }
        
        // Actions

    }
}
