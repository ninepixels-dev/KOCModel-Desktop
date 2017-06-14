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
    public partial class Blowouts30 : UserControl {
        public Blowouts30() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                double value = 0;
                double result = 0;

                value = double.Parse(textBox1.Text) / 100;
                result = 1289.6 * Math.Pow(value, 0.905);
                lblValue1.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 1929.4 * Math.Pow(value, 0.9171);
                lblValue2.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 2426.8 * Math.Pow(value, 0.8145);
                lblValue3.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 3171.7 * Math.Pow(value, 0.7349);
                lblValue4.Text = Math.Round(result).ToString();

                notificationPanel.Show();
            }
        }

        private void hideNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
        }
    }
}
