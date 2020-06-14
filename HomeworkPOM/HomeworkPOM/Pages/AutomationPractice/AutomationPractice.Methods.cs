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


        public AutomationPractice(IWebDriver driver2)
            : base(driver2)
        {
        }


        public void FillEmail(AutomationPracticeFromModel user)
        {
            EmailSectionOnCheateAccount.SendKeys(user.Email);

        }
        public void FillForm(AutomationPracticeFromModel user)
        {
            SignInButton.Click();
            WaitForLoad();
            EmailSectionOnCheateAccount.Click();
            FillEmail(user);
            WaitForLoad();
            CreateAccountButton.Click();
            WaitForLoad();
            LastNamePanel.SendKeys(user.LastNamePanel + Keys.Tab);
            FirstNamePanel.SendKeys(user.FirstNamePanel + Keys.Tab);
            PasswordPanel.SendKeys(user.PasswordPanel + Keys.Tab);
            AddressPanel.SendKeys(user.AddressPanel + Keys.Tab);
            CityPanel.SendKeys(user.CityPanel + Keys.Tab);
            IdStatePanel.SendKeys(user.IdStatePanel + Keys.Tab);
            PhoneMobile.SendKeys(user.PhoneMobile + Keys.Tab);
            PosteCodePanel.SendKeys(user.PosteCodePanel + Keys.Tab);

        }

    }
}


