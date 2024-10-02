using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public class Excel
    {
        public static void ReadDataFromExcel()
        {
            {

                Dictionary<string, string> ReadDataFromExcel(string filePath, string sheetName = "Sheet1")
                {
                    var data = new Dictionary<string, string>();

                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(sheetName);
                        foreach (var row in worksheet.RangeUsed().Rows())
                        {
                            var key = row.Cell(1).GetValue<string>();
                            var value = row.Cell(2).GetValue<string>();
                            data[key] = value;
                        }
                    }

                    return data;
                }
            }
        }
        public void WriteDataToExcel(string filePath, Dictionary<string, string> data, string sheetName = "Sheet1")
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName);

                int row = 1;
                foreach (var kvp in data)
                {
                    worksheet.Cell(row, 1).Value = kvp.Key;
                    worksheet.Cell(row, 2).Value = kvp.Value;
                    row++;
                }
                workbook.SaveAs(filePath);
            }
        }

        public static int FindHeaderCoulmnNumber(string filePath, string sheetName, string Serachdata, int row = 1)
        {

            IXLWorkbook workbook = new XLWorkbook(filePath);
            IXLWorksheet worksheet = workbook.Worksheet(sheetName);
            IXLRow HeaderRow = worksheet.Row(row);

            IXLCells ColumnNo = HeaderRow.Search(Serachdata.Trim());

            int column = ColumnNo.ElementAt(0).Address.ColumnNumber;
            return column;

        }
        public static string FindHeaderCoulmnData(string filePath, string sheetName, string Serachdata, int row)
        {
            IXLWorkbook workbook = new XLWorkbook(filePath);
            IXLWorksheet worksheet = workbook.Worksheet(sheetName);
            int colum = FindHeaderCoulmnNumber(filePath, sheetName, Serachdata);
            string data = worksheet.Cell(row, colum).GetString();
            return data;
        }

    }
}

