using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public class DropDownListHelper
    {
        /* To handle the Dropdownlist we have to Use : 
         * 1 : the class " SelectElement " that includes several methods we are going to use only 3 from them
         *   1.1: " SelectByIndex" Method
         *   1.2: " SelectByValue" Method
         *   1.3: " SelectByText"    Method
         */

        private static IWebElement element;

        private static SelectElement select;

        public static void SelectElementByIndex(By locator,int indx)
        {
            element = GenericHelper.GetElement(locator);
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(indx);
        }

        public static void SelectElementByValue(By locator,string value)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(value);
        }

        public static void SelectElementByText(By locator, string text)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(text);
        }

        public static IList<string> SelectElementByText(By locator)
        {
            
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }

        public static int ItemtsCountInDropBox(By locator)
        {
            IList<string> DropDownList = SelectElementByText(locator);
            return DropDownList.Count;
        }

    }
}
