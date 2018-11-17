using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;
using UnitTestProject1.ExcelReader;


namespace TcoTestingFrameWork.DataDriven.DDScripts
{
    [TestClass]
    public  class LoginFromExcelFile
    {
        private TestContext _Testcontext;

        public TestContext TestContext
        {
            get { return _Testcontext; }
            set { _Testcontext = value; }
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx;", "Login$", DataAccessMethod.Sequential)]

        public void LoginWithExcel()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "New Isropa");
            PomLogin TcoLogin = new PomLogin(ObjectRepository.Driver);
            TcoLogin.Login(TestContext.DataRow["UserName"].ToString(), TestContext.DataRow["PassWord"].ToString());
            var LogOut = ObjectRepository.Driver.FindElement(By.Id("CleckControll1_btnLogOut"));

            Console.WriteLine("Test {0} . result :{1}", TestContext.TestName, TestContext.CurrentTestOutcome);
            LogOut.Click();
        }

        [TestMethod]
       
        public void LoginWithExcelReader()
        {
            string FilePath = @"E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";         
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            DropDownListHelper.SelectElementByText(By.Id("cmbCompanies"), "Vered Hasharon");
            PomLogin TcoLogin = new PomLogin(ObjectRepository.Driver);            
            TcoLogin.Login(ExcelReaderHelper.GetCelldata(FilePath, "Login", 1, 0).ToString(), ExcelReaderHelper.GetCelldata(FilePath, "Login", 1, 1).ToString());
            var LogOut = ObjectRepository.Driver.FindElement(By.Id("CleckControll1_btnLogOut"));
            Thread.Sleep(2000);
            LogOut.Click();
            
        }    
    }
}
