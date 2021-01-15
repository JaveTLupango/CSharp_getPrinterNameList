using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace WindowsFormsApp1.library
{
    class getPrinterList_class
    {
        /// <summary>
        /// get printer List only Printer Name
        /// </summary>
        /// <returns></returns>
        public static DataTable getprinterlist()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PrinterName");
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                dt.Rows.Add(printer.ToString());
                // comboBox2.Items.Add(printer.ToString());
            }
            return dt; //JsonConvert.SerializeObject(dt);
        }

        /// <summary>
        /// Get printer List all
        /// </summary>
        /// <returns></returns>
        public static string getprinterlistV2()
        {            
            return JsonConvert.SerializeObject(PrinterSettings.InstalledPrinters);
        }
    }
}
