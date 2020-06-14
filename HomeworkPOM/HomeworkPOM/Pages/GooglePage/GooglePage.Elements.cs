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
    public partial class GooglePageTry: BasePage

    {
               
      
        public IWebElement SearchPanel2 => Driver.FindElement(By.Name("q"));

        public IWebElement FirstResult => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > div"));

        public IWebElement SeleniumHeadlineResult => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3"));


       
    }

}
