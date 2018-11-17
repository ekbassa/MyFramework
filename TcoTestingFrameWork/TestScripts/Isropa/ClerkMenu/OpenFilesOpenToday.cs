using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public  class OpenFilesOpenToday
    {
        [TestMethod]
        public  void DispalyTodayDockets()
        {
            //first LogIn 
           IsropaLogin.Login();

            // select Clerk menu
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            // wait until checkbox open today is visile 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_chkOpenedToday")).Click();

            //click the "Show" button
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_btnShow")).Click();

            //Wait and display the number of dockets 
            Console.WriteLine("files #:{0} Files", GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_lblShowNoOfFiles")).Text.ToString());
        }

    }
}