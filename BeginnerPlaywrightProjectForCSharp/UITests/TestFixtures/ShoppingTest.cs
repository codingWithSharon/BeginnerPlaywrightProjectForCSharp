using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels;

namespace BeginnerPlaywrightProjectForCSharp.UITests.TestFixtures
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    internal class ShoppingTest : Setup
    {
        [Test]
        public async Task FilterProductResults()
        {
            ShoppingPage shoppingPage = new ShoppingPage(Page);
            string usernameQL = "standard_user";
            string passwordQL = "secret_sauce";
            await Page.GotoAsync("https://www.saucedemo.com/");
            await shoppingPage.QuickLogin(usernameQL, passwordQL);
            await shoppingPage.FilterProductResults();
            await shoppingPage.FilterPriceFromLowToHigh();
            await shoppingPage.ConfirmPricesLowToHigh();
            await shoppingPage.FilterPriceFromHighToLow();
            await shoppingPage.ConfirmPricesHighToLow();
        }
    }
}
