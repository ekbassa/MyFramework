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
    public  class HotelList
    {
        [TestMethod,TestCategory("Smoke")]
        public void ViewHotelList()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            //wait until the left panel is displayed and click hotel list option
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_cntClerkMenu1_UpdatePanel1']//span[text()='Hotels List ']")).Click();

            Thread.Sleep(3000);
            
        }
    }
}
