using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using OpenQA.Selenium;
using System.Threading;
using TcoTestingFrameWork.ComponentHelper;
using TcoTestingFrameWork.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TcoTestingFrameWork.TestScripts.Isropa.ClerkMenu
{
    [TestClass]
    public  class SelectTheFirstDocketFromTheGrid
    {
        [TestMethod]
        public void SelectFirstDocket()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();

            var element = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/descendant::tr[2]"));
            MouseActionsHelper.DoubleClick(element);
            Thread.Sleep(3000);
           
            //select all the docket services 
            var ServicesList = ObjectRepository.Driver.FindElements(By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']"));
                                                                                         
            foreach (var item in ServicesList)
            {
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void OpenFirstDocketFromGrid()
        {
            IsropaLogin.Login();
            SelectClerkMenuFromMainPage.SelectClerkMenu();        

            //Double click the docket to open it
            var element = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/descendant::tr[2]"));
            MouseActionsHelper.DoubleClick(element);
            BrowserHelper.SwitchToWindow(1);

            //locate the service table and pull all the services
            var  ServicesList = ObjectRepository.Driver.FindElements(By.Id("ctl00_ContentPlaceHolder1_productGridView"));

            foreach (var item in ServicesList)
            {
                Console.WriteLine(item.Text);
            }          

            //locate the first service and perform a right click on it
            var Service = GenericHelper.WaitForElementAndGetIt(ObjectRepository.Driver, By.XPath("//table[@id='ctl00_ContentPlaceHolder1_productGridView']/descendant::tr[2]"));
            MouseActionsHelper.RightClick(Service);
            Thread.Sleep(3000);
        }
    
    }
}
