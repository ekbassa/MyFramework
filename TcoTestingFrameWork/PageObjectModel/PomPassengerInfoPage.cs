using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.PageObjectModel
{
    class PomPassengerInfoPage : PomPageBase
    {
        //Constructor
        private IWebDriver _driver;

        #region WebElements

        #region GuestInfo_IwebElements

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Room1_AdultGuest1_btnShow")]
        private IWebElement Magnifier;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Room1_AdultGuest1_DDLTitulation")]
        private IWebElement GuestGenderAbbrCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Room1_AdultGuest1_txtFirstName")]
        private IWebElement GuestFirstNameTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Room1_AdultGuest1_txtLastName")]
        private IWebElement GuestLastNameTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Room1_AdultGuest1_CLChildDOB_txt_Date")]
        private IWebElement GuestDOBTxtBox;

        #endregion

        #region MainContactDetails_IwebElements
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_DDLTitulation")]
        private IWebElement MainContactGenderAbbrCombo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtFirstName")]
        private IWebElement MainContactFirstNameTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtLastName")]
        private IWebElement MainContactLastNameTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_cldDOB_txt_Date")]
        private IWebElement MainContactDOBTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtStreet")]
        private IWebElement MainContactStreetNameTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtStreetNum")]
        private IWebElement MainContactStreetNumberTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtZipCode")]
        private IWebElement MainContactZipCodeTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtCity")]
        private IWebElement MainContactCityTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtCountryCode")]
        private IWebElement MainContactCountryCode1TxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtPhone1")]
        private IWebElement MainContactPhone1TxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtMobileCountryCode")]
        private IWebElement MainContactMobileCountryCodeTxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtPhone2")]
        private IWebElement MainContactPhone2TxtBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_CommunicationDetails1_txtEmail")]
        private IWebElement MainContactEmailTxtBox;

        #endregion

        #region BookingDetails
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Table1")]
        private IWebElement BookingDetailsGrid;
        #endregion

        #region TotalPrice
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_lblGlobalWebPrice")]
        private IWebElement BookingTotalPrice;
        #endregion

        #region ContinueBookingOrBack
        [FindsBy(How = How.XPath, Using = "//div[@class='GroupTopDetailsDynamicN']")]
        private IWebElement ContinueOrBackGrid;

        [FindsBy(How = How.XPath, Using = "//div[@class='GroupTopDetailsDynamicN']//div[1] [@class='sBack']")]
        private IWebElement BackArrowLink;

        [FindsBy(How = How.XPath, Using = "//div[@class='GroupTopDetailsDynamicN']//div[@id='tcoDiv']")]
        private IWebElement ContinueBookingButton;
        #endregion
        #endregion

        #region Actions
        public void ClickMagnifier()
        {
            Magnifier.Click();
        }
        
        #endregion

        #region Navigations
        #endregion
 

        public PomPassengerInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
    }
}
