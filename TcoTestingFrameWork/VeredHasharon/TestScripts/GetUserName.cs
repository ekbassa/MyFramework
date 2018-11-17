using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TcoTestingFrameWork.VeredHasharon.POM;
using OpenQA;
using OpenQA.Selenium;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.ComponenetHelper;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts
{
    [TestClass]
    public  class GetUserName 
    {      
        [TestMethod]
        [TestCategory("VeredHasharon")]
        public void Test_GetUserNameValid()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            LoginPagePOM Login = new LoginPagePOM(ObjectRepository.Driver);
            WelcomToTcoPage verdWelcom= Login.ClickLogin(ObjectRepository.Config.GetVeredUser(), ObjectRepository.Config.GetVeredPassword());
            var UserName =verdWelcom.GetUserName();
            Assert.AreEqual("Vered Hasharon 1", UserName, "the user names are not equals");
        }
        [TestMethod]
        [TestCategory("VeredHasharon")]
        public void Test_GetUserNameInValid()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            LoginPagePOM Login = new LoginPagePOM(ObjectRepository.Driver);
            WelcomToTcoPage verdWelcom = Login.ClickLogin(ObjectRepository.Config.GetVeredUser(), ObjectRepository.Config.GetVeredPassword());
            var UserName = verdWelcom.GetUserName();
            Assert.AreEqual("Vered Hasharon 2", UserName, "the user names are not equals");
        }
    }
}
