using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;

namespace TcoTestingFrameWork.PageObjectModelNazarene
{
    public class QuotationsList : PomPageBase
    {
        private IWebDriver _driver;
        #region IwebElement
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Label27")]
        private IWebElement PageTitle;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbCatagory_Input")]
        private IWebElement CategoryOption;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_chkAll")]
        private IWebElement AllCheckBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_chkOLD")]
        private IWebElement OldCheckBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cmbStatus_Input")]
        private IWebElement StatusComboBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_btnPleaseShow")]
        private IWebElement PleasShowButton;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_btnNewSheet")]
        private IWebElement newSheetButton;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_RadGrid1_GridData")]//ctl00_ContentPlaceHolder1_RadGrid1_ctl00__0
        private IWebElement quotationListGrid;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_mnuTopn0")]
        private IWebElement sheetsNavBar;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_mnuTopn1")]
        private IWebElement filesNavBar;



        #endregion
        public QuotationsList(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region Actions
        public void ticTcheckBoxAll()
        {
            AllCheckBox.Click();
        }
        public void clickShowButton()
        {
            PleasShowButton.Click();
        }
        #endregion

    }
}
