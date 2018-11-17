using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;

namespace TcoTestingFrameWork.PageObjectModel
{
    class SearchClient : PomPageBase
    {
        private IWebDriver _driver;

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//span[text()='Basic Data']")]
        private IWebElement BasicDataTab;

        [FindsBy(How = How.XPath, Using = "//span[@class='rtsTxt'][text()='Search']")]
        private IWebElement SearchTab;

        [FindsBy(How = How.XPath, Using = "//span[@id='ctl00_ContentPlaceHolder1_txtNameSearch_wrapper']")]
        private IWebElement NameTxtBox;

        [FindsBy(How = How.XPath, Using = "//span[@id='ctl00_ContentPlaceHolder1_txtPassportNoSearch_wrapper']")]
        private IWebElement PassportNumberTxtBox;

        [FindsBy(How = How.XPath, Using = "//span[@class='rbIcon p-icon p-i-checkbox-checked rbToggleCheckboxChecked']")]
        private IWebElement LNameCheckBox;

        [FindsBy(How = How.Id, Using = "//input[@id='ctl00_ContentPlaceHolder1_txtYOBSearch']")]
        private IWebElement YOBTextBox;

        [FindsBy(How = How.Id, Using = "//input[@id='ctl00_ContentPlaceHolder1_cmbCitySearch_Input']")]
        private IWebElement CityComboBox;

        [FindsBy(How = How.XPath, Using = "//span[@id='ctl00_ContentPlaceHolder1_btnSearch']")]
        private IWebElement SearchBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_ContentPlaceHolder1_btnClear_input']")]
        private IWebElement ClearBtn;
        #endregion
        public SearchClient(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
    }
}
