using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Nazarene.Incoming
{
    [TestClass]
    public class SelectAllCheckBoxFromQuotationMainPage
    {
        [TestMethod]
        [TestCategory("Incoming")]
        public void SelectAnyCheckBox()
        {
            NazLogin.LogInNazaren();

            Thread.Sleep(3000);
        }
       
    }
}
