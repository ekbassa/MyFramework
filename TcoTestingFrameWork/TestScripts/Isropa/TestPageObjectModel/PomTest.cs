using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.TestPageObjectModel
{
    [TestClass]
    public class PomTest
    {
        [TestMethod]
        public void PomLogin()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            PomLogin TcoLogIn = new PomLogin(ObjectRepository.Driver);
            PomWelcomToTCO TcoWelcomPage = TcoLogIn.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetUserPassword());
            PomDocketList Clerk = TcoWelcomPage.ClickClerkMenu();


            var DateInput = GenericHelper.GetElement(By.Id("ctl00_ContentPlaceHolder1_cldFromDate_txt_Date"));
            DateInput.Click();

            var PrevMonth = ObjectRepository.Driver.FindElement(By.XPath("//div[@id='CalendarDiv']/descendant::table[2]/descendant::td[1]"));
            Thread.Sleep(3000);
            PrevMonth.Click();
            Thread.Sleep(3000);
            var NextMonth = ObjectRepository.Driver.FindElement(By.XPath("//div[@id='CalendarDiv']/descendant::table[2]/descendant::td[3]"));
            NextMonth.Click();

            var DaysInCurrentMonth = ObjectRepository.Driver.FindElements(By.XPath("//div[@id='CalendarDiv']/descendant::table[3]"));          
            Thread.Sleep(5000);
        }
    }
    
}
