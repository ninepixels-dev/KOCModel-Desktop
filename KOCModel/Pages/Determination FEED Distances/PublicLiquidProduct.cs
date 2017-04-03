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
    public partial class PublicLiquidProduct : UserControl {
        public PublicLiquidProduct() {
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
            Excel.Worksheet templateSheet = null;
            Excel.Worksheet liquidLinesTransect = null;
            Excel.Range dataRange = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                books = excelApp.Workbooks;

                inputFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\liquid_product_pipelines_public.xlsx"));
                inputSheets = (Excel.Worksheet)inputFile.Sheets["Input Sheet"];

                dataRange = inputSheets.Range["B1", "B11"];
                int i = 0;
                foreach (Excel.Range cell in dataRange)
                {
                    cell.Value = array[i].Text;
                    i++;
                }

                templateFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Templates\Liquid Results Public.xlsx"));
                templateSheet = (Excel.Worksheet)templateFile.Sheets["Liquid_Lines_Data"];

                inputSheets.Range["B1", "B12"].Copy(templateSheet.Range["B1", "B12"]);
                inputSheets.Range["B16", "J19"].Copy(templateSheet.Range["B16", "J19"]);

                liquidLinesTransect = templateFile.Sheets.Add();
                liquidLinesTransect.Name = "Liquid_Lines_Transect";

                inputSheets.ChartObjects("Chart 1").Chart.CopyPicture();
                liquidLinesTransect.Paste();

                templateFile.SaveAs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), data1.Text));
            }
            finally
            {
                // Clean up sheets
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(liquidLinesTransect);
                Marshal.FinalReleaseComObject(templateSheet);
                Marshal.FinalReleaseComObject(inputSheets);
                Marshal.FinalReleaseComObject(books);

                Marshal.FinalReleaseComObject(dataRange);
                Marshal.FinalReleaseComObject(liquidLinesTransect);

                liquidLinesTransect = null;
                templateSheet = null;
                inputSheets = null;
                books = null;

                dataRange = null;

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

        private void closeNotification(object sender, EventArgs e)
        {
            notificationPanel.Hide();
            notificationPanel.Controls.Find("lblGenerating", true)[0].Show();
            notificationPanel.Controls.Find("lblSuccess", true)[0].Hide();
            notificationPanel.Controls.Find("btnClose", true)[0].Hide();
        }
    }
}
