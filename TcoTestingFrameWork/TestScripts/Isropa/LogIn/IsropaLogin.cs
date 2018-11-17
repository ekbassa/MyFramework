using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.Settings;
using OpenQA.Selenium;

namespace TcoTestingFrameWork.TestScripts.Isropa
{
    [TestClass]
    public  class IsropaLogin
    {
       
        [TestMethod]
        public static  void Login()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            TextBoxHelper.SendKeys(By.Id("txtUserName"),ObjectRepository.Config.GetUserName());
            TextBoxHelper.SendKeys(By.Id("txtPassword"), ObjectRepository.Config.GetUserPassword());
            //Console.WriteLine("Is the Button Log In is Enabled :{0}", ButtonHelper.IsButtonEnabled(By.Id("btnLogIn")));

            //Console.WriteLine("the web page title is :{0}", WindowHelper.GetTitle());
            //Console.WriteLine("the button text is :{0}", ButtonHelper.GetButtonText(By.Id("btnLogIn")));
            ButtonHelper.ClickButton(By.Id("btnLogIn"));
        }

        [TestMethod]
        public static void Temp()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            System.Console.WriteLine("Done");
        }
        

    }
}
