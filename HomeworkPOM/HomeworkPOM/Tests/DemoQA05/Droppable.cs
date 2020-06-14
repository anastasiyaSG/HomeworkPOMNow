using HomeworkPOM.Factories;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeworkPOM.Tests.DemoQA05
{
   public class Droppable : BaseTest
    {
        
        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Dropable).Click();

        }
        [TearDown]
        public void TearDown()
        { Driver.Quit(); }

        [Test]
        public void DropElementWriteCorrectMsgOfTarget_When_DragAndDropDragMe()
        {
            _demoQA.WaitForLoad(55);
           _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
            _demoQA.WaitForLoad();

            string msg = "Dropped!";
            _demoQA.DroppedOnTarget(_demoQA.DropHere,msg);

          
        }

        [Test]
        public void DropHereElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var colorBefore = _demoQA.DropHere.GetCssValue("background-color");

            _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
            _demoQA.WaitForLoad();
            var colorAfter = _demoQA.DropHere.GetCssValue("background-color");
            
            _demoQA.DroppedOnTargetColorCheck(colorBefore, colorAfter);

        }

        [Test]
        public void DropedElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var colorBefore = _demoQA.DragMe.GetCssValue("background-color");

            _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
            _demoQA.WaitForLoad();
            var colorAfter = _demoQA.DragMe.GetCssValue("background-color");
            
            _demoQA.DragBoxBackgroundColorIsSame(colorBefore, colorAfter);

        }

    }
}

