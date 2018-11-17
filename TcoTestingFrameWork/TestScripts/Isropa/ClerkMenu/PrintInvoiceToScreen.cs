using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
   public  class PrintInvoiceToScreen
    {
        [TestMethod]
        public void PrintInvoice()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            Assert.AreEqual("TCO Log In", WindowHelper.GetTitle());

            TextBoxHelper.SendKeys(By.Id("txtUserName"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.SendKeys(By.Id("txtPassword"), ObjectRepository.Config.GetUserPassword());
            ButtonHelper.ClickButton(By.Id("btnLogIn"));


            // check if we are in the main menu Welcom to TCO 
            var clerk = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=1]"));
            Assert.AreEqual("Welcome To TCO", WindowHelper.GetTitle());
            clerk.Click();

            // wait until find the  " File " tab And Click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='File']")).Click();

            //wait for the " open exsiting file " option and click it 
            var kk =GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='Open Existing File']"));
            kk.Click();

            // Switch to frame
            // Note --> I found Iframe Xpath from the main form not from the small new form that appears in the main form 

            BrowserHelper.SwitchToFrame(ObjectRepository.Driver.FindElement(By.XPath("//div[@id='cboxLoadedContent']/child::iframe ")));
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//input[@id='txtFileNo']")).SendKeys("170228");//170228 is the docket No' to open

            //locate the OK Button and click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("btnOk")).Click();

            Thread.Sleep(4000);       
        }
    }
}
