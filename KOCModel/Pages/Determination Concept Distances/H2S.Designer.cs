namespace KOCModel
{
    partial class H2S
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label36 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(190, 753);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 13);
            this.label36.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(598, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Recommended Spacing for Manned Facilities With Toxic Gas Streams";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 52);
            this.panel3.TabIndex = 93;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Dock = System.Windows.Forms.DockStyle.Top;
            this.label37.Location = new System.Drawing.Point(0, 52);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(972, 1);
            this.label37.TabIndex = 94;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KOCModel.Properties.Resources.h2s;
            this.pictureBox1.Location = new System.Drawing.Point(75, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 730);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 851);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 103;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(423, 854);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 98;
            this.label2.Text = "* √ ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(371, 851);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 33);
            this.textBox1.TabIndex = 97;
            this.textBox1.Text = "H2S";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.removePlaceholder);
            this.textBox1.TextChanged += new System.EventHandler(this.validateInput);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(400, 822);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 26);
            this.label3.TabIndex = 100;
            this.label3.Text = "Molfraction H2S * √ (P) (bar): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(515, 854);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "(bar)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(459, 851);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 33);
            this.textBox2.TabIndex = 102;
            this.textBox2.Text = "P";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.removePlaceholder);
            this.textBox2.TextChanged += new System.EventHandler(this.isNumeric);
            // 
            // lblValue4
            // 
            this.lblValue4.AutoSize = true;
            this.lblValue4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValue4.ForeColor = System.Drawing.Color.Purple;
            this.lblValue4.Location = new System.Drawing.Point(168, 212);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(95, 26);
            this.lblValue4.TabIndex = 111;
            this.lblValue4.Text = "650 ppm:";
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(173)))), ((int)(((byte)(67)))));
            this.lblValue3.Location = new System.Drawing.Point(168, 173);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(95, 26);
            this.lblValue3.TabIndex = 110;
            this.lblValue3.Text = "650 ppm:";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValue2.ForeColor = System.Drawing.Color.Red;
            this.lblValue2.Location = new System.Drawing.Point(168, 135);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(95, 26);
            this.lblValue2.TabIndex = 109;
            this.lblValue2.Text = "650 ppm:";
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.BackColor = System.Drawing.Color.Transparent;
            this.lblValue1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblValue1.Location = new System.Drawing.Point(168, 96);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(95, 26);
            this.lblValue1.TabIndex = 108;
            this.lblValue1.Text = "650 ppm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(82, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 107;
            this.label7.Text = "30 ppm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(70, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 106;
            this.label6.Text = "100 ppm:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(70, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 105;
            this.label5.Text = "300 ppm:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(70, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "650 ppm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(42, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 29);
            this.label8.TabIndex = 103;
            this.label8.Text = "Calculted distances (m):";
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.lblResultValue);
            this.resultPanel.Controls.Add(this.lblValue4);
            this.resultPanel.Controls.Add(this.lblValue3);
            this.resultPanel.Controls.Add(this.label9);
            this.resultPanel.Controls.Add(this.lblValue2);
            this.resultPanel.Controls.Add(this.lblValue1);
            this.resultPanel.Controls.Add(this.label7);
            this.resultPanel.Controls.Add(this.label6);
            this.resultPanel.Controls.Add(this.label5);
            this.resultPanel.Controls.Add(this.label4);
            this.resultPanel.Controls.Add(this.label8);
            this.resultPanel.Location = new System.Drawing.Point(361, 886);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(332, 267);
            this.resultPanel.TabIndex = 112;
            this.resultPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(110, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 33);
            this.label9.TabIndex = 112;
            this.label9.Text = "Result: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultValue.Location = new System.Drawing.Point(201, 12);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(29, 33);
            this.lblResultValue.TabIndex = 113;
            this.lblResultValue.Text = "0";
            this.lblResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // H2S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Name = "H2S";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 26);
            this.Size = new System.Drawing.Size(972, 1182);
            this.Load += new System.EventHandler(this.H2S_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblValue4;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.Label label9;
    }
}
