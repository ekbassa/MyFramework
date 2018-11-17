using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Nazarene.Incoming
{
    [TestClass]
    public class SelectIncoming_fromMainMenu
    {
        [TestMethod]
        public void SelectIncoming()
        {
           
            NazLogin.LogInNazaren();
            var Incoming = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, OpenQA.Selenium.By.XPath("//table[@id='tblMainMenu']//div[@class='FIncomingTours']"));
            Incoming.Click();
            Assert.AreEqual("QUOTATION / GROUPS LIST",ObjectRepository.Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Label27")).Text);
            Thread.Sleep(600);           
        }
    }
}
