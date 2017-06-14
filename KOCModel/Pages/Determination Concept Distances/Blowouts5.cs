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
    public partial class Blowouts5 : UserControl {
        public Blowouts5() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                double value = 0;
                double result = 0;

                value = double.Parse(textBox1.Text) / 100;
                result = 818.48 * Math.Pow(value, 0.9088);
                lblValue1.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 1012.7 * Math.Pow(value, 0.8459);
                lblValue2.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 1399.2 * Math.Pow(value, 0.819);
                lblValue3.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 2201.7 * Math.Pow(value, 0.8351);
                lblValue4.Text = Math.Round(result).ToString();

                notificationPanel.Show();
            }
        }

        private void hideNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
        }
    }
}
