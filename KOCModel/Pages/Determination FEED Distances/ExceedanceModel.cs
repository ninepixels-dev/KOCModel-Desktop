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
    public partial class ExceedanceModel : UserControl
    {
        public ExceedanceModel() {
            InitializeComponent();

            MyStaticValues.separationDistanceColumns = 0;
            MyStaticValues.separationDistanceRows = 0;
            btnMoreFields1.PerformClick();
            btnMoreFields2.PerformClick();
        }

        public static class MyStaticValues {
            public static int separationDistanceColumns { get; set; }
            public static int separationDistanceRows { get; set; }
        }

        private void btnMoreFields1_Click(object sender, EventArgs e) {
            processUnitTable.RowCount++;
            separationDistanceTable.RowCount++;
            MyStaticValues.separationDistanceRows++;

            var textbox1 = new TextBox() { Name = "Column0-Row" + MyStaticValues.separationDistanceRows, Dock = DockStyle.Fill };
            textbox1.TextChanged += Control_TextChanged;

            processUnitTable.Controls.Add(textbox1, 0, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new TextBox() { Name = "Column1-Row" + MyStaticValues.separationDistanceRows, Dock = DockStyle.Fill }, 1, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new TextBox() { Name = "Column2-Row" + MyStaticValues.separationDistanceRows, Dock = DockStyle.Fill }, 2, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new TextBox() { Name = "Column3-Row" + MyStaticValues.separationDistanceRows, Dock = DockStyle.Fill }, 3, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new ComboBox() { Name = "Column4-Row" + MyStaticValues.separationDistanceRows, Items = {"C1", "C3"}, Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.White }, 4, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new ComboBox() { Name = "Column5-Row" + MyStaticValues.separationDistanceRows, Items = {"Low", "Medium", "High", "Severe", }, Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.White }, 5, processUnitTable.RowCount - 1);
            processUnitTable.Controls.Add(new TextBox() { Name = "Column6-Row" + MyStaticValues.separationDistanceRows, Dock = DockStyle.Fill }, 6, processUnitTable.RowCount - 1);

            var separationDistanceHeight = buildingDetailsTable.Height > processUnitTable.Height ? buildingDetailsTable.Height : processUnitTable.Height;
            separationDistancePanel.Location = new Point(
                 separationDistancePanel.Location.X, separationDistanceHeight + 200
            );

            for (int i = 0; i <= MyStaticValues.separationDistanceColumns; i++) {

                var control = new TextBox() {
                    Name = "dataColumn" + i + "-Row" + MyStaticValues.separationDistanceRows,
                    Dock = DockStyle.Fill,
                    Enabled = i == 0 ? false : true,
                    BackColor = i == 0 ? Color.FromArgb(144, 238, 144) : Color.FromArgb(255, 255, 255),
                    AccessibleName = i == 0 ? "Ignore" : ""
                };

                if (MyStaticValues.separationDistanceRows == 1) {
                    separationDistanceTable.Controls.Add(new TextBox() {
                        Name = "dataColumn" + 0 + "-Row" + MyStaticValues.separationDistanceRows,
                        BackColor = Color.FromArgb(144, 238, 144),
                        Enabled = false,
                        Dock = DockStyle.Fill,
                        AccessibleName = "Ignore"
                    }, 0, MyStaticValues.separationDistanceRows);

                    separationDistanceTable.Controls.Add(new TextBox() {
                        Name = "dataColumn" + 1 + "-Row" + MyStaticValues.separationDistanceRows,
                        Dock = DockStyle.Fill
                    }, 1, MyStaticValues.separationDistanceRows);

                } else {
                    separationDistanceTable.Controls.Add(control, i, MyStaticValues.separationDistanceRows);
                }
            }
        }

        private void btnMoreFields2_Click(object sender, EventArgs e) {
            buildingDetailsTable.RowCount++;
            separationDistanceTable.ColumnCount++;

            var textbox1 = new TextBox() { Name = "Column" + (MyStaticValues.separationDistanceColumns+1) + "-Row0", Dock = DockStyle.Fill, AccessibleName = "Ignore" };
            textbox1.TextChanged += Control_TextChanged;

            buildingDetailsTable.Controls.Add(textbox1, 0, buildingDetailsTable.RowCount - 1);
            buildingDetailsTable.Controls.Add(new TextBox() { Name = "Column" + (MyStaticValues.separationDistanceColumns+1) + "-Row0", Dock = DockStyle.Fill }, 1, buildingDetailsTable.RowCount - 1);
            buildingDetailsTable.Controls.Add(new ComboBox() { Name = "Column" + (MyStaticValues.separationDistanceColumns+1) + "-Row0", Items = {"B1", "B2", "B3", "B4"}, Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.White }, 2, buildingDetailsTable.RowCount - 1);

            var separationDistanceHeight = buildingDetailsTable.Height > processUnitTable.Height ? buildingDetailsTable.Height : processUnitTable.Height;
            separationDistancePanel.Location = new Point(
                 separationDistancePanel.Location.X, separationDistanceHeight + 200
            );

            for (int i = 0; i <= MyStaticValues.separationDistanceRows; i++) {
                var control = new TextBox() {
                    Name = "dataColumn" + (MyStaticValues.separationDistanceColumns + 1) + "-Row" + i,
                    Enabled = i == 0 ? false : true,
                    BackColor= i == 0 ? Color.FromArgb(255, 255, 0) : Color.FromArgb(255, 255, 255),
                    Dock = DockStyle.Fill,
                    AccessibleName = i == 0 ? "Ignore" : ""
                };
                
                if (MyStaticValues.separationDistanceColumns == 0 && i == 0 ) {
                    separationDistanceTable.Controls.Add(control, MyStaticValues.separationDistanceColumns+1, i);
                } else if (MyStaticValues.separationDistanceColumns > 0) {
                    separationDistanceTable.Controls.Add(control, MyStaticValues.separationDistanceColumns+1, i);
                }
            }

            MyStaticValues.separationDistanceColumns++;
        }

        private void Control_TextChanged(object sender, EventArgs e) {
            Control control = (Control)sender;
            Control[] getControl = this.Controls.Find("data" + control.Name, true);

            getControl[0].Text = control.Text;
        }

        private void generateField(object sender, EventArgs e) {
            Excel.Application excelApp = null;
            Excel.Workbooks books = null;
            Excel.Workbook inputFile = null;
            Excel.Workbook templateFile = null;
            Excel.Worksheet inputSheets = null;
            Excel.Worksheet templateSheet = null;
            Excel.Worksheet exceedanceCurves = null;
            Excel.Sheets templateSheets = null;
            Excel.AddIn solver = null;
            Excel.Range cellType1 = null;
            Excel.Range cellType2 = null;
            Excel.Range cellType3 = null;

            notificationPanel.Show();

            try {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                books = excelApp.Workbooks;

                inputFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\exceedance_model.xlsm"));
                inputSheets = inputFile.Sheets["Input"];

                solver = excelApp.AddIns["Solver Add-In"];
                books.Open(solver.FullName);

                cellType1 = inputSheets.UsedRange;
                cellType2 = inputSheets.UsedRange;
                cellType3 = inputSheets.UsedRange;

                foreach (Control x in processUnitTable.Controls) {
                    if (x is TextBox || x is ComboBox) {
                        cellType1 = inputSheets.Cells[processUnitTable.GetRow(x) + 4, processUnitTable.GetColumn(x) + 1];
                        cellType1.Value = x.Text;

                        Marshal.FinalReleaseComObject(cellType1);
                    }
                }

                foreach (Control x in buildingDetailsTable.Controls) {
                    if ((x is TextBox || x is ComboBox ) && x.AccessibleName != "Ignore") {
                        cellType2 = inputSheets.Cells[buildingDetailsTable.GetColumn(x), buildingDetailsTable.GetRow(x) + 8];
                        cellType2.Value = x.Text;

                        Marshal.FinalReleaseComObject(cellType2);
                    }
                }

                foreach (Control x in separationDistanceTable.Controls) {
                    if ((x is TextBox || x is ComboBox) && x.AccessibleName != "Ignore") {
                        cellType3 = inputSheets.Cells[separationDistanceTable.GetRow(x) + 4, separationDistanceTable.GetColumn(x) + 8];
                        cellType3.Value = x.Text;

                        Marshal.FinalReleaseComObject(cellType3);
                    }
                }

                excelApp.Run("'exceedance_model.xlsm'!exceedance");

                templateFile = books.Open(Path.Combine(Environment.CurrentDirectory, @"Templates\Exceedance Results.xlsx"));
                templateSheet = templateFile.Sheets["Exceedance_Data"];
                templateSheets = templateFile.Sheets;

                excelApp.DisplayAlerts = false;

                inputSheets.Range["A1", "R24"].Copy(templateSheet.Range["A1", "R24"]);

                exceedanceCurves = templateSheets.Add();
                exceedanceCurves.Name = "Exceedance_Curves";

                inputSheets.ChartObjects("Chart 2").Chart.CopyPicture();
                exceedanceCurves.Paste();

                templateFile.SaveAs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Exceedance Results.xlsx"));

            } finally {
                // Clean up sheets
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (cellType1 != null) {
                    Marshal.FinalReleaseComObject(cellType1);
                    cellType1 = null;
                }

                if (cellType2 != null) {
                    Marshal.FinalReleaseComObject(cellType2);
                    cellType2 = null;
                }

                if (cellType3 != null) {
                    Marshal.FinalReleaseComObject(cellType3);
                    cellType3 = null;
                }

                Marshal.FinalReleaseComObject(templateSheets);
                Marshal.FinalReleaseComObject(exceedanceCurves);
                Marshal.FinalReleaseComObject(templateSheet);
                Marshal.FinalReleaseComObject(inputSheets);
                Marshal.FinalReleaseComObject(solver);
                Marshal.FinalReleaseComObject(books);

                templateSheets = null;
                exceedanceCurves = null;
                templateSheet = null;
                inputSheets = null;
                solver = null;
                books = null;

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
