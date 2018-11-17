using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.BaseClasses;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.PageObjectModel
{
    public  class PomWelcomToTCO :PomPageBase
    {
        private IWebDriver _driver;
        #region IwebElement
        public IWebElement ClerkMenu => Driver.FindElement(By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=1]"));
        public IWebElement DataEntry => Driver.FindElement(By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=2]"));
        public IWebElement ReservationCenter => Driver.FindElement(By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=3]"));
        public IWebElement FinanceAndControl => Driver.FindElement(By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=5]"));
        #endregion
        public PomWelcomToTCO(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }

        #region Actions
        public PomDocketList ClickClerkMenu()
        {
            ClerkMenu.Click();
            return new PomDocketList(_driver);
        }
        public void ClickDataEntry()
        {
            DataEntry.Click();
        }
        public void ClickReservationCenter()
        {
            ReservationCenter.Click();
        }
        public void ClickFinancaAnCotrol()
        {
            FinanceAndControl.Click();
        }
        #endregion

        #region Navigation
        public void NavigateToClerkMenu()
        {

        }
        #endregion
    }
}
