using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public partial class WebTables
    {
        public string FirstNameData;
        public string LastNameData;
        public string EmailData;
        public string AgeData;
        public string SalaryData;
        public string DepartmentData;
        private void ReadDataFromExcel(int rownumber)
        {
            FirstNameData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(FirstNameData), rownumber);
            LastNameData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(LastNameData), rownumber);
            EmailData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(EmailData), rownumber);
            AgeData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(AgeData), rownumber);
            SalaryData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(SalaryData), rownumber);
            DepartmentData = Excel.FindHeaderCoulmnData("data.xlsx", "WebTablesAdd", nameof(DepartmentData), rownumber);
        }
    }
}
