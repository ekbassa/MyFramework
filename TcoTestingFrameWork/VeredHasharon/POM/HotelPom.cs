using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class HotelPom : PomPageBase
    {
        private IWebDriver _driver;
        public HotelPom(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            HotelTitleAndIcons = new HotelTitleAndIcons(driver);
            HotelDatesAndregions = new HotelDatesAndregions(driver);

        }
        public HotelTitleAndIcons HotelTitleAndIcons { get; private set; }
        public HotelDatesAndregions HotelDatesAndregions { get; private set; }


        #region HotelPage_HotelTabAndOptions
        public IWebElement HotelTab => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[1]"));
        public IWebElement CancelHotel => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[4]"));
        public IWebElement ShowBoardEveryDay => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[5]"));
        public IWebElement AddToPriceLIst => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[6]"));
        public IWebElement OpenPriceList => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[7]"));
        #endregion

        #region HotelTabs_PrintingTabAndOptions
        public IWebElement PrintingTab => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[8]"));
        public IWebElement PrintRoomingList => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[11]"));
        public IWebElement PrintReservation => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_TopRadMenu1']/descendant::span[12]"));

        #endregion



    }
}
