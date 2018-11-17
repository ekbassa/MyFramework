using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;
using UnitTestProject1.ExcelReader;
using System;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public static class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }

        public  static void SelectIncoming()
        {
            LoginFromConfigFile();
            LoginPagePOM LogMe = new LoginPagePOM(ObjectRepository.Driver);
            QuotationsList quoteList = LogMe.WelcomToTco.ClickIncoming();

            //Assert that you are in the right page
            Assert.AreEqual("QUOTATION / GROUPS LIST", quoteList.PageTitle, "the titles are not equals");
            var HoverAnElement = ObjectRepository.Driver.FindElement(By.XPath("//td[@id='ctl00_ContentPlaceHolder1_mnuTopn0']//a[contains(text(),'Sheets')]"));
            var ElementClick = ObjectRepository.Driver.FindElement(By.XPath("//a[contains(text(),'New Calc.sheet')]"));
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, HoverAnElement, ElementClick);
        }

        public static void NavigateToHomePage()
        {
            ObjectRepository.Driver.FindElement(By.XPath("//div[@class='HomeImage']")).Click();
        }

        public static void TcoLogOut()
        {
            ObjectRepository.Driver.FindElement(By.Id("ctl00_CleckControll1_btnLogOut")).Click();
        }

        public static void LoginFromExcelFile()
        {
            string FilePath = @"E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";
            NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            PomLogin TcoLogin = new PomLogin(ObjectRepository.Driver);
            TcoLogin.Login(ExcelReaderHelper.GetCelldata(FilePath, "Login", 1, 0).ToString(), ExcelReaderHelper.GetCelldata(FilePath, "Login", 1, 1).ToString());
            Thread.Sleep(2000);
        }
        public static void LoginFromConfigFile()
        {
            NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            LoginPagePOM veredLog = new LoginPagePOM(ObjectRepository.Driver);
            WelcomToTcoPage veredWelcom = veredLog.ClickLogin(ObjectRepository.Config.GetVeredUser(), ObjectRepository.Config.GetVeredPassword());
        }
        public static void SelectIncomingToursAndOpenById()
        {
            LoginFromConfigFile();
            LoginPagePOM LogMe = new LoginPagePOM(ObjectRepository.Driver);
            QuotationsList quoteList = LogMe.WelcomToTco.ClickIncoming();
            string FilePath = @"E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";

            //Assert that you are in the right page
            Assert.AreEqual("QUOTATION / GROUPS LIST", quoteList.PageTitle, "the titles are not equals");
            var HoverAnElement = ObjectRepository.Driver.FindElement(By.XPath("//td[@id='ctl00_ContentPlaceHolder1_mnuTopn0']//a[contains(text(),'Sheets')]"));
            var ElementClick = ObjectRepository.Driver.FindElement(By.XPath("//a[contains(text(),'Open Calc.sheet/Group by number')]"));
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, HoverAnElement, ElementClick);

            //switch to the new frame by invoking   OpenExistingQuote Method
            GenericHelper.OpenExistingQuote(ExcelReaderHelper.GetCelldata(FilePath, "Quotations", 1, 0).ToString());
        }
        public static void SelectClerkMenu()
        {
            LoginFromConfigFile();
            var logMe = new LoginPagePOM(ObjectRepository.Driver);
        }
        public static QuotationSheet InitServices()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            BrowserHelper.SwitchToWindow(1);
            return Quote;
        }
    }
}
