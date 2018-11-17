using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.ComponentHelper
{
    public  class MouseActionsHelper
    {
        
        public static void RightClick(IWebElement  element)
        {
            ///  this Method is going to perform a right click on a specific web element
            ///  
            //create the actions class instance
            Actions act = new Actions(ObjectRepository.Driver);
            act.ContextClick(element)
               .Build()
               .Perform();   
        }

       public static void DoubleClick(IWebElement element)
        {
            ///  this Method is going to perform Double  click on a specific web element

            Actions act = new Actions(ObjectRepository.Driver);
            act.DoubleClick(element)
               .Build()
               .Perform();
        }
        public static void hoverAnElement(IWebElement element)
        {
            ///this method is going to hover on a specific elements
            Actions act = new Actions(ObjectRepository.Driver);
            act.MoveToElement(element)
                .Build()
                .Perform();
        }
        public static void HoverAndClick(IWebDriver driver,IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(ObjectRepository.Driver);
            hoverAnElement(elementToHover);
            action.Click(elementToClick)
                .Build()
                .Perform();
        }
        public static void ClickEnter(IWebElement element)
        {
            Actions action = new Actions(ObjectRepository.Driver);          
            action.SendKeys(element, Keys.Enter)
                .Build()
                .Perform();
        }
        public static void DELETE_Click(IWebElement element)
        {
            Actions action = new Actions(ObjectRepository.Driver);
            action.SendKeys(element, Keys.Delete)
                .Build()
                .Perform();
        }
        
    }
}
