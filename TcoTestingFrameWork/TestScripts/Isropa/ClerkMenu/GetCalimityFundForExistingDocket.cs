using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public  class GetCalimityFundForExistingDocket
    {
        [TestMethod]
        public void  GetCalimity()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            // wait until find the  " File " tab And Click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='File']")).Click();

            //wait for the " open exsiting file " option and click it 
            var ExistingFile  = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='Open Existing File']"));
            ExistingFile.Click();
            GenericHelper.OpenExistingFile("170228");

            /* now switch to the Child window*/
            BrowserHelper.SwitchToWindow(1);

            //locate the table element
            IWebElement docketTable = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody"));

            //locate the rows in the original table docketTable
            List<IWebElement> tableRows = new List<IWebElement>(docketTable.FindElements(By.TagName("tr")));

            //loop over the tablerow the select the " CALF " Cell and its rate
            int rowIndx = 1;
            decimal TotalCalimity = 0;
                                            
            foreach (var item in tableRows)
            {
                var cellText = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody/child::tr[" + rowIndx + "]/td[2]")).Text;
                if (cellText == "CALF")
                {
                    var CalfRate = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody/child::tr[1]/td[8]")).Text;
                    TotalCalimity += GenericHelper.ConvertToDecimal(CalfRate);
                    rowIndx++;
                }
            }
            Console.WriteLine("Total Calimity fund for this Docket Is. {0}\t", TotalCalimity);
           // return TotalCalimity;
        }       
    }
}
