using TcoTestingFrameWork.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcoTestingFrameWork.Interfaces
{
    public interface Iconfig
    {
        //we are going to write some common methods for the framwork
        BrowserType GetBrowser(); // reading the browser type from the App.config
        string GetUserName();     // the User Name to login to the  application Isropa website
        string GetUserPassword(); //  the User Password to login to the  application ISropa website
        string GetWebSite();
        string GetLocalWebsite();
        string GetNazarenPassword();
        string GetNazareneUser();
        string GetVeredUser();
        string GetVeredPassword();
        int GetPageLoadTimeOut();
        int GetElementTimeOut();

        
    }
}
