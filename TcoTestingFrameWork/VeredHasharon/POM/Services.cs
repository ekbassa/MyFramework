using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class Services
    {
        private IWebDriver Driver;

        public Services(IWebDriver driver)
        {
            Driver = driver;
        }
        #region ServicesElements
        public IWebElement HotelService => Driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_cntServicesNavigator_btnHotels']"));
        #endregion
    }
}