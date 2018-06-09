namespace Triangle_Solver
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.chkMedian = new System.Windows.Forms.CheckBox();
			this.lblP = new System.Windows.Forms.Label();
			this.lblh1 = new System.Windows.Forms.Label();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.txtAltidudeAB = new System.Windows.Forms.TextBox();
			this.lblA = new System.Windows.Forms.Label();
			this.chkAmbigious = new System.Windows.Forms.CheckBox();
			this.numDigits = new System.Windows.Forms.NumericUpDown();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.txtAltidudeBC = new System.Windows.Forms.TextBox();
			this.lblh3 = new System.Windows.Forms.Label();
			this.lblh2 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.txtAltidudeAC = new System.Windows.Forms.TextBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.chkGreek = new System.Windows.Forms.CheckBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtAC = new System.Windows.Forms.TextBox();
			this.txtBC = new System.Windows.Forms.TextBox();
			this.txtAB = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSideB = new System.Windows.Forms.Label();
			this.lblSideA = new System.Windows.Forms.Label();
			this.lblSideC = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSideAC = new System.Windows.Forms.Label();
			this.lblSideBC = new System.Windows.Forms.Label();
			this.lblSideAB = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.numDigits)).BeginInit();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// chkMedian
			// 
			this.chkMedian.AutoSize = true;
			this.chkMedian.Location = new System.Drawing.Point(465, 256);
			this.chkMedian.Name = "chkMedian";
			this.chkMedian.Size = new System.Drawing.Size(65, 17);
			this.chkMedian.TabIndex = 7;
			this.chkMedian.Text = "Medians";
			this.chkMedian.UseVisualStyleBackColor = true;
			this.chkMedian.CheckedChanged += new System.EventHandler(this.chkMedian_CheckedChanged);
			// 
			// lblP
			// 
			this.lblP.AutoSize = true;
			this.lblP.Font = new System.Drawing.Font("Cambria", 10F);
			this.lblP.Location = new System.Drawing.Point(5, 16);
			this.lblP.Name = "lblP";
			this.lblP.Size = new System.Drawing.Size(70, 16);
			this.lblP.TabIndex = 0;
			this.lblP.Text = "Perimeter";
			// 
			// lblh1
			// 
			this.lblh1.AutoSize = true;
			this.lblh1.Font = new System.Drawing.Font("Cambria", 10F);
			this.lblh1.Location = new System.Drawing.Point(6, 18);
			this.lblh1.Name = "lblh1";
			this.lblh1.Size = new System.Drawing.Size(45, 16);
			this.lblh1.TabIndex = 0;
			this.lblh1.Text = "to AB:";
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(77, 41);
			this.txtArea.MaxLength = 5;
			this.txtArea.Name = "txtArea";
			this.txtArea.ReadOnly = true;
			this.txtArea.Size = new System.Drawing.Size(100, 20);
			this.txtArea.TabIndex = 3;
			// 
			// txtPerimeter
			// 
			this.txtPerimeter.Location = new System.Drawing.Point(77, 15);
			this.txtPerimeter.MaxLength = 5;
			this.txtPerimeter.Name = "txtPerimeter";
			this.txtPerimeter.ReadOnly = true;
			this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
			this.txtPerimeter.TabIndex = 1;
			// 
			// txtAltidudeAB
			// 
			this.txtAltidudeAB.Location = new System.Drawing.Point(55, 16);
			this.txtAltidudeAB.MaxLength = 5;
			this.txtAltidudeAB.Name = "txtAltidudeAB";
			this.txtAltidudeAB.ReadOnly = true;
			this.txtAltidudeAB.Size = new System.Drawing.Size(100, 20);
			this.txtAltidudeAB.TabIndex = 1;
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Font = new System.Drawing.Font("Cambria", 10F);
			this.lblA.Location = new System.Drawing.Point(6, 42);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(37, 16);
			this.lblA.TabIndex = 2;
			this.lblA.Text = "Area";
			// 
			// chkAmbigious
			// 
			this.chkAmbigious.AutoSize = true;
			this.chkAmbigious.Location = new System.Drawing.Point(384, 443);
			this.chkAmbigious.Name = "chkAmbigious";
			this.chkAmbigious.Size = new System.Drawing.Size(112, 17);
			this.chkAmbigious.TabIndex = 10;
			this.chkAmbigious.Text = "Obtuse Ambigious";
			this.chkAmbigious.UseVisualStyleBackColor = true;
			this.chkAmbigious.CheckedChanged += new System.EventHandler(this.chkAmbigious_CheckedChanged);
			// 
			// numDigits
			// 
			this.numDigits.Location = new System.Drawing.Point(568, 442);
			this.numDigits.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numDigits.Name = "numDigits";
			this.numDigits.Size = new System.Drawing.Size(40, 20);
			this.numDigits.TabIndex = 12;
			this.numDigits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// Panel1
			// 
			this.Panel1.Location = new System.Drawing.Point(12, 212);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(250, 250);
			this.Panel1.TabIndex = 5;
			this.Panel1.SizeChanged += new System.EventHandler(this.Panel1_SizeChanged);
			this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.Panel1.DoubleClick += new System.EventHandler(this.Panel1_DoubleClick);
			// 
			// txtAltidudeBC
			// 
			this.txtAltidudeBC.Location = new System.Drawing.Point(55, 42);
			this.txtAltidudeBC.MaxLength = 5;
			this.txtAltidudeBC.Name = "txtAltidudeBC";
			this.txtAltidudeBC.ReadOnly = true;
			this.txtAltidudeBC.Size = new System.Drawing.Size(100, 20);
			this.txtAltidudeBC.TabIndex = 3;
			// 
			// lblh3
			// 
			this.lblh3.AutoSize = true;
			this.lblh3.Font = new System.Drawing.Font("Cambria", 10F);
			this.lblh3.Location = new System.Drawing.Point(6, 70);
			this.lblh3.Name = "lblh3";
			this.lblh3.Size = new System.Drawing.Size(44, 16);
			this.lblh3.TabIndex = 4;
			this.lblh3.Text = "to AC:";
			// 
			// lblh2
			// 
			this.lblh2.AutoSize = true;
			this.lblh2.Font = new System.Drawing.Font("Cambria", 10F);
			this.lblh2.Location = new System.Drawing.Point(6, 44);
			this.lblh2.Name = "lblh2";
			this.lblh2.Size = new System.Drawing.Size(44, 16);
			this.lblh2.TabIndex = 2;
			this.lblh2.Text = "to BC:";
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.txtArea);
			this.GroupBox3.Controls.Add(this.txtPerimeter);
			this.GroupBox3.Controls.Add(this.lblA);
			this.GroupBox3.Controls.Add(this.lblP);
			this.GroupBox3.Location = new System.Drawing.Point(268, 279);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(184, 94);
			this.GroupBox3.TabIndex = 6;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Other";
			// 
			// txtAltidudeAC
			// 
			this.txtAltidudeAC.Location = new System.Drawing.Point(55, 68);
			this.txtAltidudeAC.MaxLength = 5;
			this.txtAltidudeAC.Name = "txtAltidudeAC";
			this.txtAltidudeAC.ReadOnly = true;
			this.txtAltidudeAC.Size = new System.Drawing.Size(100, 20);
			this.txtAltidudeAC.TabIndex = 5;
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.txtAltidudeAC);
			this.GroupBox4.Controls.Add(this.txtAltidudeAB);
			this.GroupBox4.Controls.Add(this.txtAltidudeBC);
			this.GroupBox4.Controls.Add(this.lblh1);
			this.GroupBox4.Controls.Add(this.lblh3);
			this.GroupBox4.Controls.Add(this.lblh2);
			this.GroupBox4.Location = new System.Drawing.Point(456, 279);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(160, 94);
			this.GroupBox4.TabIndex = 8;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Altitude";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(508, 444);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(37, 13);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Digits:";
			// 
			// chkGreek
			// 
			this.chkGreek.AutoSize = true;
			this.chkGreek.Location = new System.Drawing.Point(268, 443);
			this.chkGreek.Name = "chkGreek";
			this.chkGreek.Size = new System.Drawing.Size(110, 17);
			this.chkGreek.TabIndex = 9;
			this.chkGreek.Text = "Greek Characters";
			this.chkGreek.UseVisualStyleBackColor = true;
			this.chkGreek.CheckedChanged += new System.EventHandler(this.chkGreek_CheckedChanged);
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(540, 7);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(76, 23);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "About";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(12, 36);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 13);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Select your inputs:";
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "AB_BC_CA",
            "AB_BC_A",
            "AB_BC_B",
            "AB_BC_C",
            "BC_CA_A",
            "BC_CA_B",
            "BC_CA_C",
            "CA_AB_A",
            "CA_AB_B",
            "CA_AB_C",
            "AB_A_B",
            "AB_B_C",
            "AB_C_A",
            "BC_A_B",
            "BC_B_C",
            "BC_C_A",
            "CA_A_B",
            "CA_B_C",
            "CA_C_A"});
			this.cmbType.Location = new System.Drawing.Point(134, 32);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(121, 23);
			this.cmbType.TabIndex = 1;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(261, 36);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(355, 237);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 35;
			this.PictureBox1.TabStop = false;
			// 
			// txtAC
			// 
			this.txtAC.Location = new System.Drawing.Point(40, 69);
			this.txtAC.MaxLength = 10;
			this.txtAC.Name = "txtAC";
			this.txtAC.Size = new System.Drawing.Size(100, 20);
			this.txtAC.TabIndex = 5;
			this.txtAC.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// txtBC
			// 
			this.txtBC.Location = new System.Drawing.Point(41, 43);
			this.txtBC.MaxLength = 10;
			this.txtBC.Name = "txtBC";
			this.txtBC.Size = new System.Drawing.Size(100, 20);
			this.txtBC.TabIndex = 3;
			this.txtBC.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// txtAB
			// 
			this.txtAB.Location = new System.Drawing.Point(41, 19);
			this.txtAB.MaxLength = 10;
			this.txtAB.Name = "txtAB";
			this.txtAB.Size = new System.Drawing.Size(100, 20);
			this.txtAB.TabIndex = 1;
			this.txtAB.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.lblSideB);
			this.GroupBox2.Controls.Add(this.lblSideA);
			this.GroupBox2.Controls.Add(this.lblSideC);
			this.GroupBox2.Controls.Add(this.txtB);
			this.GroupBox2.Controls.Add(this.txtC);
			this.GroupBox2.Controls.Add(this.txtA);
			this.GroupBox2.Location = new System.Drawing.Point(165, 72);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(145, 105);
			this.GroupBox2.TabIndex = 3;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Angles";
			// 
			// lblSideB
			// 
			this.lblSideB.AutoSize = true;
			this.lblSideB.Font = new System.Drawing.Font("Cambria", 12F);
			this.lblSideB.Location = new System.Drawing.Point(6, 70);
			this.lblSideB.Name = "lblSideB";
			this.lblSideB.Size = new System.Drawing.Size(19, 19);
			this.lblSideB.TabIndex = 4;
			this.lblSideB.Text = "B";
			// 
			// lblSideA
			// 
			this.lblSideA.AutoSize = true;
			this.lblSideA.Font = new System.Drawing.Font("Cambria", 12F);
			this.lblSideA.Location = new System.Drawing.Point(6, 44);
			this.lblSideA.Name = "lblSideA";
			this.lblSideA.Size = new System.Drawing.Size(19, 19);
			this.lblSideA.TabIndex = 2;
			this.lblSideA.Text = "A";
			// 
			// lblSideC
			// 
			this.lblSideC.AutoSize = true;
			this.lblSideC.Font = new System.Drawing.Font("Cambria", 12F);
			this.lblSideC.Location = new System.Drawing.Point(6, 18);
			this.lblSideC.Name = "lblSideC";
			this.lblSideC.Size = new System.Drawing.Size(18, 19);
			this.lblSideC.TabIndex = 0;
			this.lblSideC.Text = "C";
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(30, 71);
			this.txtB.MaxLength = 10;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 20);
			this.txtB.TabIndex = 5;
			this.txtB.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(30, 19);
			this.txtC.MaxLength = 10;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 20);
			this.txtC.TabIndex = 1;
			this.txtC.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(30, 45);
			this.txtA.MaxLength = 10;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 20);
			this.txtA.TabIndex = 3;
			this.txtA.TextChanged += new System.EventHandler(this.txts_TextChanged);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.lblSideAC);
			this.GroupBox1.Controls.Add(this.lblSideBC);
			this.GroupBox1.Controls.Add(this.txtAC);
			this.GroupBox1.Controls.Add(this.txtBC);
			this.GroupBox1.Controls.Add(this.lblSideAB);
			this.GroupBox1.Controls.Add(this.txtAB);
			this.GroupBox1.Location = new System.Drawing.Point(12, 72);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(147, 105);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Sides";
			// 
			// lblSideAC
			// 
			this.lblSideAC.AutoSize = true;
			this.lblSideAC.Font = new System.Drawing.Font("Cambria", 12F);
			this.lblSideAC.Location = new System.Drawing.Point(6, 70);
			this.lblSideAC.Name = "lblSideAC";
			this.lblSideAC.Size = new System.Drawing.Size(28, 19);
			this.lblSideAC.TabIndex = 4;
			this.lblSideAC.Text = "AC";
			// 
			// lblSideBC
			// 
			this.lblSideBC.AutoSize = true;
			this.lblSideBC.Font = new System.Drawing.Font("Cambria", 12F);
			this.lblSideBC.Location = new System.Drawing.Point(5, 44);
			this.lblSideBC.Name = "lblSideBC";
			this.lblSideBC.Size = new System.Drawing.Size(28, 19);
			this.lblSideBC.TabIndex = 2;
			this.lblSideBC.Text = "BC";
			// 
			// lblSideAB
			// 
			this.lblSideAB.AutoSize = true;
			this.lblSideAB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSideAB.Location = new System.Drawing.Point(6, 18);
			this.lblSideAB.Name = "lblSideAB";
			this.lblSideAB.Size = new System.Drawing.Size(29, 19);
			this.lblSideAB.TabIndex = 0;
			this.lblSideAB.Text = "AB";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Enabled = false;
			this.btnCalculate.Location = new System.Drawing.Point(12, 183);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(298, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// PictureBox2
			// 
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(268, 379);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(348, 58);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 47;
			this.PictureBox2.TabStop = false;
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 481);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.chkMedian);
			this.Controls.Add(this.chkAmbigious);
			this.Controls.Add(this.numDigits);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.chkGreek);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Triangle Solver";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numDigits)).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkMedian;
        internal System.Windows.Forms.Label lblP;
        internal System.Windows.Forms.Label lblh1;
        internal System.Windows.Forms.TextBox txtArea;
        internal System.Windows.Forms.TextBox txtPerimeter;
        internal System.Windows.Forms.TextBox txtAltidudeAB;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.CheckBox chkAmbigious;
        internal System.Windows.Forms.NumericUpDown numDigits;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtAltidudeBC;
        internal System.Windows.Forms.Label lblh3;
        internal System.Windows.Forms.Label lblh2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtAltidudeAC;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkGreek;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cmbType;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtAC;
        internal System.Windows.Forms.TextBox txtBC;
        internal System.Windows.Forms.TextBox txtAB;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lblSideB;
        internal System.Windows.Forms.Label lblSideA;
        internal System.Windows.Forms.Label lblSideC;
        internal System.Windows.Forms.TextBox txtB;
        internal System.Windows.Forms.TextBox txtC;
        internal System.Windows.Forms.TextBox txtA;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblSideAC;
        internal System.Windows.Forms.Label lblSideBC;
        internal System.Windows.Forms.Label lblSideAB;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.PictureBox PictureBox2;
    }
}

