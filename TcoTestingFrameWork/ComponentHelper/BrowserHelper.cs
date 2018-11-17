
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using TcoTestingFrameWork.Settings;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public  class BrowserHelper
    {
        public static void  MaximizeWindow()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static string GettheParentPage()
        {
           return ObjectRepository.Driver.CurrentWindowHandle;
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();           
        }
        public static void SwitchToWindow(int index=0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if(index > windows.Count)
            {
                throw new NoSuchWindowException(" Invalid Browser Window Index" + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            //MaximizeWindow();        
        }

        public static int GetTotalOfOpenedWindows()
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            return windows.Count;
        }
     
        public static void SwitchToParentWindow()
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            for(int i = windows.Count; i > 1; i--)
            {               
               // ObjectRepository.Driver.SwitchTo().Window(windows[i]);
                ObjectRepository.Driver.Close();
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[0]);
        }

        public static void SwitchToFrame(IWebElement  element)
        {
            ObjectRepository.Driver.SwitchTo().Frame(element);
        }
        public static void SwitchToFrame(string  frameName)
        {
            ObjectRepository.Driver.SwitchTo().Frame(frameName);
        }
        public static void SwitchToFrame(int index)
        {
            ObjectRepository.Driver.SwitchTo().Frame(index);
        }
        public static void LeaveFram()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();
        }


    }
}
