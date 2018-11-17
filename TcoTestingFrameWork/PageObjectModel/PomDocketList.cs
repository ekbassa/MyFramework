using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.BaseClasses;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.PageObjectModel
{
    public class PomDocketList :PomPageBase
    {
        private IWebDriver _driver;
        #region IwebElement
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_btnShow")]
        private IWebElement ShowButton;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_chkOpenedToday")]
        private IWebElement OpenedTodayCheckBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cldFromDate_Image1")]
        private IWebElement FromDateCalendar;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cldToDate_Image1")]
        private IWebElement ToDateCalendar;
        #endregion
        public PomDocketList(IWebDriver driver ):base(driver)
        {
            _driver = driver;
        }

        #region Actions
        public void ClickShowButton()
        {
            ShowButton.Click();
        }

        public void SelectFromdate()
        {
            FromDateCalendar.Click();
        }
        

        #endregion

    }
}


