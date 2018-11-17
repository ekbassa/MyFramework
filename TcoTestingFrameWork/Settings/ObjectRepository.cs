using TcoTestingFrameWork.Interfaces;
using OpenQA.Selenium;

namespace TcoTestingFrameWork.Settings
{
    public class ObjectRepository
    {
        public static  IWebDriver Driver {get;set;}
        public static Iconfig Config { get; set; }

    }
}
