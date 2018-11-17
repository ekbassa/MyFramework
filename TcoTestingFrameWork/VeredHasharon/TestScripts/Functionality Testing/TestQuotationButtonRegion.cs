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
    public  class TestQuotationButtonRegion
    {
        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void ButtonRegion_ClickOpenGRPFile()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet quote = new QuotationSheet(ObjectRepository.Driver);
            BrowserHelper.SwitchToWindow(1);
            quote.QuotationActionButton.Btn_OpenGroupFile.Click();
            Thread.Sleep(4000);
        }
    }
}
