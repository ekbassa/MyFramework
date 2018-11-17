using OpenQA.Selenium;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QutationMainDetails
    {
        private IWebDriver Driver ;

        public QutationMainDetails(IWebDriver driver)
        {
            Driver = driver;
        }
        #region QuotationMainDetailsIwebElements
        public IWebElement QuotationSheetId => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_lblSheetNo"));
        public IWebElement Txt_DocketType => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbCatagory_Input"));
        public IWebElement Txt_GroupName => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TxtGroupName"));
        public IWebElement DatePicker_FromDate => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_rdFromDate_dateInput"));
        public IWebElement DatePicker_ToDate => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_rdToDate_dateInput"));
        public IWebElement Combo_Country => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbCountry_Input"));
        public IWebElement Combo_Agent => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbCustomer_Input"));
        public IWebElement Combo_AgentArrow => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbCustomer_Arrow"));
        public IWebElement Combo_Language => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbLanguage_Input"));
        public IWebElement Combo_HotelStandardArrow => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbHStd_Arrow"));
        public IWebElement Combo_HotelStandard => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cmbHStd_Input"));
        public IWebElement Txt_AdultNumber => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtAdlts"));
        public IWebElement Txt_ChildrenNumber => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtChldrn"));
        public IWebElement AllAgentChkBox => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkAllCustomer"));
        public IWebElement AllLanguagesChkBox => Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_chkAllLanguage"));
        #endregion

        #region Actions
        public string GetQuotationId()
        {
            return QuotationSheetId.Text;
        }
        public string GetDocketType()
        {
            return Txt_DocketType.GetAttribute("value");
        }
        public string GetGroupName()
        {
            return Txt_GroupName.GetAttribute("value");
        }
        public string GetAdultNumber()
        {
            return Txt_AdultNumber.GetAttribute("value");
        }

        public string GetQuotationInfo()
        {
            return "this is the details about this quotation \n" +
                "Quotation Type\t :  " + GetDocketType() +
                "\n Quotation Id:\t" + GetQuotationId() +
                "\n Group Name :\t" + GetGroupName() +
                "\n Adults No Is :\t" + GetAdultNumber();

        }
        #endregion

    }
}