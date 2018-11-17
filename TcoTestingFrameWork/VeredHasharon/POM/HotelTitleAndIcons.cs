using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class HotelTitleAndIcons
    {
        private IWebDriver Driver;

        public HotelTitleAndIcons(IWebDriver driver)
        {
            Driver = driver;
        }
        #region HotelTitleAndIcons
        public IWebElement PinOn => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::li[1]"));
        public IWebElement Reload => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::li[2]"));
        public IWebElement Minimize => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::li[3]"));
        public IWebElement Restore => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::li[4]"));
        public IWebElement Close => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::li[5]"));
        public IWebElement ServiceTitle => Driver.FindElement(By.XPath("//tr[@class='rwTitleRow']//descendant::em[contains(text(),'Hotels')]"));
        #endregion
    }
}