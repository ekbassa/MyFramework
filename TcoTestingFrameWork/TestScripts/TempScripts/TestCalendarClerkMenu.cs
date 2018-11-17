using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.PageObjectModel;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.TestScripts.TempScripts
{
    [TestClass]
    public  class TestCalendarClerkMenu
    {
        [TestMethod]
        public void Calendar()
        {
                       
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            PomLogin TcoLogIn = new PomLogin(ObjectRepository.Driver);            
            PomWelcomToTCO TcoWelcomPage = TcoLogIn.Login(ObjectRepository.Config.GetUserName(), ObjectRepository.Config.GetUserPassword());
            PomDocketList Clerk = TcoWelcomPage.ClickClerkMenu();
            Clerk.ClickShowButton();
          
            Thread.Sleep(3000);

            
        }
    }
}
