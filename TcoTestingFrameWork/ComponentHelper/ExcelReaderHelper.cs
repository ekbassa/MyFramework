using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace UnitTestProject1.ExcelReader
{
    public class ExcelReaderHelper
    {
        /*Creating the dictionary object
         *  private static IDictionary<string, IExcelDataReader> _cashe;
         *  the string represents the sheet name 
         */

        private static IDictionary<string, IExcelDataReader> _cashe;
        static FileStream stream;
        static IExcelDataReader reader;

        // static ctor to initialize the _cashe
        static ExcelReaderHelper()
        {
            _cashe = new Dictionary<string, IExcelDataReader>();
        }

        static public object GetCelldata(string excelPath, string sheetName, int row, int col)
        {
            /*check if the key "sheet name is exist in the _cashe 
               if it is true it will use it from the _cashe because it is much faster
               else the system will create a new Iexcelreader object 
               */
            if (_cashe.ContainsKey(sheetName))
            {
                //retrive the object reader from the key "sheet name " 
                reader = _cashe[sheetName];
            }
            else
            {
                // the Iexcelreader object is not exist in the _cashe ,so create it 
                stream = new FileStream(excelPath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                //add the reader object into the _cashe
                _cashe.Add(sheetName, reader);
            }
            DataTable table = reader.AsDataSet().Tables[sheetName];
            return Getdata(table.Rows[row][col].GetType(), table.Rows[row][col]);
        }

        private static object Getdata(Type type, object data)
        {
            switch (type.Name)
            {
                case "string": return data.ToString();
                case "Double": return Convert.ToDouble(data);
                case "DateTime": return Convert.ToDateTime(data);
                default:
                    return data.ToString();
            }
        }
    }
}
