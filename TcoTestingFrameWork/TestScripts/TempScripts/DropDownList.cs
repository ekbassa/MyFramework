using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.TempScripts
{
    [TestClass]
    public  class DropDownList
    {
        private TestContext _testContext;
        public TestContext  TestContext { get; set; }

        [TestMethod]
        public void Dropdown()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            Assert.AreEqual("TCO Log In", WindowHelper.GetTitle());

            TextBoxHelper.SendKeys(By.Id("txtUserName"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.SendKeys(By.Id("txtPassword"), ObjectRepository.Config.GetUserPassword());
            ButtonHelper.ClickButton(By.Id("btnLogIn"));


            // check if we are in the main menu Welcom to TCO 
            var ReservationCenterIcon = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=3]"));
            Assert.AreEqual("Welcome To TCO", WindowHelper.GetTitle());
            ReservationCenterIcon.Click();
            //select the dropdown
            DropDownListHelper.SelectElementByIndex(By.Id("ctl00_ContentPlaceHolder1_cmbHotelReports_Input"), 0);

            //Display the Tests results
            System.Console.WriteLine("The test name IS.{0} .and the Test result is :{1}",TestContext.TestName,TestContext.CurrentTestOutcome);
            Thread.Sleep(2000);
            
        }
    }
}
