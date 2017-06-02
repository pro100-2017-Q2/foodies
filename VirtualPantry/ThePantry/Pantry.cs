using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VirtualPantry.ThePantry;
using excel = Microsoft.Office.Interop.Excel;

namespace VirtualPantry.ThePantry
{
	public class Pantry : DataTable
	{
		public static void WriteToExcelFile()
		public static void WriteToExcelFile(object sender, EventArgs e)
		{
            
		}
            //REALLY DIRTY CODE THAT MAY OR MAY NOT WORK. FEEL FREE TO CHANGE

            // Create the CSV file to which grid data will be exported.
            string strPath = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);
            StreamWriter sw = new StreamWriter(strPath, false);
            // First we will write the headers.
            DataTable dt = new DataTable();

            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            // Now write all the rows.
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
		public static void ReadFromExcelFile()
		{

		}
	}
}

