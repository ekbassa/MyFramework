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
    public  class SelectIncomingTours
    {
        [TestMethod]
        [TestCategory("Functionality Tests")]
        public void ClickIncoming()
        {
            NavigationHelper.SelectIncomingToursAndOpenById();
            QuotationSheet Quote = new QuotationSheet(ObjectRepository.Driver);

            /*
             * it is important to switch to child window 
             * otherwise it will not work
             * because when we will reach this page , webdriver will be focused on the parent window
             */
            BrowserHelper.SwitchToWindow(1);
            Thread.Sleep(3000);     
        }
  
    }
}
