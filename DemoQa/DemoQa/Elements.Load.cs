using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DemoQa;


namespace DemoQa
{
    public partial class Elements
    {
        public string fullnameData;
        public string emailData;
        public string currentaddressData;
        public string PermanentaddressData;
       
        private void ReadDataFromExcel(int rownumber)
        {
            fullnameData = Excel.FindHeaderCoulmnData("data.xlsx", "fields", nameof(fullnameData), rownumber);
            emailData = Excel.FindHeaderCoulmnData("data.xlsx", "fields", nameof(emailData), rownumber);
            currentaddressData = Excel.FindHeaderCoulmnData("data.xlsx", "fields", nameof(currentaddressData), rownumber);
            PermanentaddressData = Excel.FindHeaderCoulmnData("data.xlsx", "fields", nameof(PermanentaddressData), rownumber);
        }
    }
}
