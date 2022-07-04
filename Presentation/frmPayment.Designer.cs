namespace Presentation
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPaidBy = new System.Windows.Forms.TextBox();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOpeningDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 296);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(229, 72);
            this.txtRemarks.TabIndex = 7;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(101, 144);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(229, 27);
            this.txtCredit.TabIndex = 3;
            this.txtCredit.TabStop = false;
            this.txtCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(101, 106);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(229, 27);
            this.txtPaidAmount.TabIndex = 2;
            this.txtPaidAmount.Validated += new System.EventHandler(this.txtPaidAmount_Validated);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(101, 64);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(229, 27);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TabStop = false;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(101, 30);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(229, 27);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNoKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remarks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Paid Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dtpDate);
            this.gb.Controls.Add(this.txtRemarks);
            this.gb.Controls.Add(this.txtCredit);
            this.gb.Controls.Add(this.txtPaidBy);
            this.gb.Controls.Add(this.txtReceivedBy);
            this.gb.Controls.Add(this.txtPaidAmount);
            this.gb.Controls.Add(this.txtAmount);
            this.gb.Controls.Add(this.txtVoucherNo);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.label9);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.label10);
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label1);
            this.gb.Location = new System.Drawing.Point(12, 37);
            this.gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gb.Size = new System.Drawing.Size(351, 381);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(101, 180);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(229, 27);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtPaidBy
            // 
            this.txtPaidBy.Location = new System.Drawing.Point(101, 258);
            this.txtPaidBy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.Size = new System.Drawing.Size(229, 27);
            this.txtPaidBy.TabIndex = 6;
            this.txtPaidBy.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Location = new System.Drawing.Point(101, 220);
            this.txtReceivedBy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(229, 27);
            this.txtReceivedBy.TabIndex = 5;
            this.txtReceivedBy.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtReceivedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Paid By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Received By";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Voucher No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Payment";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Location = new System.Drawing.Point(212, 429);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 31);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(290, 429);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(73, 31);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(392, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 295);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Detail Records ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_No,
            this.dgvCol_Code,
            this.dgvCol_Name,
            this.dgvCol_UOM,
            this.dgvCol_Price,
            this.dgvCol_Qty,
            this.dgvCol_Amount,
            this.dgvCol_Date});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.Size = new System.Drawing.Size(620, 269);
            this.dgv.TabIndex = 0;
            // 
            // dgvCol_No
            // 
            this.dgvCol_No.HeaderText = "No";
            this.dgvCol_No.Name = "dgvCol_No";
            this.dgvCol_No.ReadOnly = true;
            this.dgvCol_No.Width = 50;
            // 
            // dgvCol_Code
            // 
            this.dgvCol_Code.HeaderText = "Code";
            this.dgvCol_Code.Name = "dgvCol_Code";
            this.dgvCol_Code.ReadOnly = true;
            this.dgvCol_Code.Width = 70;
            // 
            // dgvCol_Name
            // 
            this.dgvCol_Name.HeaderText = "Name";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            // 
            // dgvCol_UOM
            // 
            this.dgvCol_UOM.HeaderText = "Category";
            this.dgvCol_UOM.Name = "dgvCol_UOM";
            this.dgvCol_UOM.ReadOnly = true;
            this.dgvCol_UOM.Width = 80;
            // 
            // dgvCol_Price
            // 
            this.dgvCol_Price.HeaderText = "Price";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            // 
            // dgvCol_Qty
            // 
            this.dgvCol_Qty.HeaderText = "Qty";
            this.dgvCol_Qty.Name = "dgvCol_Qty";
            this.dgvCol_Qty.ReadOnly = true;
            this.dgvCol_Qty.Width = 50;
            // 
            // dgvCol_Amount
            // 
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            this.dgvCol_Amount.ReadOnly = true;
            // 
            // dgvCol_Date
            // 
            dataGridViewCellStyle2.Format = "dd/MMM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvCol_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_Date.HeaderText = "Date";
            this.dgvCol_Date.Name = "dgvCol_Date";
            this.dgvCol_Date.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblOpeningDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblVoucherNo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 124);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(330, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Open";
            // 
            // lblOpeningDate
            // 
            this.lblOpeningDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpeningDate.AutoSize = true;
            this.lblOpeningDate.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningDate.Location = new System.Drawing.Point(330, 67);
            this.lblOpeningDate.Name = "lblOpeningDate";
            this.lblOpeningDate.Size = new System.Drawing.Size(81, 20);
            this.lblOpeningDate.TabIndex = 7;
            this.lblOpeningDate.Text = "3-Mar-2014";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherNo.Location = new System.Drawing.Point(330, 43);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(125, 20);
            this.lblVoucherNo.TabIndex = 8;
            this.lblVoucherNo.Text = "2014-March 0001 ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Opening Date";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Voucher No";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(330, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "IT Current";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Customer Name";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpeningDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Date;
        private System.Windows.Forms.TextBox txtPaidBy;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label10;
    }
}