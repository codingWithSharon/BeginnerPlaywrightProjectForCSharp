# A beginners project for Playwright and C#

A quick guide to get started with Playwright and C#.

## Set Up

1. Create a project in Visual Studio using the template: "NUnit Playwright Test Project"
2. Go to Tools > NuGet Package Manager >  Manage NuGet Packages for Solution
3. Install the following packages:
	
	- using Microsoft.Playwright;
	- using Microsoft.Playwright.NUnit;

	NOTE: Make sure you get a version mismatch. If so then check for updates and rebuild the project

4. Add the following 2 lines at the top of your testfile:
					
	using Microsoft.Playwright.NUnit;
    using System.Text.RegularExpressions;

	
5. Go to Test > Configure Run Settings > Select Solution Wide runsettings File > pick the file from the file explorer and click "open"


After following these steps you will see "UnitTest1.cs" file. This is a demotest that comes with Playwright.
Now open the Test Explorer if not already opened and press the green play button to.

Now if you see green checkmarks and the browser window showed up the demotest ran successfully!

## Backup your project

Before going any further you should first backup the project. In this project we use GitHub.

1. Login or create a GitHub account
2. In Visual Studio make sure you are connected to your GitHub account
3. Go to "Git Changes" > Create Repository > Create
4. Check the new repository on GitHub
