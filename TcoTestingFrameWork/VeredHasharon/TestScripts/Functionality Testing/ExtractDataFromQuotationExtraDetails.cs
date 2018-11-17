using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts.Functionality_Testing
{
    [TestClass]
    public  class ExtractDataFromQuotationExtraDetails
    {
        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void ExtraDetails_GetGroupName()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);
            BrowserHelper.SwitchToWindow(1);
            Console.WriteLine("This Quote has  a Docket and its number Is:\t{0}",Quote.QuotationExtraDetails.GetDocketNumberFromQuotation());
        }
    }
}
