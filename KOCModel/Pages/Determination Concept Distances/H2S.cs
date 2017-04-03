using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOCModel
{
    public partial class H2S : UserControl {
        public H2S() {
            InitializeComponent();
        }

        private void H2S_Load(object sender, EventArgs e) {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // X Axis
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.01", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(60, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.02", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(139, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.03", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(187, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.04", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(221, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.05", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(246, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.06", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(269, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.07", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(286, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.08", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(302, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.09", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(316, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.1", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(329, 17), Visible = false });

            pictureBox1.Controls.Add(new Label() { Name = "lbl0.2", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 139, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.3", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 187, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.4", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 221, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.5", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 246, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.6", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 269, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.7", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 286, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.8", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 302, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl0.9", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 316, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl1", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(270 + 329, 17), Visible = false });

            pictureBox1.Controls.Add(new Label() { Name = "lbl2", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 139, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl3", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 187, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl4", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 221, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl5", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 246, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl6", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 269, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl7", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 286, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl8", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 302, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl9", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 316, 17), Visible = false });
            pictureBox1.Controls.Add(new Label() { Name = "lbl10", Size = new Size(2, 670), BackColor = Color.Red, Location = new Point(540 + 329, 17), Visible = false });
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && textBox2.Text != "") {
                double h2s = double.Parse(textBox1.Text);
                double p = double.Parse(textBox2.Text);
                double result = h2s * Math.Sqrt(p);
                double rounded = Math.Round(result * 10) / 10;

                result = 230.73 * Math.Pow(rounded, 1.1329);
                lblValue1.Text = Math.Round(result).ToString();

                result = 420.06 * Math.Pow(rounded, 0.92);
                lblValue2.Text = Math.Round(result).ToString();

                result = 659.51 * Math.Pow(rounded, 0.76);
                lblValue3.Text = Math.Round(result).ToString();

                result = 941.6 * Math.Pow(rounded, 0.6297);
                lblValue4.Text = Math.Round(result).ToString();

                foreach (Control child in pictureBox1.Controls) {
                    child.Hide();
                }

                lblResultValue.Text = rounded.ToString();

                try {
                    Control[] getControl = pictureBox1.Controls.Find("lbl" + rounded.ToString(), true);
                    if (getControl.Length > 0) {
                        getControl[0].Show();
                    }
                } finally {}

                resultPanel.Show();
            }
        }

        private void validateInput(object sender, EventArgs e) {
            Control control = (Control)sender;

            double n;
            bool isDouble = double.TryParse(control.Text, out n);

            if (!isDouble) {
                control.Text = "";
            }

            if (isDouble && (double.Parse(control.Text) < 0 || double.Parse(control.Text) > 10)) {
                control.Text = "";
            }
        }

        private void isNumeric(object sender, EventArgs e) {
            Control control = (Control)sender;
            
            int n;
            bool isNumeric = int.TryParse(control.Text, out n);

            if (!isNumeric) {
                control.Text = "";
            }
        }

        private void removePlaceholder(object sender, EventArgs e) {
            Control control = (Control)sender;

            if (control.Text == "H2S") {
                control.Text = "";
            }

            if (control.Text == "P") {
                control.Text = "";
            }
        }
    }
}
