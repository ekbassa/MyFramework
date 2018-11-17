using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts.Functionality_Testing.Hotels
{
    [TestClass]
    public class HotelsTestingClass
    {
        [TestMethod]
        [TestCategory("hotels Title And Icons")]
        [Description("this test reaches the quotation sheet and clicks the hotel icon=> closes the hotel form and => back to quotation sheet")]
        public void TestClosingTheHotelForm()
        {
            QuotationSheet quote = ReachTheQiotationPage();
            quote.QuotationServices.Service_Hotel.Click();
            Thread.Sleep(3000);
            quote.QuotationServices.HotelTitleAndIcons.Close.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("hotels Title And Icons")]
        [Description("this test reaches the quotation sheet and clicks the hotel icon=> closes the hotel form and => back to quotation sheet")]
        public void TestMiniMizingTheHotelForm()
        {
            QuotationSheet quote = ReachTheQiotationPage();
            quote.QuotationServices.Service_Hotel.Click();
            Thread.Sleep(3000);
            quote.QuotationServices.HotelTitleAndIcons.Minimize.Click();
            Thread.Sleep(3000);
        }


        private static QuotationSheet ReachTheQiotationPage()
        {
            NavigationHelper.InitServices();
            QuotationSheet quote = new QuotationSheet(ObjectRepository.Driver);
            return quote;
        }
    }
}
