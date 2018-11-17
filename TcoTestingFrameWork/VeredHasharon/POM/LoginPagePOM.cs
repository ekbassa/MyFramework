using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class LoginPagePOM
    {
        private IWebDriver Driver;

        public LoginPagePOM(IWebDriver driver)
        {
            Driver = driver;
            WelcomToTco = new WelcomToTcoPage(Driver);
        }

        #region Iwebelement
        public IWebElement CompanyCombo => Driver.FindElement(By.Id("cmbCompanies"));
        public IWebElement UserNameTxtBox => Driver.FindElement(By.Id("txtUserName"));
        public IWebElement PasswordTxtBox => Driver.FindElement(By.Id("txtPassword"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("btnLogIn"));

        public WelcomToTcoPage WelcomToTco { get; private set; }
        #endregion
        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://10.168.241.59/TcoWebSiteDemo/TCOWebSite/LogIn.aspx");
        }
        #region Actions
        public WelcomToTcoPage ClickLogin(string userName, string userPassword)
        {
            UserNameTxtBox.SendKeys(userName);
            PasswordTxtBox.SendKeys(userPassword);
            LoginButton.Click();
            return new WelcomToTcoPage(Driver);
        }

        #endregion
    }
}
