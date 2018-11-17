using TcoTestingFrameWork.Settings;
using OpenQA.Selenium;


namespace TcoTestingFrameWork.ComponenetHelper
{
   public  class TextBoxHelper
    {
        private static IWebElement element;



        public static void SendKeys(By locator, string text)
        {
            element = GenericHelper.GetElement(locator);
            element.SendKeys(text);
        } 

        public static void ClearTextBox(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Clear();
        }
   }
}
