using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.ComponenetHelper;

namespace TcoTestingFrameWork.PageObjectModel.TcoPackageLeftPanel
{
    class PomTransfer : PomPageBase
    {
        private IWebDriver _driver;

        #region WebElement
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbCountry_Input")]
        private IWebElement countryCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbRegion_Input")]
        private IWebElement regionCombo;

        [FindsBy(How=How.Id,Using = "ctl00_ContentPlaceHolder1_cmbService_Input")]
        private IWebElement serviceCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_radFromDate_dateInput")]
        private IWebElement dateTextBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_radFromDate_popupButton")]
        private IWebElement calendarToggle;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbSuppliers_Input")]
        private IWebElement supplierCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbCurrency_Input")]
        private IWebElement currencyCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_chkAllSuppliers")]
        private IWebElement allSuplliersCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_txtAdults")]
        private IWebElement adultsNumberTextBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_txtChildren")]
        private IWebElement childrenNumberTextBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_txtInfants")]
        private IWebElement infantsNumberTextBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cntCalcEfees1_btnCalc__input")]
        private IWebElement calcPriceButton;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cntCalcEfees1_txtPrice")]
        private IWebElement priceTextBox;

        [FindsBy(How = How.Id, Using = "grid")]
        private IWebElement detailsGrid;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_btnRSV")]
        private IWebElement reserveButton;

        #endregion
        public PomTransfer(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region Actions
       
        public void ClickCountrycombo()
        {
            countryCombo.Click();
        }
            
        
        #endregion
    }
}
