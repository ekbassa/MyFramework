using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.ComponentHelper;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QuotationSheetTabs
    {
        public IWebDriver Driver { get; set; }

        public QuotationSheetTabs(IWebDriver driver)
        {
            Driver = driver;
        }

        #region PrintingTab
        public IWebElement Printing => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/descendant::span[1][contains(text(),'Printing')]"));
        public IWebElement PrintCoupon => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[1]/descendant::span[4]"));
        public IWebElement PrintItinerary => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[1]/descendant::span[5]"));
        public IWebElement PrintTransfer => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[1]/descendant::span[6]"));
        public IWebElement PrintQuotation => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[1]/descendant::span[7]"));
        #endregion
        #region PrintingTabActions
        public void CouponPrint()
        {
            MouseActionsHelper.HoverAndClick(Driver, Printing, PrintCoupon);
        }
        public void ItineraryPrint()
        {
            MouseActionsHelper.HoverAndClick(Driver, Printing, PrintTransfer);
        }
        public void TransferPrint()
        {
            MouseActionsHelper.HoverAndClick(Driver, Printing, PrintItinerary);
        }
        public void QuotationPrint()
        {
            MouseActionsHelper.HoverAndClick(Driver, Printing, PrintQuotation);
        }
        #endregion
        #region GroupsTab
        public IWebElement Tab_Groups => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[2]"));
        public IWebElement MakeNewGroup => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[4]"));
        public IWebElement OpenGroupFile => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[2]/descendant::span[5]"));
        #endregion
        #region ClientsOptions
        public IWebElement Tab_Clients => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[3]"));
        public IWebElement AddGroupMember => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[3]/descendant::span[4]"));
        #endregion
        #region Operations
        public IWebElement Tab_Operations => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[4]"));
        public IWebElement UpdateServicesInGrpFiles => Driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_mnuTop1']/child::ul/child::li[4]/descendant::span[4]"));
        #endregion
    }
}