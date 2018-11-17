using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Nazarene
{
    [TestClass]
    public  class NazClerkMenu
    {
        [TestMethod]
        public void SelectClerkIcon()
        {
            NazLogin.LogInNazaren();
            // check if we are in the main menu Welcom to TCO 
            var clerk = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblMainMenu']/descendant::td[1]"));
            Assert.AreEqual("Welcome To TCO", WindowHelper.GetTitle());
            clerk.Click();
        }
        [TestMethod]
        public void NazOpenFilesToday()
        {
            SelectClerkIcon();
            // wait until checkbox open today is visile 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_chkOpenedToday")).Click();

            //click the "Show" button
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_btnShow")).Click();    
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void SelectTheFirstDocktOfToday()
        {
           NazOpenFilesToday();
            //Actions act = new Actions(ObjectRepository.Driver);
            var elem = ObjectRepository.Driver.FindElement( By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/descendant::td[1]"));

            //  act.DoubleClick(elem);
            //  act.Build();
            //  act.Perform();

            MouseActionsHelper.DoubleClick(elem);
            
            
              
            Thread.Sleep(10000);

        }

    [TestMethod]
        public void SelectClerk()
        {
            NazOpenFilesToday();
            DropDownListHelper.SelectElementByValue(By.Id("ctl00_ContentPlaceHolder1_ddlClerk"), "12");
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void DisplayAllClerks()
        {
            NazOpenFilesToday();
            Console.WriteLine("There Are :{0} Registered Clerk In the company ", DropDownListHelper.ItemtsCountInDropBox(By.Id("ctl00_ContentPlaceHolder1_ddlClerk")));
            var ClerkList =  DropDownListHelper.SelectElementByText(By.Id("ctl00_ContentPlaceHolder1_ddlClerk"));
            foreach (var item in ClerkList)
            {
                Console.WriteLine("Clerk Name : {0}",item.ToString());
            }
        }

        [TestMethod]
        public void OpenspecificFile()
        {
            SelectClerkIcon();
            GenericHelper.GetElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='File']")).Click();
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::a[2]")).Click();

            var text = JavaScriptPopUpHelper.GetpoUpText();
            Console.WriteLine("Text is :{0}",text);
            Thread.Sleep(3000);
        }


    }
}
