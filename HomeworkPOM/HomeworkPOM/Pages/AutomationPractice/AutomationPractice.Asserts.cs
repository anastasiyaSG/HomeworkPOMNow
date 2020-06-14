using HomeworkPOM.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class AutomationPractice : BasePage

    {

        public void AssertCorrectEmailDisplay(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("peshka@abv.bg", element.GetProperty("value"));

        }
        public void AssertAlertMessage(string text, IWebElement element)
        {

            this.WaitForLoad();
            StringAssert.Contains(text, element.Text);
        }   
    }

}
