using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.IO;
using System;
using TcoTestingFrameWork.ComponenetHelper;
using TcoTestingFrameWork.TestScripts.Isropa;
using UnitTestProject1.ExcelReader;

namespace TcoTestingFrameWork.ExcelDataReader
{
    [TestClass]
    public  class ExcelDataReaderTest
    {
        [TestMethod]
        [TestCategory("LogIn Category")]
        public void ReadDataFromExcelFile()
        {
            string FilePath = @"E:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";
            FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataTable table = reader.AsDataSet().Tables["Login"];
            //we are going to use the table object to read the data

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var col = table.Rows[i];
                for (int j = 0; j < col.ItemArray.Length; j++)
                {
                    Console.Write(col.ItemArray[j] + "    ");
                }
                Console.WriteLine();
            }


            //string excelPath = @"C:\Users\Bassam\Documents\Training\DataDriven\ExcelTestData\TcoData.xlsx";
            //Console.WriteLine( ExcelReaderHelper.GetCelldata(excelPath, "Login", 0, 0));
        }
    }
}
