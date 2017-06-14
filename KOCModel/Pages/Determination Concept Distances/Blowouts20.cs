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
                result = 1155.8 * Math.Pow(value, 0.8987);
                lblValue1.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 1654 * Math.Pow(value, 0.8969);
                lblValue2.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 2038.1 * Math.Pow(value, 0.793);
                lblValue3.Text = Math.Round(result).ToString();

                value = double.Parse(textBox1.Text) / 100;
                result = 3028 * Math.Pow(value, 0.7861);
                lblValue4.Text = Math.Round(result).ToString();

                notificationPanel.Show();
            }
        }

        private void hideNotification(object sender, EventArgs e) {
            notificationPanel.Hide();
        }
    }
}
