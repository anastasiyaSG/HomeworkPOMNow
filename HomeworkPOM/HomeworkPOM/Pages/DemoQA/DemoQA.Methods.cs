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
    public partial class DemoQA : BasePage

    {

        public DemoQA(IWebDriver driver2)
            : base(driver2)
        {
        }

        
        public void DraggableDragAndDrop(IWebElement point)
        {
            Builder.DragAndDropToOffset(point, 100, 100).Perform();

        }

        public void DraggableDragAndDropToTarget(IWebElement dragBox, IWebElement target)
        {
            Builder.DragAndDrop(dragBox, target).Perform();

        }


        public void DropOnTarget(IWebElement dragMe, IWebElement dropHere)
        {
            Builder.DragAndDrop(dragMe, dropHere).Perform();

        }

        public void ResizeOffset(IWebElement resizeArrow, int X, int Y)
        {
            this.WaitForLoad();
            Builder.DragAndDropToOffset(resizeArrow, X, Y).Perform();

        }

       

    }

}


