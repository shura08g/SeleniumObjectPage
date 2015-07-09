using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumObjectPage
{
    class ExcelLib
    {
        private static DataTable ExcelToDataTable(string fileName)
        {
            // open file and return as stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            // Createopenxmlreader via ExelReaderFactory
            /// <summary>
            /// ExcelDataReader install in NuGet
            /// </summary>
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); // .xlsx
            // Set the firsl Row as Column Name
            excelReader.IsFirstRowAsColumnNames = true;
            // Return as DataSet
            DataSet result = excelReader.AsDataSet();
            // Get all the Tables
            DataTableCollection table = result.Tables;
            // Store it in DataTable
            DataTable resultTable = table["Лист1"];

            return resultTable;

        }

        static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            // Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 1; col <= table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col-1].ColumnName,
                        ColValue = table.Rows[row - 1][col-1].ToString()
                    };
                    // Add all the details for each row
                    dataCol.Add(dtTable);
                }

            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                // Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.ColName == columnName && colData.RowNumber == rowNumber
                               select colData.ColValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.ColName == columnName && x.RowNumber == rowNumber).SingleOrDefault().ColValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

    public class Datacollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
