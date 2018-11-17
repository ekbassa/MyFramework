using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QuotationActionButton
    {
        private IWebDriver Driver;

        public QuotationActionButton(IWebDriver driver)
        {
            Driver = driver;
        }
        #region Button IwebElements
        public IWebElement Btn_AddNewQuote => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnAdd"));
        public IWebElement Btn_Updatequote => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnUpdate"));
        public IWebElement Btn_MakeGroupFile => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnMakeAGroup"));
        public IWebElement Btn_OpenGroupFile => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnOpenGRPFile"));
        public IWebElement Btn_AssignToGroup => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnAssignToGroup"));
        public IWebElement Txt_AssignToGroup => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_RadtxtAssigToGrp"));
        #endregion
    }
}