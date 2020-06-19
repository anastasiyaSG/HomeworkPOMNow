using HomeworkPOM.Factories;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Interfaces;

namespace HomeworkPOM.Tests.GoogleSearch01
{
   public class TryTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://www.google.com/");
        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var sceenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                sceenshot.SaveAsFile($"{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit(); }

        [Test]

        public void SearchGoogle2()
        {
            GooglePageTry googlePageTry = new GooglePageTry(Driver);

            var user = GoogleFromFactories.Create();
            googlePageTry.FillGoogleSearch(user);

            googlePageTry.WaitForLoad();
            googlePageTry.AssertHeadlineResult(googlePageTry.SeleniumHeadlineResult);
        }

        
    }
}
