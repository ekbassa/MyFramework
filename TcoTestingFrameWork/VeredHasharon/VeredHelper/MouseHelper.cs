using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.VeredHasharon.Settings;
using TcoTestingFrameWork.VeredHasharon.TestBase;

namespace TcoTestingFrameWork.VeredHasharon.VeredHelper
{
    public  class MouseHelper
    {
        public  IWebDriver Driver { get; set; }

        public MouseHelper(IWebDriver driver)
        {
            Driver = driver;
        }
        public  void HoverAnElement(IWebElement  element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element)
                .Build()
                .Perform();        
        }
        
    }
}
