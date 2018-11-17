using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.BaseClasses;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.VeredHasharon.PomBase;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QuotationsList: BaseMainHeaderMenu
    {

        #region IwebElement
        public string PageTitle => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Label27")).Text;
        public IWebElement AllCheckBox => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkAll"));
        public IWebElement OldCheckBox => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkOLD"));
        public IWebElement StatusComboBox => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbStatus_Input"));
        public IWebElement PleasShowButton => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnPleaseShow"));
        public IWebElement newSheetButton => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnNewSheet"));
        public IWebElement quotationListGrid => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_RadGrid1_GridData"));
        public IWebElement sheetsNavBar => Driver.FindElement(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_mnuTop']//td[@id='ctl00_ContentPlaceHolder1_mnuTopn0']"));
        public IWebElement filesNavBar => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_mnuTopn1"));

        #region SheetsNavBarItems  
        public IWebElement openCalcSheetByNumber => Driver.FindElement(By.XPath("//a[contains(text(),'Open Calc.sheet/Group by number')]"));
        public IWebElement NewCalcSheet => Driver.FindElement(By.XPath("//a[contains(text(),'New Calc.sheet')]"));



        #endregion


        #endregion
        public QuotationsList(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        #region Actions
        public void ticTcheckBoxAll()
        {
            AllCheckBox.Click();
        }
        public void clickShowButton()
        {
            PleasShowButton.Click();
        }
   
        public void ClickFilesTab()
        {
            filesNavBar.Click();
        }
        public void clickSheetsTabs()
        {
            sheetsNavBar.Click();
        }
        public void SelectCalckSheetByNumnber()
        {
            openCalcSheetByNumber.Click();
        }
       
        #endregion

    }
}
    

