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
    public partial class TanksDistances : UserControl {
        public TanksDistances() {
            InitializeComponent();
        }

        private void toggleValidator(object sender, EventArgs e) {
            if (comboBox1.Text != "") {
                for (int r = 1; r <= 14; r++) {
                    if (InitPage.excelValues.inputSheets.Cells[171 + r, 1].Value == comboBox1.Text) {
                        lblValue.Text = InitPage.excelValues.inputSheets.Cells[171 + r, 2].Value.ToString();
                    }
                }
            }
        }

        private void TanksDistances_Load(object sender, EventArgs e) {
            try {
                if (InitPage.excelValues.excelApp == null) {
                    InitPage.excelValues.excelApp = new Excel.Application();
                    InitPage.excelValues.excelApp.Visible = false;
                    InitPage.excelValues.excelApp.DisplayAlerts = false;
                }

                InitPage.excelValues.books = InitPage.excelValues.excelApp.Workbooks;

                InitPage.excelValues.inputFile = InitPage.excelValues.books.Open(Path.Combine(Environment.CurrentDirectory, @"Workbooks\main.xlsx"));
                InitPage.excelValues.inputSheets = InitPage.excelValues.inputFile.Sheets["Sheet2"];

                for (int i = 172; i <= 185; i++) {
                    comboBox1.Items.Add(InitPage.excelValues.inputSheets.Cells[i, 1].Value);
                }

            } finally { }
        }
    }
}
