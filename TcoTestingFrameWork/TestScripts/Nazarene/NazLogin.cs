using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using OpenQA.Selenium;
using System;
using System.Threading;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.Nazarene
{
    [TestClass]
    public static  class NazLogin
    {
        [TestMethod]
        public static  void LogInNazaren()
        {
            NavigationHelper.NavigateToUrl("http://10.168.241.59/tcowebsitedemo"); 
            TextBoxHelper.SendKeys(By.Id("txtUserName"), ObjectRepository.Config.GetNazareneUser());
            TextBoxHelper.SendKeys(By.Id("txtPassword"), ObjectRepository.Config.GetNazarenPassword());
            Console.WriteLine("Is the Button Log In is Enabled :{0}", ButtonHelper.IsButtonEnabled(By.Id("btnLogIn")));

            Console.WriteLine("the web page title is :{0}", WindowHelper.GetTitle());
            Console.WriteLine("the button text is :{0}", ButtonHelper.GetButtonText(By.Id("btnLogIn")));
            ButtonHelper.ClickButton(By.Id("btnLogIn"));
            Thread.Sleep(3000);
        }
    }
}
