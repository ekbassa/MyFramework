using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts
{
    [TestClass]
    public class TestCloning
    {       
            //we are using the TestContext class because we are readinf the data from Excel file
            private  TestContext _Testcontext;
            public  TestContext TestContext
            {
                get { return _Testcontext; }
                set { _Testcontext = value; }
            }

            [TestMethod]
            [TestCategory("VeredHasharon")]
            [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;", "Quotations$", DataAccessMethod.Sequential)]
            public  void  Test_OpenQuotationById_Facked()
            {
                OpenTheQuoteByIdAndReachTheQuotationPage();
                  AddGroupMembers();
               // Printing();
               // IsQuotationHasDocket();

               //ActionsOntheQuotePage();
                         
                Console.WriteLine("the page tile is:{0}", WindowHelper.GetTitle());
                Console.WriteLine("the page URL Is:{0}", WindowHelper.GetPageUrl());
                BrowserHelper.SwitchToParentWindow();
            // Console.WriteLine("I am in parent window and the title is:{0}", WindowHelper.GetTitle());
             
                Thread.Sleep(1000);
            }

        [TestMethod]
        [TestCategory("VeredHasharon")]
        
        private void AddGroupMembers()
        {
            QuotationSheet myQuote = new QuotationSheet(ObjectRepository.Driver);
            var AddMem = myQuote.QuotationSheetTabs.AddGroupMember;
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, myQuote.QuotationSheetTabs.Tab_Clients, myQuote.QuotationSheetTabs.AddGroupMember);
       
        }

        [TestMethod]
            [TestCategory("VeredHasharon")]
            [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;", "Quotations$", DataAccessMethod.Sequential)]
            public void IsQuotationHasDocket()
            {
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
           // var elem = Quote.Txt_DocketNumberInQuotation.GetAttribute("style");
            
            //switch (elem)
            //{
            //    case "display: none;":
            //        Console.WriteLine("the quote Has No Docket");
            //        break;
            //    case "display: inline;":
            //   //     Console.WriteLine("the quote has a docket and Its No:{0}",Quote.Txt_DocketNumberInQuotation.GetAttribute("value"));
            //        break;
            //}
        }



        public  void  OpenTheQuoteByIdAndReachTheQuotationPage()
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

            Assert.AreEqual("QUOTATION / GROUPS LIST", verdquote.PageTitle, "the titles are not equals");
            var HoverAnElement = ObjectRepository.Driver.FindElement(By.XPath("//td[@id='ctl00_ContentPlaceHolder1_mnuTopn0']//a[contains(text(),'Sheets')]"));
            var ElementClick = ObjectRepository.Driver.FindElement(By.XPath("//a[contains(text(),'Open Calc.sheet/Group by number')]"));
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, HoverAnElement, ElementClick);

            //switch to the new frame by invoking   OpenExistingQuote Method
            GenericHelper.OpenExistingQuote(TestContext.DataRow["QuotationId"].ToString());
            Thread.Sleep(2000);
            //switch to the new window  
            BrowserHelper.SwitchToWindow(1);
            
        }

        private  void ActionsOntheQuotePage()
        {
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            var element1 = Quote.TopMenu.DataEntry;
            var element2 = Quote.TopMenu.ParkingFees;
            MouseActionsHelper.hoverAnElement(element1);
            
            Thread.Sleep(1500);
            MouseActionsHelper.HoverAndClick(ObjectRepository.Driver, element1, element2);
            Thread.Sleep(2000);    
        }
        private  void SelectService()
        {
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            var ele1 = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("//ctl00_ContentPlaceHolder1_cntServicesNavigator_btnHotels"));
            ele1.Click();
        }
        private  void Printing()
        {
            QuotationSheetTabs printingTab = new QuotationSheetTabs(ObjectRepository.Driver);
            printingTab.TransferPrint();
            Thread.Sleep(1000);
        }
       
    }
    }

