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
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace KOCModel
{
    public partial class PlantWellFlowlines : UserControl {
        public PlantWellFlowlines() {
            InitializeComponent();

            if (InitPage.GasLineValues.plantGasLine.Count == 0) {
                EmptyGasLines.Show();
                btnRunModel.Enabled = false;
            } else {
                EmptyGasLines.Hide();
                btnRunModel.Enabled = true;
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 39);
                panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 39);
            }
        }

        private void runModel(object sender, EventArgs e) {
            TextBox[] array = { data1, data2, data3, data4, data5, data6, data7, data8, data9 };
            TextBox[] fireHole = { hole50, hole5 };

            notificationPanel.Show();

            Excel.Application excelApp = null;
            Excel.Workbooks books = null;
            Excel.Workbook inputFile = null;
            Excel.Workbook templateFile = null;
            Excel.Worksheet inputSheets = null;
            Excel.Worksheet fireBallSheet = null;
            Excel.Worksheet templateSheet = null;
            Excel.Worksheet wellLinesTransect = null;
            Excel.Sheets templateSheets = null;
            Excel.Range dataRange = null;
            Excel.Range holeRange = null;
            Excel.Range fireBallRange = null;

            try {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                books = excelApp.Workbooks;

                inputFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\well_lines.xlsx"));
                inputSheets = inputFile.Sheets["Well lines input sheet"];
                fireBallSheet = inputFile.Sheets["Fire Ball"];

                dataRange = inputSheets.Range["B1", "B9"];
                int i = 0;
                foreach (Excel.Range cell in dataRange)
                {
                    cell.Value = array[i].Text;
                    i++;
                    Marshal.FinalReleaseComObject(cell);
                }

                holeRange = inputSheets.Range["B17", "B18"];
                int iter = 0;
                foreach (Excel.Range cell in holeRange)
                {
                    cell.Value = fireHole[iter].Text;
                    iter++;
                    Marshal.FinalReleaseComObject(cell);
                }

                int index = 0;
                fireBallRange = fireBallSheet.Range["E4", "E104"];
                foreach (Excel.Range cell in fireBallRange)
                {
                    double step5 = double.Parse(step5factor.Text);
                    double value = double.Parse(InitPage.GasLineValues.plantGasLine[index]) * double.Parse(step5factor.Text);

                    cell.Value = value;
                    index++;
                    Marshal.FinalReleaseComObject(cell);
                }

                templateFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Templates\Well Results.xlsx"));
                templateSheet = templateFile.Sheets["Well_Lines_Data"];
                templateSheets = templateFile.Sheets;

                inputSheets.Range["B1", "B11"].Copy(templateSheet.Range["B1", "B11"]);
                inputSheets.Range["B17", "B18"].Copy(templateSheet.Range["B16", "B17"]);

                wellLinesTransect = templateSheets.Add();
                wellLinesTransect.Name = "Well_Lines_Transect";

                inputSheets.ChartObjects("Chart 3").Chart.CopyPicture();
                wellLinesTransect.Paste();

                templateFile.SaveAs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), data1.Text));
            }
            finally
            {
                // Clean up sheets
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(wellLinesTransect);
                Marshal.FinalReleaseComObject(templateSheet);
                Marshal.FinalReleaseComObject(fireBallSheet);
                Marshal.FinalReleaseComObject(inputSheets);
                Marshal.FinalReleaseComObject(books);

                Marshal.FinalReleaseComObject(templateSheets);
                Marshal.FinalReleaseComObject(dataRange);
                Marshal.FinalReleaseComObject(holeRange);
                Marshal.FinalReleaseComObject(fireBallRange);

                wellLinesTransect = null;
                templateSheet = null;
                fireBallSheet = null;
                inputSheets = null;
                books = null;

                templateSheets = null;
                dataRange = null;
                holeRange = null;
                fireBallRange = null;

                inputFile.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                templateFile.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

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

        private void showMoreInfo(object sender, EventArgs e) {
            moreInfoPanel.Show();
        }

        private void hideMoreInfo(object sender, EventArgs e) {
            moreInfoPanel.Hide();
        }
    }
}
