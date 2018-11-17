using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public  class RadioButtonHelper
    {
        private static IWebElement element;

        public static void  ClickRadioButton(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();
        }

        public static bool IsRadioButtonChecked(By locator)
        {
            element = GenericHelper.GetElement(locator);
            string value = element.GetAttribute("checked");

            /*check if the Radio button is checked or not
             * if it is checked the GetAttribute function is going to return the value "checked" if not it is going to return null  */

            if (value == null) return false;
            else
                return value.Equals("true") || value.Equals("Checked");
        }
    }
}
