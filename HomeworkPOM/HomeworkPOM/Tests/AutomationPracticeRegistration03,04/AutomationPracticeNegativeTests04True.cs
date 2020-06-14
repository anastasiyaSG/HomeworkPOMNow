using HomeworkPOM.Factories;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeworkPOM.Tests.GoogleSearch01
{
    public class AutomationPracticeNegativeTests04True : BaseTest
    {
  

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php/");

            

        }
        [TearDown]
        public void TearDown()
        { Driver.Quit(); }

        [Test]
        public void RegisterWithoutFirstName()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();


            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithNoPasword()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();
           
            automationPractice.FillForm(user);
            automationPractice.PasswordPanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "passwd is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterNumberLetterZipcode()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PosteCodePanel.Clear();
            automationPractice.PosteCodePanel.SendKeys("981AB");
            automationPractice.RegisterButton.Click();

            string msg = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithoutPhoneNumber()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();
           
            automationPractice.FillForm(user);
            automationPractice.PhoneMobile.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "You must register at least one phone number.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterWithFirstNameStartWithSpace()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();
           
            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.FirstNamePanel.SendKeys(" Azis"+Keys.Tab);
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }
       
    }



}


