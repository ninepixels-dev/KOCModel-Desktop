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
    public partial class Blowouts100 : UserControl {
        public Blowouts100() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                double value = 0;
                double result = 0;

                value = double.Parse(textBox1.Text) / 100;
                result = 3451.6 * Math.Pow(value, 0.9782);
                lblValue1.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 3627.6 * Math.Pow(value, 0.9662);
                lblValue2.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 6046.7 * Math.Pow(value, 0.8156);
                lblValue3.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 9486.5 * Math.Pow(value, 0.6589);
                lblValue4.Text = Math.Round(result).ToString();

                notificationPanel.Show();
            }
        }

        private void hideNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
        }
    }
}
