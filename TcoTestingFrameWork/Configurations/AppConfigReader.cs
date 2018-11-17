using TcoTestingFrameWork.Interfaces;
using TcoTestingFrameWork.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcoTestingFrameWork.Configuration
{
    class AppConfigReader : Iconfig
    {
        /* this class is going to read the data from the App.config  file
         * by using the ConfigurationManager class and using the 
         * public virtual string Get(string name);
        */
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);

            //  cast the return type into Browser type
           return (BrowserType) Enum.Parse(typeof(BrowserType), browser);   
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }

        public string GetUserPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserPassword);
        }
        public string GetWebSite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite);
        }
     

        public string GetNazareneUser()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.NazareneUser);
        }
        public string GetNazarenPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.NazarenePassWord);
        }
        public string GetVeredUser()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.VeredUser);
        }
        public string GetVeredPassword()
        {
            return  ConfigurationManager.AppSettings.Get(AppConfigKeys.VeredPassword);
        }

        public int  GetPageLoadTimeOut()
        {
          string PagetimeOut=  ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if (PagetimeOut == null)
            {
                return 30;
            }
            return Convert.ToInt32(PagetimeOut);
        }

        public int GetElementTimeOut()
        {
            string elementTimeOut = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementWait);
            if (elementTimeOut==null)
            {
                return 5;
            }
            return Convert.ToInt32(elementTimeOut);
        }

        public string GetLocalWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.LocalWebSite);
        }

    }

}




