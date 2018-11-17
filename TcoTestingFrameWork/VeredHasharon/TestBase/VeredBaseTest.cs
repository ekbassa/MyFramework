using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcoTestingFrameWork.VeredHasharon.TestBase
{
    public class VeredBaseTest
    {

        public  IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void InitResourcesBeforeEveryTest()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);

        }
        [TestCleanup]
        public void CloseAndQuit()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
