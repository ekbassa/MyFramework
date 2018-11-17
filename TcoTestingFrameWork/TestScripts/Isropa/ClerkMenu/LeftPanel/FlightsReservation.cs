using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using System;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu.LeftPanel
{
    [TestClass]
    public class FlightsReservation
    {
        [TestMethod,TestCategory("Smoke")]
        public void CharterFlightReservation()        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();


         

            //wait until the left menu dispalyed and click TCO Packages
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_cntClerkMenu1_pnlLeftMenu']//span[text()='TCO Package ']")).Click();

            //wait until the Components is displayed
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/h3")).Click();

            //wait until the flight option displayed then click it
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//ul[@id='nested']/li[2]/descendant::div[3]")).Click();

            Thread.Sleep(3000);


            //Switch to iframe

            BrowserHelper.SwitchToFrame(1);
            Thread.Sleep(1000);

            //click the flight comboBox
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='tblFPCalculation']//tr[1]//select[@id='ddlFlight']")).Click();

            //select a value from the combo box
            DropDownListHelper.SelectElementByIndex(By.XPath("//table[@id='tblFPCalculation']//tr[1]//select[@id='ddlFlight']"), 1);



            //get the Paxes number from the textboxes "Adults" ,"Children" and "infant "
            var AdultsNoOriginalValue = ObjectRepository.Driver.FindElement(By.Id("txtADLTs")).GetAttribute("value");

            //var AdutsNewValue = GenericHelper.ConvertStringIntoInt(AdultsNoOriginalValue);
            //AdutsNewValue++;

            ////convert the new value into string 
            //string newValue = AdutsNewValue.ToString();
            //ObjectRepository.Driver.FindElement(By.Id("txtADLTs")).Clear();
            //ObjectRepository.Driver.FindElement(By.Id("txtADLTs")).SendKeys(newValue);
            //Console.WriteLine("Adults No is :{0}",AdultsNoOriginalValue);
            



            //click the "Calc" Button
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("btnCalcPrice")).Click();

            //Wait until the " Reserve " button will be displayed then Click it 
            GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.Id("btnRsrv")).Click();

            // the New Pax File Page -- is not a new Iframe it is the same frame 
        

            //try to test any element in the new frame 
            Console.WriteLine(ObjectRepository.Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_lblPageTitle")).Text);

            //enter the first name 
            ObjectRepository.Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Room1_AdultGuest1_txtFirstName")).SendKeys("Test1");
            ObjectRepository.Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Room1_AdultGuest1_txtLastName")).SendKeys("FamilyTest1");
            ObjectRepository.Driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Room1_AdultGuest1_CLChildDOB_Image1")).Click();

           Thread.Sleep(10000);
        }
    }
}
