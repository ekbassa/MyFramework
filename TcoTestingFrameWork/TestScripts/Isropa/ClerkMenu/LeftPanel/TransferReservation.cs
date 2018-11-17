using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu.LeftPanel
{
    [TestClass]
    public class TransferReservation
    {
        [TestMethod,TestCategory("Smoke")]
        public void TransferResv()
        {
            //IsropaLogin.Login();
            //SelectClerkMenuFromMainPage.SelectClerkMenu();

            ////wait until the left menu dispalyed
            //GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_cntClerkMenu1_pnlLeftMenu']//span[text()='TCO Package ']")).Click();

            ////wait until the Components is displayed
            //GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/h3")).Click();

            ////wait until the transfer option is displayed
            //GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/descendant::div[5]")).Click();

            //Thread.Sleep(3000);


            //  Vavigate to the desired  site 
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());

            //create an object if the PomLogin class
            PomLogin TcoLogin = new PomLogin(ObjectRepository.Driver);
            PomWelcomToTCO WelcomPage = TcoLogin.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetUserPassword());
            PomDocketList clerk = WelcomPage.ClickClerkMenu();
            
            Thread.Sleep(3000);
            

          
        }
    }
}
