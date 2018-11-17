using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.ComponentHelper
{
   public class JavaScriptPopUpHelper
    {
        public static bool IsAlertExist()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {

                return false;
            }
        }

        public static string GetpoUpText()
        {
            if (IsAlertExist())
           
                return  ObjectRepository.Driver.SwitchTo().Alert().Text;
            return string.Empty;
        }

        public static void ClickOkOnPopUp()
        {
            if (IsAlertExist())
               ObjectRepository.Driver.SwitchTo().Alert().Accept();
            
        }

        public static void ClickCancelOnPopUp()
        {
            if (IsAlertExist())
                ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
        }

        public static void SendKeys(string text)
        {
            if (IsAlertExist())
                ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
