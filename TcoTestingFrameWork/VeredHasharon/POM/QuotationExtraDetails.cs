using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QuotationExtraDetails
    {
        private IWebDriver Driver;

        public QuotationExtraDetails(IWebDriver driver)
        {
            Driver = driver;
        }

        #region ExtraDetailsIwebElements
        public IWebElement Txt_TourLeader => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtTourLeader"));
        public IWebElement Txt_ArrivalFlightBorder => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtArrivalFlight"));
        public IWebElement Txt_DepartureFlightBorder => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtDepartureFlight"));
        public IWebElement TxtArea_Remarks => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtRemarks"));
        public IWebElement Txt_DocketNumberInQuotation => Driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_RadtxtFile']"));
        #endregion


        #region Actions
    
        public string GetDocketNumberFromQuotation()
        {
            return Txt_DocketNumberInQuotation.GetAttribute("value");
        }     
        #endregion

    }

}