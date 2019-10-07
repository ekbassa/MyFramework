using TcoTestingFrameWork.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;
//using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using TcoTestingFrameWork.VeredHasharon.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponentHelper;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public  class GenericHelper
    {   
        public static void OpenExistingFile(string fileNumber)
        {  
           /*  Switch to frame
               Note --> I found Iframe Xpath from the main form not from the small new form that appears in the main form
               the Iframe xpath is constant 
            */

            BrowserHelper.SwitchToFrame(ObjectRepository.Driver.FindElement(By.XPath("//div[@id='cboxLoadedContent']/child::iframe ")));
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//input[@id='txtFileNo']")).SendKeys(fileNumber);

            //locate the OK Button and click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("btnOk")).Click();
        }

        public static void OpenExistingQuote(string quoteNumber)
        {
            //switch to frame         
            BrowserHelper.SwitchToFrame(ObjectRepository.Driver.FindElement(By.XPath("//iframe[@name='RadWindow1']")));
            WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//form//descendant::input[@id='txtFileNo']")).SendKeys(quoteNumber);

            //locate the OK Button and click it 
            WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("btnOk")).Click();
        }
        public static  string GetTheQuteNumBerFromExcel()
        {
            return ObjectRepository.Driver.FindElement(By.XPath("//form//descendant::input[@id='txtFileNo']")).GetAttribute("value").ToString(); ;         
        }
        public static int  ConvertStringIntoInt(string stringValue)
        {
            if (stringValue == null)
                return 0;
            else
            {
                int outvalue;
                int.TryParse(stringValue, out outvalue);
                return outvalue;
            }          
        }

        public static string ConvertIntegerToString(int intValue)
        {
            if(intValue == 0)
            {
                return "0";
            }
            else
            {
                return intValue.ToString();
                
            }
        }
    

        public static decimal  ConvertToDecimal(string  value)
        {
            if (value == null)
            {
                return 0;
            }
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";
            decimal decimalValue = decimal.Parse(value,format);
            return decimalValue;
        }

        public static bool IsElementPresents(By locator)
        {
            /* if the element presents the count will be 1
             * otherwise zer0 : that means the the element is not presents 
             */

            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public static IWebElement  GetElement(By locator)
        {
            // if the element presents get it 

            if (IsElementPresents(locator))             
                  return ObjectRepository.Driver.FindElement(locator);               
            else           
                 throw new NoSuchElementException("Element not found" + locator.ToString());            
        }

        public static IWebElement  WaitForElementAndGetIt(IWebDriver driver,By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(ObjectRepository.Config.GetElementTimeOut()));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement DynamicElement = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return DynamicElement;
        }

        public static IWebElement WaitForElementToBeClickAbleAndGetIt(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(ObjectRepository.Config.GetElementTimeOut()));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement DynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return DynamicElement;
        }

        public static bool WaitForElement(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(ObjectRepository.Config.GetElementTimeOut()));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return WaitForElementAndGetIt(driver, locator).Displayed;
        }

        public static void PageLoadTimeOut()
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut()));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));         
        }
    }
}
