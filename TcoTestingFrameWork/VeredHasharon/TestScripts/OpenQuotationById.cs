using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TcoTestingFrameWork.BaseClasses;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts
{
    [TestClass]
    public class OpenQuotationById
    {
        //we are using the TestContext class because we are reading the data from Excel file
        private  TestContext _Testcontext;

        public TestContext TestContext
        {
            get { return _Testcontext; }
            set { _Testcontext = value; }
        }     

        [TestMethod]
        [TestCategory("VeredHasharon")]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;", "Quotations$", DataAccessMethod.Sequential)]
        public  void  Test_OpenQuotationById()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());           
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            LoginPagePOM veredLog = new LoginPagePOM(ObjectRepository.Driver);
            WelcomToTcoPage veredWelcom = veredLog.ClickLogin(ObjectRepository.Config.GetVeredUser(), ObjectRepository.Config.GetVeredPassword());
            QuotationsList verdquote = veredWelcom.ClickIncoming();

          //  var mainWindow = BrowserHelper.GettheParentPage();

            verdquote.ticTcheckBoxAll();
            verdquote.clickShowButton();

            // make sure that you are in the right page -->assert the title of the page 

            Assert.AreEqual("QUOTATION / GROUPS LIST", verdquote.PageTitle,"the titles are not equals");
            var HoverAnElement = ObjectRepository.Driver.FindElement(By.XPath("//td[@id='ctl00_ContentPlaceHolder1_mnuTopn0']//a[contains(text(),'Sheets')]"));
            var ElementClick = ObjectRepository.Driver.FindElement(By.XPath("//a[contains(text(),'Open Calc.sheet/Group by number')]"));
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, HoverAnElement, ElementClick);

            //switch to the new frame by invoking   OpenExistingQuote Method
            GenericHelper.OpenExistingQuote(TestContext.DataRow["QuotationId"].ToString());

            //switch to the new window  
             BrowserHelper.SwitchToWindow(1);

            System.Console.WriteLine("the page tile is:{0}",WindowHelper.GetTitle());
            System.Console.WriteLine("the page URL Is:{0}",WindowHelper.GetPageUrl());

            BrowserHelper.SwitchToParentWindow();
            System.Console.WriteLine("I am in parent window and the title is:{0}",WindowHelper.GetTitle());

     //       Thread.Sleep(2000);       
        }
     
    }
}
