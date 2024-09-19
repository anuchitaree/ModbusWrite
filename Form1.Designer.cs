namespace ModbusWrite
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
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbQty = new System.Windows.Forms.ComboBox();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnSetVal = new System.Windows.Forms.Button();
            this.textReqVal = new System.Windows.Forms.TextBox();
            this.textRegAdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRegType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(381, 341);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(46, 13);
            this.lb5.TabIndex = 7;
            this.lb5.Text = "400 000";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(381, 314);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(35, 13);
            this.lb4.TabIndex = 7;
            this.lb4.Text = "label7";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(381, 281);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(35, 13);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "label7";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(397, 252);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "label7";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(397, 221);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "label7";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 170);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(330, 361);
            this.dgv.TabIndex = 6;
            // 
            // cmbQty
            // 
            this.cmbQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQty.FormattingEnabled = true;
            this.cmbQty.Items.AddRange(new object[] {
            "10",
            "20"});
            this.cmbQty.Location = new System.Drawing.Point(727, 34);
            this.cmbQty.Name = "cmbQty";
            this.cmbQty.Size = new System.Drawing.Size(100, 21);
            this.cmbQty.TabIndex = 5;
            // 
            // cmbStep
            // 
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStep.Location = new System.Drawing.Point(560, 34);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(100, 21);
            this.cmbStep.TabIndex = 5;
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(439, 31);
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(80, 20);
            this.txtStartAddr.TabIndex = 4;
            this.txtStartAddr.Text = "1";
            this.txtStartAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(634, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.Location = new System.Drawing.Point(833, 26);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(66, 29);
            this.btnDraft.TabIndex = 3;
            this.btnDraft.Text = "Set";
            this.btnDraft.UseVisualStyleBackColor = true;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // btnSetVal
            // 
            this.btnSetVal.Location = new System.Drawing.Point(453, 85);
            this.btnSetVal.Name = "btnSetVal";
            this.btnSetVal.Size = new System.Drawing.Size(66, 29);
            this.btnSetVal.TabIndex = 3;
            this.btnSetVal.Text = "Set";
            this.btnSetVal.UseVisualStyleBackColor = true;
            this.btnSetVal.Click += new System.EventHandler(this.btnSetVal_Click);
            // 
            // textReqVal
            // 
            this.textReqVal.Location = new System.Drawing.Point(342, 94);
            this.textReqVal.Name = "textReqVal";
            this.textReqVal.Size = new System.Drawing.Size(91, 20);
            this.textReqVal.TabIndex = 2;
            // 
            // textRegAdr
            // 
            this.textRegAdr.Location = new System.Drawing.Point(101, 94);
            this.textRegAdr.Name = "textRegAdr";
            this.textRegAdr.Size = new System.Drawing.Size(170, 20);
            this.textRegAdr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Value";
            // 
            // cmbRegType
            // 
            this.cmbRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegType.FormattingEnabled = true;
            this.cmbRegType.Items.AddRange(new object[] {
            "05 (0x05) Single Coil (bit)",
            "15 (0x0F) Discrete Input (bit)",
            "06 (0x06) Holding Register",
            "16 (0x10) Input Registers"});
            this.cmbRegType.Location = new System.Drawing.Point(101, 34);
            this.cmbRegType.Name = "cmbRegType";
            this.cmbRegType.Size = new System.Drawing.Size(170, 21);
            this.cmbRegType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Q\'TY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Register Start Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb5);
            this.groupBox1.Controls.Add(this.lb4);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.cmbQty);
            this.groupBox1.Controls.Add(this.cmbStep);
            this.groupBox1.Controls.Add(this.txtStartAddr);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDraft);
            this.groupBox1.Controls.Add(this.btnSetVal);
            this.groupBox1.Controls.Add(this.textReqVal);
            this.groupBox1.Controls.Add(this.textRegAdr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRegType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 662);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Data";
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(23, 743);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(40, 13);
            this.labStatus.TabIndex = 5;
            this.labStatus.Text = "Status:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(12, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(920, 51);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Modbus TCP Write";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbQty;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnSetVal;
        private System.Windows.Forms.TextBox textReqVal;
        private System.Windows.Forms.TextBox textRegAdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRegType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Button btnStart;
    }
}

