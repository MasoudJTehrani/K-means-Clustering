namespace K_means_Masterpiece
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dimension = new System.Windows.Forms.NumericUpDown();
            this.done = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.k = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minp = new System.Windows.Forms.NumericUpDown();
            this.to = new System.Windows.Forms.Label();
            this.maxp = new System.Windows.Forms.NumericUpDown();
            this.maxpl = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.p = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimension)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(27, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload excel file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OR";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(220, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate Random Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.max);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dimension);
            this.panel1.Location = new System.Drawing.Point(27, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 179);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(86, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(193, 107);
            this.max.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.max.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(120, 22);
            this.max.TabIndex = 7;
            this.max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max value";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(193, 75);
            this.min.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.min.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(120, 22);
            this.min.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min value";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(193, 45);
            this.number.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.number.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 22);
            this.number.TabIndex = 3;
            this.number.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dimensions";
            // 
            // dimension
            // 
            this.dimension.Location = new System.Drawing.Point(193, 13);
            this.dimension.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.dimension.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(120, 22);
            this.dimension.TabIndex = 0;
            this.dimension.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.ForeColor = System.Drawing.Color.Green;
            this.done.Location = new System.Drawing.Point(23, 269);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(0, 17);
            this.done.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.k);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(27, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 78);
            this.panel2.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(178, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "My choice of K";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(178, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Best K ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(6, 40);
            this.k.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.k.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(120, 22);
            this.k.TabIndex = 8;
            this.k.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.k.Visible = false;
            this.k.ValueChanged += new System.EventHandler(this.k_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "How many clusters?(K)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.minp);
            this.panel3.Controls.Add(this.to);
            this.panel3.Controls.Add(this.maxp);
            this.panel3.Controls.Add(this.maxpl);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Controls.Add(this.p);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(27, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 166);
            this.panel3.TabIndex = 6;
            // 
            // minp
            // 
            this.minp.Location = new System.Drawing.Point(87, 132);
            this.minp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minp.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.minp.Name = "minp";
            this.minp.Size = new System.Drawing.Size(74, 22);
            this.minp.TabIndex = 19;
            this.minp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minp.Visible = false;
            this.minp.ValueChanged += new System.EventHandler(this.minp_ValueChanged);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(166, 134);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(25, 17);
            this.to.TabIndex = 18;
            this.to.Text = "To";
            this.to.Visible = false;
            // 
            // maxp
            // 
            this.maxp.Location = new System.Drawing.Point(192, 132);
            this.maxp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxp.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.maxp.Name = "maxp";
            this.maxp.Size = new System.Drawing.Size(74, 22);
            this.maxp.TabIndex = 17;
            this.maxp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxp.Visible = false;
            this.maxp.ValueChanged += new System.EventHandler(this.maxp_ValueChanged);
            // 
            // maxpl
            // 
            this.maxpl.AutoSize = true;
            this.maxpl.Location = new System.Drawing.Point(27, 134);
            this.maxpl.Name = "maxpl";
            this.maxpl.Size = new System.Drawing.Size(61, 17);
            this.maxpl.TabIndex = 16;
            this.maxpl.Text = "P From :";
            this.maxpl.Visible = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 110);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(116, 21);
            this.radioButton6.TabIndex = 15;
            this.radioButton6.Text = "Best Distance";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(217, 87);
            this.p.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.p.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(90, 22);
            this.p.TabIndex = 11;
            this.p.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p.Visible = false;
            this.p.ValueChanged += new System.EventHandler(this.p_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "P :";
            this.label8.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 83);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(151, 21);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.Text = "Minkowski Distance";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 56);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(155, 21);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.Text = "Manhattan Distance";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(150, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Euclidean Distance";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Distance measure";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(575, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Start Calculation";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 559);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.done);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-means by MJT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimension)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dimension;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label done;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown k;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.NumericUpDown maxp;
        private System.Windows.Forms.Label maxpl;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.NumericUpDown minp;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Button button4;
    }
}

