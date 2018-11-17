using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu.LeftPanel
{
    [TestClass]
    public class Excursions
    {
        [TestMethod,TestCategory("Smoke")]
        public void ExcursionReservation()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            //wait until the left menu dispalyed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_cntClerkMenu1_pnlLeftMenu']//span[text()='TCO Package ']")).Click();

            //wait until the Components is displayed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/h3")).Click();

            //Wait until the excursion option is displayed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/descendant::div[7]")).Click();

            Thread.Sleep(2000);
           
        }
    }
}
