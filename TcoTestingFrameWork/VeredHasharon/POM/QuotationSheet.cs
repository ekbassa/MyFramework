using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.BaseClasses;

namespace TcoTestingFrameWork.VeredHasharon.POM
{
    public class QuotationSheet : PomPageBase
    {

        public new IWebDriver Driver { get; set; }

        #region IwebElements
        public TopMenu TopMenu { get; private set; }
        public Services Services { get; private set; }
        public QuotationSheetTabs QuotationSheetTabs { get; private set; }
        public QutationMainDetails QutationMainDetails { get; private set; }
        public QuotationExtraDetails QuotationExtraDetails { get; private set; }
        public QuotationCheckboxes QuotationCheckboxes { get; private set; }
        public QuotationActionButton QuotationActionButton { get; private set; }
        public QuotationServices QuotationServices { get; private set; }
        #endregion

        #region Ctor
        public QuotationSheet(IWebDriver driver) : base(driver)
        {
            Driver = driver;
            TopMenu = new TopMenu(driver);
            Services = new Services(driver);
            QuotationSheetTabs = new QuotationSheetTabs(driver);
            QutationMainDetails = new QutationMainDetails(driver);
            QuotationExtraDetails = new QuotationExtraDetails(driver);
            QuotationCheckboxes = new QuotationCheckboxes(driver);
            QuotationActionButton = new QuotationActionButton(driver);
            QuotationServices = new QuotationServices(driver);
        }
        #endregion

    }
}
