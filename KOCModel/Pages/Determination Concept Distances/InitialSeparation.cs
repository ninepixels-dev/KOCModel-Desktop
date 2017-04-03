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
    public partial class InitialSeparation : UserControl {
        public InitialSeparation() {
            InitializeComponent();
        }

        private void toggleValidator(object sender, EventArgs e) {
            if (comboBox1.Text != "" && comboBox2.Text != "") {
                for (int r = 1; r < 25; r++) {
                    if (InitPage.excelValues.inputSheets.Cells[84 + r, 1].Value == comboBox1.Text) {
                        for (int c = 1; c < 24; c++) {
                            if (InitPage.excelValues.inputSheets.Cells[84 + c, 1].Value == comboBox2.Text) {
                                if (InitPage.excelValues.inputSheets.Cells[84 + r, c + 1].Value != null && InitPage.excelValues.inputSheets.Cells[84 + r, c + 1].Value.ToString() != "") {
                                    lblValue.Text = InitPage.excelValues.inputSheets.Cells[84 + r, c + 1].Value.ToString();
                                } else {
                                    lblValue.Text = InitPage.excelValues.inputSheets.Cells[84 + c, r + 1].Value.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InitialSeparation_Load(object sender, EventArgs e) {
            try {
                if (InitPage.excelValues.excelApp == null) {
                    InitPage.excelValues.excelApp = new Excel.Application();
                    InitPage.excelValues.excelApp.Visible = false;
                    InitPage.excelValues.excelApp.DisplayAlerts = false;
                }

                InitPage.excelValues.books = InitPage.excelValues.excelApp.Workbooks;

                InitPage.excelValues.inputFile = InitPage.excelValues.books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\main.xlsx"));
                InitPage.excelValues.inputSheets = InitPage.excelValues.inputFile.Sheets["Sheet2"];

                for (int i = 85; i <= 108; i++) {
                    comboBox1.Items.Add(InitPage.excelValues.inputSheets.Cells[i, 1].Value);
                    comboBox2.Items.Add(InitPage.excelValues.inputSheets.Cells[i, 1].Value);
                }
            } finally {
            }
        }
    }
}
