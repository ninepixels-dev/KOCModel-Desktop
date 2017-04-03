using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms.ComponentModel;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace KOCModel
{
    public partial class InitPage : Form {
        public InitPage() {
            InitializeComponent();

            // Check if EXCEL is installed
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null) {
                ExcelNotSupportedPanel.Show();
            } else {
                ExcelNotSupportedPanel.Hide();
            }

            // Starting page
            mainPanel.Controls.Add(new Homepage());
        }

        public static class GasLineValues {
            public static List<String> publicGasLine = new List<String>();
            public static List<String> plantGasLine = new List<String>();
        }

        public static class excelValues {
            public static Excel.Application excelApp = null;
            public static Excel.Workbooks books = null;
            public static Excel.Workbook inputFile = null;
            public static Excel.Worksheet inputSheets = null;
        }

        public void closeExcelApp(object sender, EventArgs e) {
            if (InitPage.excelValues.excelApp != null) {
                // Clean up sheets
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(InitPage.excelValues.inputSheets);
                Marshal.FinalReleaseComObject(InitPage.excelValues.books);

                InitPage.excelValues.inputSheets = null;
                InitPage.excelValues.books = null;

                InitPage.excelValues.inputFile.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                Marshal.ReleaseComObject(InitPage.excelValues.inputFile);

                InitPage.excelValues.inputFile = null;

                InitPage.excelValues.excelApp.Quit();
                Marshal.ReleaseComObject(InitPage.excelValues.excelApp);

                InitPage.excelValues.excelApp = null;
            }
        }

        private void InitPage_FormClosing(object sender, FormClosingEventArgs e) {
            closeExcelApp(sender, e);
        }

        private void togglePanel(object sender, EventArgs e) {
            Control control = (Control)sender;
            mainPanel.Controls.Clear();

            switch (control.AccessibleName) {
                case "Homepage":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Homepage());
                    break;

                case "GeneralConsiderations":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new GeneralConsiderations());
                    break;

                case "ConceptGeneral":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ConceptGeneral());
                    break;

                case "ConceptSiting":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ConceptSiting());
                    break;

                case "ConceptLayout":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ConceptLayout());
                    break;

                case "ConceptEquipment":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ConceptEquipment());
                    break;

                case "ConceptBRA":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ConceptBRA());
                    break;

                case "InitialSeparation":
                    mainPanel.Controls.Add(new InitialSeparation());
                    break;

                case "FlammableWellsDistances":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FlammableWellsDistances());
                    break;

                case "FlammableFlowlines":
                    mainPanel.Controls.Add(new FlammableFlowlines());
                    break;

                case "TypicalFlammable":
                    mainPanel.Controls.Add(new TypicalFlammable());
                    break;

                case "FlammableUnmanned":
                    mainPanel.Controls.Add(new FlammableUnmanned());
                    break;

                case "FlammableManned":
                    mainPanel.Controls.Add(new FlammableManned());
                    break;

                case "TanksDistances":
                    mainPanel.Controls.Add(new TanksDistances());
                    break;

                case "H2S":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new H2S());
                    break;

                case "Blowouts5":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts5());
                    break;

                case "Blowouts10":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts10());
                    break;

                case "Blowouts20":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts20());
                    break;

                case "Blowouts30":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts30());
                    break;

                case "Blowouts50":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts50());
                    break;

                case "Blowouts100":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new Blowouts100());
                    break;

                case "FEEDGeneral":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FEEDGeneral());
                    break;

                case "FEEDSiting":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FEEDSiting());
                    break;

                case "FEEDLayout":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FEEDLayout());
                    break;

                case "FEEDEquipment":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FEEDEquipment());
                    break;

                case "FEEDBra":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new FEEDBra());
                    break;

                case "DetailedDesignField":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new DetailedDesignField());
                    break;

                case "DetailedDesignBRA":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new DetailedDesignBRA());
                    break;

                case "ExceedanceModel":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new ExceedanceModel());
                    break;

                case "PlantWellFlowlines":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PlantWellFlowlines());
                    break;

                case "PlantLiquidProduct":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PlantLiquidProduct());
                    break;

                case "PlantGasLines":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PlantGasLines());
                    break;

                case "PublicWellFlowlines":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PublicWellFlowlines());
                    break;

                case "PublicLiquidProduct":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PublicLiquidProduct());
                    break;

                case "PublicGasLines":
                    closeExcelApp(sender, e);
                    mainPanel.Controls.Add(new PublicGasLines());
                    break;
            }

            mainPanel.Dock = DockStyle.Fill;
        }

        private void toggleSubtree1(object sender, EventArgs e) {
            subtreePanel1.Visible = !subtreePanel1.Visible;
        }

        private void toggleSubtree2(object sender, EventArgs e) {
            subtreePanel2.Visible = !subtreePanel2.Visible;
        }

        private void toggleSubtree3(object sender, EventArgs e) {
            subtreePanel3.Visible = !subtreePanel3.Visible;
        }

        private void toggleSubtree4(object sender, EventArgs e) {
            subtreePanel4.Visible = !subtreePanel4.Visible;
        }

        private void label3_Click(object sender, EventArgs e) {
            ExcelNotSupportedPanel.Hide();
        }
    }
}   