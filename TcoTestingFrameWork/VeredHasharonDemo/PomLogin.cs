using OpenQA.Selenium;
using TcoTestingFrameWork.VeredHasharon.POM;

namespace TcoTestingFrameWork.VeredHasharonDemo
{
    class PomLogin
    {
        private IWebDriver _driver;
        public PomLogin(IWebDriver driver)
        {
            _driver = driver;
        }
        //IwebElements
        public IWebElement txt_userName => _driver.FindElement(By.Id("txtUserName"));
        public IWebElement txt_userpassword => _driver.FindElement(By.Id("txtPassword"));
        public IWebElement btn_Login => _driver.FindElement(By.Id("btnLogIn"));


        //Action 
        public void Login(string userName,string passWord)
        {
            txt_userName.SendKeys(userName);
            txt_userpassword.SendKeys(passWord);
            btn_Login.Click();
        }
    }
}
