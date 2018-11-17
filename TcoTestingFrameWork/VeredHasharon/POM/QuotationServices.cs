using OpenQA.Selenium;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public  class QuotationServices
    {
        private IWebDriver Driver;

        public QuotationServices(IWebDriver driver)
        {
            Driver = driver;
            HotelTitleAndIcons = new HotelTitleAndIcons(driver);
        }
        public HotelTitleAndIcons HotelTitleAndIcons { get; private set; }
        #region Services_IwebElements     
        public IWebElement ServicesHeader => Driver.FindElement(By.XPath("//div[@class='bTitle']"));
        public IWebElement Service_Hotel => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnHotels"));
        public IWebElement Service_Transfer => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnTransfer"));
        public IWebElement Service_Guide => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnGuide"));
        public IWebElement Service_EntranceFees => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnEntranceFees"));
        public IWebElement Service_Restaurant => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnRestaurant"));
        public IWebElement Service_Smile => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnSmile"));
        public IWebElement Service_Miscellaneous => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnMiscellaneous"));
        public IWebElement Service_International => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnInternational"));
        public IWebElement Service_Calculation => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnCalculation"));
        public IWebElement Service_FullTripItinerary => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnFullTripItinerary"));
        public IWebElement Service_Itinerary => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnItenirary"));
        public IWebElement Service_Remarks => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnRemarks"));
        public IWebElement Service_Flights => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cntServicesNavigator_btnFlights"));
        #endregion


    }
   
}