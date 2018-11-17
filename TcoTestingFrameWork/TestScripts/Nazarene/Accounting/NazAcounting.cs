using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Nazarene.Accounting
{
    [TestClass]
    public  class NazAcounting
    {
        [TestMethod]
        public void SelectAccountingIcon()
        {
            NazLogin.LogInNazaren();
            ObjectRepository.Driver.FindElement(By.XPath("//table[@id='tblMainMenu']/descendant::td[7]")).Click();
           
        }
        [TestMethod]
        public void SelectSuppliersPayment()
        {
            SelectAccountingIcon();

            /* Click the Suppliers Payment Tab */
            ObjectRepository.Driver.FindElement(By.XPath("//div[@id='ctl00_cntAccountingMenu_TopPageRadAccountingMenu']/descendant::span[text()='Suppliers Payments']")).Click();
            Thread.Sleep(3000);
        }

        
        [TestMethod]
        public void SelectBranch()
        {
            SelectSuppliersPayment();
             DropDownListHelper.SelectElementByText(By.Id("ctl00_ContentPlaceHolder1_cmbBranch_Input"),"SHEFARAAM");
            Thread.Sleep(3000);
        }
       
    }
}
