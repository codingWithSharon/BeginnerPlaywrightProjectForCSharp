# A beginners project for Playwright and C#

A quick guide to get started with Playwright and C#. In the previous project we used Playwright with JavaScript to get familiar with the basic concepts when creating an automated test.
In this project we wil use the same UI with simular tests so we can focus on C#.

## Set Up

1. Create a project in Visual Studio using the template: "NUnit Playwright Test Project"
2. Go to Tools > NuGet Package Manager >  Manage NuGet Packages for Solution
3. Install the following packages:
	
	- using Microsoft.Playwright;
	- using Microsoft.Playwright.NUnit;

	NOTE: Make sure you don't get a version mismatch. If so then check for updates and rebuild the project

4. Add the following 2 lines at the top of your testfile:
					
	using Microsoft.Playwright.NUnit;
    using System.Text.RegularExpressions;

	
5. Go to Test > Configure Run Settings > Select Solution Wide runsettings File > pick the file from the file explorer and click "open"


After following these steps you will see "UnitTest1.cs" file. This is a demotest that comes with Playwright.
Now open the Test Explorer if not already opened and press the green play button to.

Now if you see green checkmarks and the browser window showed up the demotest ran successfully!

## Backup your project and version control with Git

Before going any further you should first backup the project. In this project we use GitHub.

1. Login or create a GitHub account
2. In Visual Studio make sure you are connected to your GitHub account
3. Go to "Git Changes" > Create Repository > Create
4. Check the new repository on GitHub
5. Create a new branch (even when working alone on aproject it is best practice to work from a branch)

## Structuring the project

It is good practice to organize the project so it can run suffciently. To do so you have to create POM pages also known as Page Object Models.
The POM is a file where you can save your locators and create and save tasks.

Also consider a .runsettings file and setup file. These files will hold deal with some praticalities

## Create a Page Object Model

## Writing a test

In the first test we need to be aware when we link the files like the POM and the test fixture that we do this corectly.
In programming it is important to keep everything orginized and in order to do so we need to place things in different files and these different files need to be able to work together.

### Debuging

- In test explorer you can easily select a test and debug
- In the Developer PowerShell you can debug using the following commands:

		$env:PWDEBUG=1
	    dotnet test

## Keep practicing