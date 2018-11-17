using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts
{
    [TestClass]
    public class LogInVeredHasharon
    {
        [TestMethod]
        [TestCategory("VeredHasharon")]
        public static void Test_LoggInVeredHasharon()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            LoginPagePOM veredLog = new LoginPagePOM(ObjectRepository.Driver);
            WelcomToTcoPage veredWelcom = veredLog.ClickLogin(ObjectRepository.Config.GetVeredUser(), ObjectRepository.Config.GetVeredPassword());
            QuotationsList verdquote = veredWelcom.ClickIncoming();
        }
    }
}
