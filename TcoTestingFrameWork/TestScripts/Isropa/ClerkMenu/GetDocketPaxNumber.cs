using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public  class GetDocketPaxNumber
    {
        [TestMethod]
        public void  GetPaxNumber()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            // wait until find the  " File " tab And Click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='File']")).Click();

            //wait for the " open exsiting file " option and click it 
            var ExistingFile = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='Open Existing File']"));
            ExistingFile.Click();
            GenericHelper.OpenExistingFile("170228");

            /* now switch to the Child window*/
            BrowserHelper.SwitchToWindow(1);

            //locate the "Show All Clients" checkbox and click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_chkShowAllClients")).Click();

            // wait 1 second
            Thread.Sleep(1000);

            //compare between the displayed number and the actual rows number if they are equals
            var DisplayesNumber =  TableHelper.GetExpectedPaxNumber(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_GVPaxs']/tbody/child::tr"));
            Assert.AreEqual(DisplayesNumber , TableHelper.GetActualPaxNumber());
            Console.WriteLine("This Docket Has .{0} Pax", TableHelper.GetActualPaxNumber());

         //   return DisplayesNumber;
        }
    }
}
