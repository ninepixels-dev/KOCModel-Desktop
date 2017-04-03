using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace KOCModel
{
    public partial class PublicGasLines : UserControl {
        public PublicGasLines() {
            InitializeComponent();
        }

        private void runModel(object sender, EventArgs e) {
            TextBox[] array = { data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11 };

            notificationPanel.Show();

            Excel.Application excelApp = null;
            Excel.Workbooks books = null;
            Excel.Workbook inputFile = null;
            Excel.Workbook templateFile = null;
            Excel.Worksheet inputSheets = null;
            Excel.Worksheet fireBallSheet = null;
            Excel.Worksheet templateSheet = null;
            Excel.Worksheet gasLineResults = null;
            Excel.Range dataRange = null;
            Excel.Range fireBallRange = null;
            object value = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                books = excelApp.Workbooks;

                inputFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\gaslines_model_public.xlsx"));
                inputSheets = (Excel.Worksheet)inputFile.Sheets["Gas pipeline input sheet"];
                fireBallSheet = (Excel.Worksheet)inputFile.Sheets["Fire Ball"];

                dataRange = inputSheets.Range["B1", "B11"];
                int i = 0;
                foreach (Excel.Range cell in dataRange)
                {
                    cell.Value = array[i].Text;
                    i++;

                    Marshal.FinalReleaseComObject(cell);
                }

                fireBallRange = fireBallSheet.Range["E4", "E104"];
                foreach (Excel.Range fireCell in fireBallRange)
                {
                    value = fireCell.Value;
                    InitPage.GasLineValues.publicGasLine.Add(value.ToString());

                    Marshal.FinalReleaseComObject(fireCell);
                }

                templateFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Templates\Gas Line Results Public.xlsx"));
                templateSheet = (Excel.Worksheet)templateFile.Sheets["Gas_Lines_Data"];

                inputSheets.Range["B1", "B11"].Copy(templateSheet.Range["B1", "B11"]);
                inputSheets.Range["A1", "C17"].Copy(templateSheet.Range["A1", "C17"]);
                inputSheets.Range["A23", "F25"].Copy(templateSheet.Range["A23", "F25"]);

                gasLineResults = templateFile.Sheets.Add();
                gasLineResults.Name = "Gas_Lines_Transect";

                inputSheets.ChartObjects("Chart 1").Chart.CopyPicture();
                gasLineResults.Paste();

                templateFile.SaveAs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), data1.Text));
            }
            finally
            {
                // Clean up sheets
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(gasLineResults);
                Marshal.FinalReleaseComObject(templateSheet);
                Marshal.FinalReleaseComObject(fireBallSheet);
                Marshal.FinalReleaseComObject(inputSheets);
                Marshal.FinalReleaseComObject(books);

                Marshal.FinalReleaseComObject(dataRange);
                Marshal.FinalReleaseComObject(fireBallRange);

                gasLineResults = null;
                templateSheet = null;
                fireBallSheet = null;
                inputSheets = null;
                books = null;

                dataRange = null;
                fireBallRange = null;
                value = null;

                inputFile.Close(false);
                templateFile.Close(false);

                Marshal.FinalReleaseComObject(inputFile);
                Marshal.FinalReleaseComObject(templateFile);
                inputFile = null;
                templateFile = null;

                excelApp.Application.Quit();
                Marshal.FinalReleaseComObject(excelApp);
                excelApp = null;

                notificationPanel.Controls.Find("lblGenerating", true)[0].Hide();
                notificationPanel.Controls.Find("lblSuccess", true)[0].Show();
                notificationPanel.Controls.Find("btnClose", true)[0].Show();
            };
        }

        private void closeNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
            notificationPanel.Controls.Find("lblGenerating", true)[0].Show();
            notificationPanel.Controls.Find("lblSuccess", true)[0].Hide();
            notificationPanel.Controls.Find("btnClose", true)[0].Hide();
        }
    }
}
