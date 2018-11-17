using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using OpenQA.Selenium;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public  class SelectClerkMenuFromMainPage
    {
        [TestMethod]
        public static void SelectClerkMenu()
        {
         // IsropaLogin.Login();

            // check if we are in the main menu Welcom to TCO 
            var clerk = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblMainMenuNL']//div[@class='FClerkMenu']"));
            Assert.AreEqual("Welcome To TCO", WindowHelper.GetTitle());
            clerk.Click();

        }
    }
}
