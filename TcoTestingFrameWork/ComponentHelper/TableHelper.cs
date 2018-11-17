using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System.Collections.Generic;
using TcoTestingFrameWork.Settings;


namespace TcoTestingFrameWork.ComponentHelper
{
    public  class TableHelper
    {
        public static  int GetExpectedPaxNumber(By locator)
        {
          return   ObjectRepository.Driver.FindElements(locator).Count;
        }

        public static int GetActualPaxNumber()
        {
            // The PaxNumberActualResult is Const for all dockets therefore it is hardCoded
            var PaxNumberActualResult = (GenericHelper.GetElement(By.Id("ctl00_ContentPlaceHolder1_LblPaxNumValue"))).Text;

            int temp = GenericHelper.ConvertStringIntoInt(PaxNumberActualResult);
            return temp;
        }

        public static IWebElement GetTable(By TableLocator)
        {
            var tableName = ObjectRepository.Driver.FindElement(TableLocator);
            return tableName;
        }

        public static int GetTableRowsCount(By Tablelocator,By RowLocator)
        {
            var tableName = GetTable(Tablelocator);
            List<IWebElement> TableRows = new List<IWebElement>(tableName.FindElements(RowLocator));
            return TableRows.Count;
        }

        public static List<IWebElement> GetTableRows(By Tablelocator, By RowLocator)
        {
            var tableName = GetTable(Tablelocator);
            List<IWebElement> TableRows = new List<IWebElement>(tableName.FindElements(RowLocator));
            return TableRows;
        }
    }
}
