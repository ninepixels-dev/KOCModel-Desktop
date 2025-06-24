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
    public partial class FlammableWellsDistances : UserControl {
        public FlammableWellsDistances() {
            InitializeComponent();
        }

        private void toggleValidator(object sender, EventArgs e) {
            if (comboBox1.Text != "" && comboBox2.Text != "") {
                for (int r = 1; r <= 2; r++) {
                    if (InitPage.excelValues.inputSheets.Cells[128 + r, 1].Value.ToString() == comboBox1.Text) {
                        for (int c = 1; c <= 6; c++) {
                            if (InitPage.excelValues.inputSheets.Cells[128, c + 1].Value.ToString() == comboBox2.Text) {
                                lblValue.Text = InitPage.excelValues.inputSheets.Cells[128 + r, c + 1].Value.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void FlammableWellsDistances_Load(object sender, EventArgs e) {
            try {
                if (InitPage.excelValues.excelApp == null) {
                    InitPage.excelValues.excelApp = new Excel.Application();
                    InitPage.excelValues.excelApp.Visible = false;
                    InitPage.excelValues.excelApp.DisplayAlerts = false;
                }

                InitPage.excelValues.books = InitPage.excelValues.excelApp.Workbooks;

                InitPage.excelValues.inputFile = InitPage.excelValues.books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\main.xlsx"));
                InitPage.excelValues.inputSheets = InitPage.excelValues.inputFile.Sheets["Sheet2"];

            } finally {}
        }
    }
}
