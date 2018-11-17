using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu.LeftPanel
{
    [TestClass]
    public class AccomodationOnly
    {
        [TestMethod,TestCategory("Smoke")]
        public void ReserveAccOnly()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();
            Console.WriteLine("Done....");

            //wait until the left menu dispalyed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_cntClerkMenu1_pnlLeftMenu']//span[text()='TCO Package ']")).Click();

            //wait until the Components is displayed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/h3")).Click();
        
            //wait until Accomodation only tab is displayed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/descendant::div[2]")).Click();

            //click the country combobox 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("//div[@id='cboxClose']")).Click();



            Thread.Sleep(2000);
            
        }
    }
}
