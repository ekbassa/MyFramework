using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;
using TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu;

namespace TcoTestingFrameWork.TestScripts.TempScripts
{
    [TestClass]
    public class GetAllTableElements       
    {
        public TestContext Testcontext { get; set; }
        public static List<IWebElement> ServiceAbbr = new List<IWebElement>();
        [TestMethod]
        public void getAllElements()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            var element = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/descendant::tr[2]"));
            MouseActionsHelper.DoubleClick(element);
            Thread.Sleep(3000);


            //locate the table element
            IWebElement docketTable = ObjectRepository.Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/child::tbody"));

            //locate the rows in the original table docketTable
            List<IWebElement> tableRows = new List<IWebElement>(docketTable.FindElements(By.TagName("tr")));

            Console.WriteLine("current table has .{0}", tableRows.Count);

            foreach (var colElement in tableRows)
            {
                //Getting Number of cols in row table

                IList<IWebElement> cols = new List<IWebElement>(colElement.FindElements(By.TagName("td")));

                if (cols.Count > 0)
                {
                    //Iterating through each cell

                    foreach (var cellData in cols)
                    {
                        //getting each cell data


                        if (cellData.Text == "CALF")
                        {
                            ServiceAbbr.Add(cellData);
                        }
                        //Console.WriteLine("Cell No " + data);
                    }
                }
            }
            Console.WriteLine("ServiceAbbr count Is.{0}", ServiceAbbr.Count);
    

             
        //   List<IWebElement>  CellsList = new List<IWebElement>(docketTable.FindElements(By.TagName("td")));

        //List<IWebElement> templist = new List<IWebElement>(tableRows[0].FindElements(By.TagName("td")));
    }
    }
}
    

