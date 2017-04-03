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
    public partial class FlammableManned : UserControl {
        public FlammableManned() {
            InitializeComponent();
        }

        private void toggleValidator(object sender, EventArgs e) {
            if (comboBox1.Text != "" && comboBox2.Text != "") {
                for (int r = 1; r <= 24; r++) {
                    if (InitPage.excelValues.inputSheets.Cells[144 + r, 1].Value == comboBox1.Text) {
                        for (int c = 1; c <= 19; c++) {
                            if (InitPage.excelValues.inputSheets.Cells[144, c + 1].Value == comboBox2.Text) {
                                if (InitPage.excelValues.inputSheets.Cells[144 + r, c + 1].Value != null) {
                                    lblValue.Text = InitPage.excelValues.inputSheets.Cells[144 + r, c + 1].Value.ToString();
                                } else {
                                    lblValue.Text = "To be determined by other requirements (e.g. operational, maintenance, inspection, etc.)";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FlammableManned_Load(object sender, EventArgs e) {
            try {
                if (InitPage.excelValues.excelApp == null) {
                    InitPage.excelValues.excelApp = new Excel.Application();
                    InitPage.excelValues.excelApp.Visible = false;
                    InitPage.excelValues.excelApp.DisplayAlerts = false;
                }

                InitPage.excelValues.books = InitPage.excelValues.excelApp.Workbooks;

                InitPage.excelValues.inputFile = InitPage.excelValues.books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\main.xlsx"));
                InitPage.excelValues.inputSheets = InitPage.excelValues.inputFile.Sheets["Sheet2"];

                for (int i = 145; i <= 168; i++) {
                    comboBox1.Items.Add(InitPage.excelValues.inputSheets.Cells[i, 1].Value);
                }

                for (int i = 2; i <= 19; i++) {
                    comboBox2.Items.Add(InitPage.excelValues.inputSheets.Cells[144, i].Value);
                }

            } finally { }
        }
    }
}
