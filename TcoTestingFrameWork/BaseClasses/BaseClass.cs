using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Configuration;
using TcoTestingFrameWork.CustomException;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.BaseClasses
{
    [TestClass]

    /* we are using here the [TestClass] attribute because we used the
     * [AssemblyInitialize]  for the  " public static void IntiWebDriver(TestContext tc) " Method 
     *  if we will remove the [TestClass] Attribute the system will not launch the browser      *  
     */
    public class BaseTest
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximaized");
            return option;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions option = new InternetExplorerOptions();

            // this is going to delete the cookies

            option.EnsureCleanSession = true;
            option.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            option.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
           
            return option;

            
        }

        //Create the three methods thats create the Chrome/IExplorer/ Firefox driver

        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }




        [AssemblyInitialize]
        // this method is going to be the first method to be executed because of the AssemblyInitialize attribute
        public static void IntiWebDriver(TestContext tc)
        {
             ObjectRepository.Config = new AppConfigReader();
 
             switch( ObjectRepository.Config.GetBrowser())
            {
                   case BrowserType.Chrome :ObjectRepository.Driver = GetChromeDriver();  break;
                   case BrowserType.FireFox:ObjectRepository.Driver = GetFireFoxDriver(); break;
                   case BrowserType.IExplorer:ObjectRepository.Driver = GetIEDriver();    break;
                default:throw new WebDriverNotFound("Driver not found " + ObjectRepository.Config.GetBrowser().ToString());
            }

            /* reading the page load time out from the App.config file 
             * and this wait is only for the page loading    */

            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            BrowserHelper.MaximizeWindow();
        }

        [AssemblyCleanup]
        // this method is going to be executed in the end of the test 
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null )
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
