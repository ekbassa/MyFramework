using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.VeredHasharon.VeredHelper
{
    public class ComboBoxHelper
    {
        private   IWebDriver Driver { get; set; }
     
        public ComboBoxHelper(IWebDriver driver)
        {
            Driver = driver;
        }

        public static  void SelectElementByText(By locator, string text)
        {

            var select = new SelectElement(GetElement(locator));
            select.SelectByValue(text);
        }
        public static void SelectElementByValue(By locator, string  value)
        {
            var select = new SelectElement(GetElement(locator));
            select.SelectByValue(value);
        }


        private static IWebElement GetElement(By locator)
        {
            return ObjectRepository.Driver.FindElement(locator);
        }
    }
}
