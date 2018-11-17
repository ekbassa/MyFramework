using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public class CheckIfcalimityIsAppropriate
    {
        private TestContext _Testcontext;

        public TestContext TestContext
        {
            get { return _Testcontext; }
            set { _Testcontext = value; }
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;", "DocketsNumber$", DataAccessMethod.Sequential)]
        public void IsCalimityAppropriate()
        {        
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            // wait until find the  " File " tab And Click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='File']")).Click();

            //wait for the " open exsiting file " option and click it 
            var ExistingFile = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[text()='Open Existing File']"));
            ExistingFile.Click();


           
            GenericHelper.OpenExistingFile(TestContext.DataRow["DocketID"].ToString());

           
            //-----------------------------------------------------------------------------------------------------------

            /* now switch to the Child window*/
            BrowserHelper.SwitchToWindow(1);

            //locate the "Show All Clients" checkbox and click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_chkShowAllClients")).Click();

            // wait 1 second
            Thread.Sleep(1000);

            //compare between the displayed number and the actual rows number if they are equals
            var DisplayedNumber = TableHelper.GetExpectedPaxNumber(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_GVPaxs']/tbody/child::tr"));
            Assert.AreEqual(DisplayedNumber, TableHelper.GetActualPaxNumber());


            //locate the table element
            IWebElement docketTable = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody"));

            //locate the rows in the original table docketTable
            List<IWebElement> tableRows = new List<IWebElement>(docketTable.FindElements(By.TagName("tr")));

            //loop over the tablerow the select the " CALF " Cell and its rate
            int rowIndx = 1;
            decimal CALF = 0;
            decimal TotalServicesAmount = 0;

            foreach (var item in tableRows)
            {                
                if (rowIndx <= tableRows.Count)
                {
                    var cellText = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody/child::tr[" + rowIndx + "]/td[2]")).Text;
                    var AmountText = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody/child::tr[" + rowIndx + "]/td[8]"));
                    TotalServicesAmount += GenericHelper.ConvertToDecimal(AmountText.Text);
                    if (cellText == "CALF")
                    {
                        var CalfRate = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody/child::tr[" + rowIndx + "]/td[8]")).Text;
                        CALF += GenericHelper.ConvertToDecimal(CalfRate);                      
                        rowIndx++;
                    }
                    else
                    {
                        rowIndx++;
                    }                
                }           
            }
            /* Verifying if the docket has services at all,by checking is CALF is bigger than Zero
              COMPLETE HERE THE CODE 

            */
            var CALF1 = Convert.ToDouble(CALF);
            var expectedCalimityRate = CalculateCalimityFund(DisplayedNumber);

            try
            {
                Assert.AreEqual(expectedCalimityRate, CALF1, "Fail at docket" + TestContext.DataRow["DocketID"].ToString());           
                Thread.Sleep(1000);
                Console.WriteLine("Total Pax :{0}", DisplayedNumber);
                Console.WriteLine("Expected Calimity fund Is. {0}", expectedCalimityRate);
                Console.WriteLine("The calimity Fund in  Docket:{0} is Appropriate : {1}  Euro", TestContext.DataRow["DocketID"].ToString(), expectedCalimityRate);
                Console.WriteLine("total services = :{0}",TotalServicesAmount);
                NavigationHelper.TcoLogOut();
            }
            catch 
            {             
                Console.Beep(); Console.Beep();
                Console.WriteLine("Total Pax :{0}", DisplayedNumber);
                Console.WriteLine("Expected Calimity fund Is. {0}", expectedCalimityRate);
                Console.WriteLine("The calimity Fund in  Docket:{0} Is Not Appropriate : {1}  Euro", TestContext.DataRow["DocketID"].ToString(), CALF1);
               
                NavigationHelper.TcoLogOut();
            }

            Assert.AreEqual("TCO Log In", WindowHelper.GetTitle());

        }

        //this recursive function calculates the calimity fund according the pax number 
        public double CalculateCalimityFund(int PaxNum)
        {
            if (PaxNum <= 9)
                return 2.5;
            return 2.5 + CalculateCalimityFund(PaxNum - 9);
        }

    }

}
