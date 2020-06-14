using HomeworkPOM.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class DemoQA : BasePage

    {//draggable
        public IWebElement AxisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement OnlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public IWebElement OnlyYBox => Driver.FindElement(By.Id("restrictedY"));
        public IWebElement Container => Driver.FindElement(By.Id("containmentWrapper"));
        public IWebElement DraggableBox => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));
        public IWebElement DragBox => Driver.FindElement(By.Id("dragBox"));
        public IWebElement CenterTarget => Driver.FindElement(By.XPath("//*[@id='app']/header/a/img"));


        //droppable

        public IWebElement DragMe => Driver.FindElement(By.Id("draggable"));
        public IWebElement DropHere => Driver.FindElement(By.Id("droppable"));


        //resizable
        public IWebElement ContainerResize => Driver.FindElement(By.ClassName("constraint-area"));
        public IWebElement ResizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public IWebElement ResizeArrow => Driver.FindElement(By.XPath("//span[contains(@class, 'react-resizable-handle')]"));
        public IWebElement Box => Driver.FindElement(By.Id("resizable"));
        public IWebElement ResizeUnlimitedArrow => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[2]/div/span"));

        //selectable
        public IWebElement FirstBox => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/li[1]"));

        //sortable
        public IWebElement FirstListElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]"));
        public IWebElement SortableBanner => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[1]"));
        public IWebElement FiveListElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[5]"));
        public IWebElement SortableHeadline => Driver.FindElement(By.XPath("//*[@id='app']/div/div/div[1]"));

        //navigateToInteractions
        public IWebElement InteractionsButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]/div"));
        public IWebElement Sortable => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[1]"));
        public IWebElement Selectable => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[2]"));
        public IWebElement Resizable => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[3]"));
        public IWebElement Dropable=> Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[4]"));
        public IWebElement Draggable => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[5]"));

    }
}

