﻿using System;
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

        // Login
        public ILocator _passwordFieldQL => Page.GetByPlaceholder("Password");
        public ILocator _loginButtonQL => Page.Locator("input.submit-button.btn_action");
        public ILocator _usernameFieldQL => Page.GetByPlaceholder("Username");

        // Filter
        public ILocator _SelectFilter => Page.Locator("//select[@class='product_sort_container']");
        public ILocator _aToZ => Page.Locator("//select[@class='product_sort_container']/option[@value='az']");
        public ILocator _zToA => Page.Locator("//select[@class='product_sort_container']/option[@value='za']");
        public ILocator _priceLowToHigh => Page.Locator("//select[@class='product_sort_container']/option[@value='lohi']");
        public ILocator _priceHighToLow => Page.Locator("//select[@class='product_sort_container']/option[@value='hilo']");



        // Locators for confirmations
        public ILocator _InventoryContainer => Page.Locator("//div[@class='inventory_item_price']");
        


        // Actions
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

        public async Task FilterPriceFromLowToHigh()
        {
            await _SelectFilter.SelectOptionAsync(new[] { "lohi" });
        }

        public async Task FilterPriceFromHighToLow()
        {
            await _SelectFilter.SelectOptionAsync(new[] { "hilo" });
        }

        public async Task FilterFromZtoA()
        {
            await _SelectFilter.SelectOptionAsync(new[] { "za" });
        }

        public async Task FilterFromAtoZ()
        {
            await _SelectFilter.SelectOptionAsync(new[] { "az" });
        }

        public async Task ConfirmPricesLowToHigh()
        {
            var priceElements = await _InventoryContainer.AllAsync();

            var prices = await Task.WhenAll(priceElements.Select(async element =>
            {
                var priceText = await element.InnerTextAsync();
                return Convert.ToDecimal(priceText.Replace("$", "").Trim());
            }));

            if (!prices.SequenceEqual(prices.OrderBy(price => price)))
            {
                throw new Exception("INCORRECT: Prices are not sorted in ascending order!");
            }
            else 
            {
                Console.WriteLine("CORRECT:  Prices are in acsending order");
            }
        }
    }
}