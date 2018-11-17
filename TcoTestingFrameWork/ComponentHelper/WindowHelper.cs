using TcoTestingFrameWork.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace TcoTestingFrameWork.ComponenetHelper
{
    public class WindowHelper
    {
        /* this class includes all the related browser functions */

        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        public static string GetPageUrl()
        {
            return ObjectRepository.Driver.Url;
        }

       public static void  ExtractWebElementPageID(By locator)
        {
            /*
             * should find a way to send the readonlycollection out of the function 
             * to display on the scree from the main calling method
             * 
             */
            ReadOnlyCollection < IWebElement > ElementList = ObjectRepository.Driver.FindElements(locator);
            foreach (var element in ElementList)
            {
                Console.WriteLine("ID     :{0}", element.GetAttribute("id"));
            }
        }
    }
}
