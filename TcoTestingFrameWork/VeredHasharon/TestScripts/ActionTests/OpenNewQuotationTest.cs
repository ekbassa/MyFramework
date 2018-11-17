using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;

namespace TcoTestingFrameWork.VeredHasharon.TestScripts.ActionTests
{
    [TestClass]
    public  class OpenNewQuotationTest
    {
        [TestMethod]
        [TestCategory("Action Tests")]
        public void OpenNewQuote_Test()
        {
            NavigationHelper.SelectIncoming();
            Thread.Sleep(3000);
        }
    }
}
