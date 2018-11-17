using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class HotelDatesAndregions
    {
        private IWebDriver Driver;

        public HotelDatesAndregions(IWebDriver driver)
        {
            Driver = driver;
        }
        #region IwebElements
        public int MyProperty { get; set; }
        #endregion
    }
}