using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.BaseClasses;
using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class WelcomToTcoPage : PomPageBase
    {
        private IWebDriver _driver;
        #region IwebElement
        public IWebElement ClerkMenu            => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[1]"));
        public IWebElement DataEntry            => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[2]"));
        public IWebElement ReservationCenter    => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[3]"));
        public IWebElement Queries              => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[4]"));
        public IWebElement ManageBuses          => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[5]"));
        public IWebElement Reports              => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[6]"));
        public IWebElement Accounting           => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[7]"));
        public IWebElement Incoming             => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[8]"));
        public IWebElement ManagePromotions     => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[9]"));
        public IWebElement PivotdataCharts      => base.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[10]"));
        #endregion
        #region ctors
        public WelcomToTcoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
           
        }
        #endregion

        #region Actions
        public QuotationsList ClickIncoming()
        {
            Incoming.Click();
            return new QuotationsList(_driver);
        }
        
        #endregion
       
    }
    
}
    

