using HomeworkPOM.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class AutomationPractice : BasePage

    {
        public IWebElement SignInButton => Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));

        public IWebElement EmailSectionOnCheateAccount => Driver.FindElement(By.Id("email_create"));

        public IWebElement CreateAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));

        public IWebElement EmailBannerOnRegistrationForm => Driver.FindElement(By.CssSelector("#email"));

        public IWebElement LastNamePanel => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement FirstNamePanel => Driver.FindElement(By.Id("firstname"));

        public IWebElement PasswordPanel => Driver.FindElement(By.Id("passwd"));

        public IWebElement AddressPanel => Driver.FindElement(By.Id("address1"));

        public IWebElement CityPanel => Driver.FindElement(By.Id("city"));

        public IWebElement IdStatePanel => Driver.FindElement((By.Id("id_state")));

        public IWebElement PhoneMobile => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement PosteCodePanel => Driver.FindElement(By.Id("postcode"));

        public IWebElement RegisterButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span/i"));

        public IWebElement AlertMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div"));





    }

}
