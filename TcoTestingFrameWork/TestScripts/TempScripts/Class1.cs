using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TcoTestingFrameWork.BaseClasses;
using TcoTestingFrameWork.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ExcelReader;

namespace TcoTestingFrameWork.TestScripts.TempScripts
{
    [TestClass]
    public class Class1 
    {
     [TestMethod]
       
        public void foo()
        {
            string XlsPath = @"C:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";

            //int pax = 45;
            //Console.WriteLine(" pay :{0}", CalculateCalimityFund(pax));

            var res = ExcelReaderHelper.GetCelldata(XlsPath, "DocketsNumber", 0, 0).ToString();
            Console.WriteLine("res is {0}",res);

        }
        //this recursive function calculates the calimity fund according the pax number 
        public double  CalculateCalimityFund(int PaxNum)
        {
            if (PaxNum  <= 9)
                return 2.5;
            return 2.5 + CalculateCalimityFund(PaxNum - 9);
        }
        
        }
        
    }
   

