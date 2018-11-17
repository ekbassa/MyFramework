using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class TopMenu: PomPageBase
    {
        //private IWebDriver Driver;

        public TopMenu(IWebDriver driver):base(driver)
        {
            Driver = driver;
        }
        #region TopMenuElement
        #region CalcSheetsTabAndElements     
        public IWebElement CalcSheets => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::li[1]"));
        public IWebElement RegularSheet => Driver.FindElement(By.XPath("//span[@class='rmText'][contains(text(),'Regular Sheets')]"));
        public IWebElement GroupsSheet => Driver.FindElement(By.XPath("//span[@class='rmText'][contains(text(),'Groups Sheets')]"));
        #endregion
        #region SitesPriceListAndElements
        public IWebElement SitesPriceList => Driver.FindElement(By.XPath("//span[@class='rmText rmExpandDown'][contains(text(),' Price List')]"));
        public IWebElement SiteReservation => Driver.FindElement(By.XPath("//span[contains(text(),'Site Reservation')]"));
        #endregion
        #region DataEntryAndElements
        public IWebElement DataEntry => Driver.FindElement(By.XPath("//span[@class='rmText rmExpandDown'][contains(text(),'Data Entry')]"));
        public IWebElement TransferPrices => Driver.FindElement(By.XPath("//span[@class='rmText'][contains(text(),'Transfer Prices')]"));
        public IWebElement Suppliers => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[14]"));
        public IWebElement VehicleSize => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[15]"));
        public IWebElement Sites => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[16]"));
        public IWebElement ParkingFees => Driver.FindElement(By.XPath("//span[@class='rmText'][contains(text(),'Parking Fees')]"));
        public IWebElement TransferRegions => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[18]"));
        public IWebElement Guides => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[19]"));
        public IWebElement CountriesRegionsHotels => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[20]"));
        public IWebElement GuidePriceList => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[21]"));
        public IWebElement ServicePrices => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[22]"));
        public IWebElement Languages => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[23]"));
        public IWebElement HotelPrices => Driver.FindElement(By.XPath("//div[@id='ctl00_cntIncomingMenu1_TopPageRadIncommingMenu']/descendant::span[24]"));

        #endregion
        #endregion
    }
}