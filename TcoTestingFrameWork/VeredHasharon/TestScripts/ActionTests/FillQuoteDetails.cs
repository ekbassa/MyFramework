using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;
using System.Collections.Generic;
using TcoTestingFrameWork.ComponentHelper;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts.ActionTests
{
    [TestClass]
    public class FillQuoteDetails
    {
        //we are using the TestContext class because we are reading the data from Excel file
        private TestContext _Testcontext;

        public TestContext TestContext
        {
            get { return _Testcontext; }
            set { _Testcontext = value; }
        }
        QuotationSheet quote = new QuotationSheet(ObjectRepository.Driver);

        [TestMethod]
        [TestCategory("Action Tests")]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;",
                                        "FillNewQuote$", DataAccessMethod.Sequential)]
        public void FillNewQuote_Test()
        {
            NavigationHelper.SelectIncoming();
            BrowserHelper.SwitchToWindow(1);    
            FillTheControlFromExcelFile();
            Thread.Sleep(3000);
        }

        private void FillTheControlFromExcelFile()
        {
            quote.QutationMainDetails.Txt_GroupName.SendKeys(TestContext.DataRow["GroupName"].ToString());
            quote.QutationMainDetails.DatePicker_FromDate.SendKeys(TestContext.DataRow["From"].ToString());
            MouseActionsHelper.DELETE_Click(quote.QutationMainDetails.DatePicker_ToDate);
            quote.QutationMainDetails.DatePicker_ToDate.SendKeys(TestContext.DataRow["To"].ToString());

            //Countries
            quote.QutationMainDetails.Combo_Country.Click();
            quote.QutationMainDetails.Combo_Country.SendKeys(TestContext.DataRow["Country"].ToString());
            MouseActionsHelper.ClickEnter(quote.QutationMainDetails.Combo_Country);

            //Agent
            Thread.Sleep(500);
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_chkAllCustomer"));
            quote.QutationMainDetails.AllAgentChkBox.Click();
            Thread.Sleep(500);
            GenericHelper.WaitForElementToBeClickAbleAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_cmbCustomer_Arrow"));
            quote.QutationMainDetails.Combo_AgentArrow.Click();
            Thread.Sleep(500);
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_cmbCustomer_Input"));
            MouseActionsHelper.DELETE_Click(quote.QutationMainDetails.Combo_Agent);
            quote.QutationMainDetails.Combo_Agent.SendKeys(TestContext.DataRow["Agents"].ToString());
            MouseActionsHelper.ClickEnter(quote.QutationMainDetails.Combo_Agent);

            //LANGUAGE
            Thread.Sleep(500);
            MouseActionsHelper.DELETE_Click(quote.QutationMainDetails.Combo_Language);
            quote.QutationMainDetails.Combo_Language.SendKeys(TestContext.DataRow["Languages"].ToString());
            MouseActionsHelper.ClickEnter(quote.QutationMainDetails.Combo_Language);

            //H.Std
            Thread.Sleep(500);
            quote.QutationMainDetails.Combo_HotelStandardArrow.Click();
            quote.QutationMainDetails.Combo_HotelStandard.SendKeys(TestContext.DataRow["HotelStd"].ToString());
            quote.QutationMainDetails.Combo_HotelStandardArrow.Click();

            //Adults
            quote.QutationMainDetails.Txt_AdultNumber.SendKeys(TestContext.DataRow["Adults"].ToString());

            //children
            quote.QutationMainDetails.Txt_ChildrenNumber.SendKeys(TestContext.DataRow["Children"].ToString());

            //Tour Leader
            quote.QuotationExtraDetails.Txt_TourLeader.SendKeys(TestContext.DataRow["TourLeader"].ToString());

            //Arrival
            quote.QuotationExtraDetails.Txt_ArrivalFlightBorder.SendKeys(TestContext.DataRow["Arrival"].ToString());

            //Flight Boarder
            quote.QuotationExtraDetails.Txt_ArrivalFlightBorder.SendKeys(TestContext.DataRow["FlightBoarder"].ToString());

            //Remarks
            quote.QuotationExtraDetails.TxtArea_Remarks.SendKeys(TestContext.DataRow["Remarks"].ToString());

            //click Add New Quote
            quote.QuotationActionButton.Btn_AddNewQuote.Click();
            Thread.Sleep(3000);

        }
    }
}
