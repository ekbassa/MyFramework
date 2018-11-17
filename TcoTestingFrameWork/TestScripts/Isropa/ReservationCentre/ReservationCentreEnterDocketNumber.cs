using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Isropa.ReservationCentre
{
    [TestClass]
    public  class ReservationCentreEnterDocketNumber
    {
        [TestMethod]
        public void EnterDocketNumber()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            Assert.AreEqual("TCO Log In", WindowHelper.GetTitle());

            TextBoxHelper.SendKeys(By.Id("txtUserName"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.SendKeys(By.Id("txtPassword"), ObjectRepository.Config.GetUserPassword());
            ButtonHelper.ClickButton(By.Id("btnLogIn"));


            // check if we are in the main menu Welcom to TCO 
            var ReservationCenterIcon = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblMainMenuNL']/descendant::td[position()=3]"));
            Assert.AreEqual("Welcome To TCO", WindowHelper.GetTitle());
            ReservationCenterIcon.Click();

            /* switch to the desired Tab " flight,hotel and services " 
             * 
             * 
             * Xpath :Flight --> //div[@id='ctl00_ContentPlaceHolder1_RadTabStrip1']/descendant::li[1]
             * Xpath :Hotel --> //div[@id='ctl00_ContentPlaceHolder1_RadTabStrip1']/descendant::li[3]
             * Xpath :Services --> //div[@id='ctl00_ContentPlaceHolder1_RadTabStrip1']/descendant::li[4]
             * */

            // wsitch to the hotel tab
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//div[@id='ctl00_ContentPlaceHolder1_RadTabStrip1']/descendant::li[3]")).Click();


            // wait and locate the "Docket No" textbox
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_txtHotelDocketNo")).SendKeys("170377");

            //click the "Show Reservation " Button
            ButtonHelper.ClickButton(By.Id("ctl00_ContentPlaceHolder1_btnShowHotelResv_input"));

            //select the first row and 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_grdHotels_ctl00__0")).Click();

            // select the report type from the " Reports " combobox by clicking the combobox arrow
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("ctl00_ContentPlaceHolder1_cmbHotelReports_Arrow")).Click();

            DropDownListHelper.SelectElementByText(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_cmbHotelReports_Input']"),"Hotel Confirmation");
            Thread.Sleep(5000);
            
        }
    }
}
