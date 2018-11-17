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
    public class ExtractDataFromMainQuoteDetails
    {
        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void MainDetails_GetQuoteGroupName()
        {
            QuotationSheet Quote = InitMainQuoteDetails();
            Console.WriteLine("the Quotation Group Nmae Is:\t{0}", Quote.QutationMainDetails.GetGroupName());
        }

        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void MainDetails_CheckLanguagesAndAgents()
        {
            QuotationSheet Quote = InitMainQuoteDetails();
            Quote.QutationMainDetails.AllAgentChkBox.Click();
            Quote.QutationMainDetails.AllLanguagesChkBox.Click();
            Thread.Sleep(3000);
        }



        private static QuotationSheet InitMainQuoteDetails()
        {
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            NavigationHelper.SelectIncomingToursAndOpenById();
            BrowserHelper.SwitchToWindow(1);
            return Quote;
        }
    }
}
