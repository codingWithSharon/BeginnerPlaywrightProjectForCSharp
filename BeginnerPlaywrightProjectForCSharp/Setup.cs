using BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestContext = NUnit.Framework.TestContext;

namespace BeginnerPlaywrightProjectForCSharp
{
    public class Setup: ContextTest
    {
        public IPage Page { get; set; }
        [SetUp]
        public async Task PageSetup()
        {
            Console.WriteLine("Test");
        Page = await Context.NewPageAsync().ConfigureAwait(false);
        LoginPage loginPage = new LoginPage(Page);
        }
    }
}
