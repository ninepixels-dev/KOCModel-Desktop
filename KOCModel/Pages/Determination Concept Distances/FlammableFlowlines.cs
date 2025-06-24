using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOCModel {
    public partial class FlammableFlowlines : UserControl {
        public FlammableFlowlines() {
            InitializeComponent();
        }

        private void btnRunModel_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && textBox2.Text != "") {
                double D = double.Parse(textBox1.Text);
                double P = double.Parse(textBox2.Text);
                double Q = 0;

                if (radioButton1.Checked) {
                    Q = 0.6;
                } else if (radioButton2.Checked) {
                    Q = 1;
                } else if (radioButton2.Checked) {
                    Q = 1.25;
                }

                double a = Math.Pow(D, 2) / 32000 + D / 160 + 11;
                double b = P / 32 + 1.4;

                double x = 10 * (Q * a * b) / 10;

                lblValue.Text = x.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
}
