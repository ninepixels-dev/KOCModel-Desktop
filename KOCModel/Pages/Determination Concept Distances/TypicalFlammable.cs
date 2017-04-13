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

namespace KOCModel {
    public partial class TypicalFlammable : UserControl {
        public TypicalFlammable() {
            InitializeComponent();
        }

        private void toggleValidator(object sender, EventArgs e) {
            if (comboBox1.Text != "" && comboBox2.Text != "") {
                for (int r = 1; r <= 6; r++) {
                    if (InitPage.excelValues.inputSheets.Cells[134 + r, 1].Value.ToString() == comboBox1.Text) {
                        for (int c = 1; c <= 3; c++) {
                            if (InitPage.excelValues.inputSheets.Cells[134, c + 1].Value.ToString() == comboBox2.Text) {
                                lblValue.Text = InitPage.excelValues.inputSheets.Cells[134 + r, c + 1].Value.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void TypicalFlammable_Load(object sender, EventArgs e) {
            try {
                if (InitPage.excelValues.excelApp == null) {
                    InitPage.excelValues.excelApp = new Excel.Application();
                    InitPage.excelValues.excelApp.Visible = false;
                    InitPage.excelValues.excelApp.DisplayAlerts = false;
                }

                InitPage.excelValues.books = InitPage.excelValues.excelApp.Workbooks;

                InitPage.excelValues.inputFile = InitPage.excelValues.books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\main.xlsx"));
                InitPage.excelValues.inputSheets = InitPage.excelValues.inputFile.Sheets["Sheet2"];

            } finally { }
        }

        private void showMoreInfo(object sender, EventArgs e) {
            moreInfoPanel.Show();
        }

        private void hideMoreInfo(object sender, EventArgs e) {
            moreInfoPanel.Hide();
        }
    }
}
