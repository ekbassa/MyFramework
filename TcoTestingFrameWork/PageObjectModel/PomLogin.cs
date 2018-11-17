using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.BaseClasses;

namespace TcoTestingFrameWork.PageObjectModel
{
    public  class PomLogin : PomPageBase
    {
        private IWebDriver _driver;
        #region IwebElement
        public IWebElement UserNameTextBox => _driver.FindElement(By.Id("txtUserName"));
        public IWebElement PassWORDTextBox => _driver.FindElement(By.Id("txtPassword"));
        public IWebElement LoginButton => _driver.FindElement(By.Id("btnLogIn"));
        #endregion

        //constructor
        public PomLogin(IWebDriver driver ):base(driver)
        {
            _driver = driver;
        }
        #region Actions
        public PomWelcomToTCO  Login(string userName,string Password)
        {
            UserNameTextBox.SendKeys(userName);
            PassWORDTextBox.SendKeys(Password);
            LoginButton.Click();
            return new PomWelcomToTCO(_driver);
        }
        #endregion
    }
}
