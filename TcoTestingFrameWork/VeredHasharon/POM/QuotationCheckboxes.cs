using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public  class QuotationCheckboxes
    {
        private IWebDriver Driver;

        public QuotationCheckboxes(IWebDriver driver)
        {
            Driver = driver;
        }
        #region CheckBoxes Region
        public IWebElement Chk_Fit => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkFIT"));
        public IWebElement Chk_Guide => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkGuide"));
        public IWebElement Chk_ActiveReservation => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_CKActiveRsrv"));
        public IWebElement Chk_SentResevations => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_CKSentRsrv"));
        #endregion
        #region CheckBoxex Actions
        public void TicCheckbox_FIT()
        {
            Chk_Fit.Click();
        }
        public void TicCheckbox_Guide()
        {
            Chk_Guide.Click();
        }
        public void TicCheckbox_ActiveReservation()
        {
            Chk_ActiveReservation.Click();
        }
        public void TicCheckbox_SentResevations()
        {
            Chk_Fit.Click();
        }
        #endregion

    }
}