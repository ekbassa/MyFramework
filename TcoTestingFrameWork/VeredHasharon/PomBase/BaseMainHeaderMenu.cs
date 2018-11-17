using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TcoTestingFrameWork.VeredHasharon.PomBase
{
    public abstract class BaseMainHeaderMenu
    {
        public IWebDriver Driver { get; set; }

        #region IwebElements
        //[FindsBy(How = How.Id, Using = "CleckControll1_lblClerkName")]
        //private IWebElement UserLoggedInAs;

        [FindsBy(How = How.XPath, Using = "//div[@class='LOGO']")]
        private IWebElement HomePageIcon;


        public IWebElement UserLoggedInAs => Driver.FindElement(By.Id("ctl00_CleckControll1_lblClerkName"));
        public IWebElement LogOutLink => Driver.FindElement(By.Id("ctl00_CleckControll1_btnLogOut"));



        [FindsBy(How = How.XPath, Using = "//div[@id='TopPageRadMenu']/descendant::li[1]")]
        private IWebElement CodesTab;

        [FindsBy(How = How.XPath, Using = "//div[@id='TopPageRadMenu']/descendant::li[11]")]
        private IWebElement HelpTab;

        [FindsBy(How = How.Id, Using = "Def")]
        private IWebElement RedColor;

        [FindsBy(How = How.Id,Using = "Blue")]
        private IWebElement BlueColor;

        [FindsBy(How = How.Id, Using = "Gold")]
        private IWebElement GoldColor;

        [FindsBy(How = How.Id, Using = "Green")]
        private IWebElement GreenColor;
        #endregion
        #region Ctors
        public BaseMainHeaderMenu(IWebDriver driver)
        {
            Driver = driver;
        }
        #endregion
        #region Actions
        public void GoToHomePage()
        {
            HomePageIcon.Click();
        }
        public void LogOut()
        {
            LogOutLink.Click();
        }
        public void ChangeUserColorToRed()
        {
            RedColor.Click();
        }
        public string LoggedAs()
        {
            return UserLoggedInAs.Text;
        }
      
       
    
        #endregion

    }
}
