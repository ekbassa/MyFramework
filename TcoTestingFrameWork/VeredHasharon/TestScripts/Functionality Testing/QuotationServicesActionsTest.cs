using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts.Functionality_Testing
{
    [TestClass]
    public class QuotationServicesActionsTest
    {
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_SelectHotel()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Hotel.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_SelectTransfer()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Transfer.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_EnteranceFees()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_EntranceFees.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Miscellaneous()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Miscellaneous.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Restaurant()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Restaurant.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Smile()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Smile.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_CalcSheet()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Calculation.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_FullTripItinerary()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_FullTripItinerary.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Intinerary()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Itinerary.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Remarks()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Remarks.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Filght()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Flights.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_international()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_International.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Servies  Functionality Tests")]
        public void Services_Guide()
        {
            QuotationSheet Quote = InitServices();
            Quote.QuotationServices.Service_Guide.Click();
            Thread.Sleep(3000);
        }


        private static QuotationSheet InitServices()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            BrowserHelper.SwitchToWindow(1);
            return Quote;
        }
    }
}
