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
    public class TestQuoteCheckBoxes
    {
        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void CheckBoxes_checkAndUnchek()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet quote = new QuotationSheet(ObjectRepository.Driver);
            BrowserHelper.SwitchToWindow(1);
            quote.QuotationCheckboxes.Chk_ActiveReservation.Click();
            quote.QuotationCheckboxes.Chk_Fit.Click();
            quote.QuotationCheckboxes.Chk_Guide.Click();
            quote.QuotationCheckboxes.Chk_SentResevations.Click();
            Thread.Sleep(3000);
        }
    }
}
