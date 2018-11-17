using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.BaseClasses
{
    public  class PomPageBase
    {
        public  IWebDriver Driver { get; set; }
        #region IwebElements
        public IWebElement HomePageLink => Driver.FindElement(By.Id("LinkHomePage"));
        public IWebElement LogOutLink => Driver.FindElement(By.Id("ctl00_CleckControll1_btnLogOut"));
        public IWebElement UserLoggedInAs => Driver.FindElement(By.Id("CleckControll1_lblClerkName"));
        public IWebElement CloseApplication => Driver.FindElement(By.XPath("//div[@class='TCOLogInClase']"));

        #endregion
        #region Ctors


        //public PomPageBase(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        public PomPageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        #endregion
        #region Navaigations




        public void NavigateToTcoWelcomPage()
            { 
               if (GenericHelper.IsElementPresents(By.Id("LinkHomePage")))            
               HomePageLink.Click();
            }

        public string GetUserName()
        {
            return UserLoggedInAs.Text;
        }
        public void UserLogout()
        {
            LogOutLink.Click();
        }
        public void ShutTheApp()
        {
            CloseApplication.Click();
        }

      
        #endregion



    }
}
    

