using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.TestScripts.Isropa;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
   [TestClass]
    public  class GetAllDocketsNumberFromTheDocketListPage
    {
        [TestMethod]
        public void GetDocketsNumber()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            //locate the table of the docket list and store all the dockets number in the DocketNumberList
            var DocketsNumberList = ObjectRepository.Driver.FindElements(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/tbody/tr/td[1]"));

            foreach (var item in DocketsNumberList)
            {
                Console.WriteLine(item.Text);
            }
        }
    }
}
