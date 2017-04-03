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
    public partial class Blowouts20 : UserControl {
        public Blowouts20() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                double value = 0;
                double result = 0;

                value = double.Parse(textBox1.Text) / 100;
                result = 2200 * Math.Pow(value, 0.95);
                lblValue1.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 2200 * Math.Pow(value, 0.95);
                lblValue2.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 3500 * Math.Pow(value, 0.75);
                lblValue3.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 6000 * Math.Pow(value, 0.62);
                lblValue4.Text = Math.Round(result).ToString();

                notificationPanel.Show();
            }
        }

        private void hideNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
        }
    }
}
