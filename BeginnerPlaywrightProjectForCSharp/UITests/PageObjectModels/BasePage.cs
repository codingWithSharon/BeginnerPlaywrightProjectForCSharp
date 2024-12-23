using Microsoft.Playwright;

using Microsoft.Playwright.NUnit;
 
namespace BeginnerPlaywrightProjectForCSharp.UITests.PageObjectModels;

public abstract class BasePage : ContextTest

{

    public IPage Page { get; private set; } = null!;

    public BasePage(IPage page)

    {

        Page = page;

    }

}
