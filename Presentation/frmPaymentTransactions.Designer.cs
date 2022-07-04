namespace Presentation
{
    partial class frmPaymentTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentCredit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCol_PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_ReceivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_PaidBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_PaymentID,
            this.dgvCol_No,
            this.dgvCol_Amount,
            this.dgvCol_PaidAmount,
            this.dgvCol_Credit,
            this.dgvCol_Date,
            this.dgvCol_ReceivedBy,
            this.dgvCol_PaidBy,
            this.dgvCol_Remarks});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.Size = new System.Drawing.Size(726, 269);
            this.dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Transactions";
            // 
            // lblCurrentCredit
            // 
            this.lblCurrentCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentCredit.AutoSize = true;
            this.lblCurrentCredit.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredit.Location = new System.Drawing.Point(343, 53);
            this.lblCurrentCredit.Name = "lblCurrentCredit";
            this.lblCurrentCredit.Size = new System.Drawing.Size(57, 20);
            this.lblCurrentCredit.TabIndex = 7;
            this.lblCurrentCredit.Text = "737000";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Credit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCurrentCredit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(343, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "IT Current";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // dgvCol_PaymentID
            // 
            this.dgvCol_PaymentID.HeaderText = "PaymentID";
            this.dgvCol_PaymentID.Name = "dgvCol_PaymentID";
            this.dgvCol_PaymentID.ReadOnly = true;
            this.dgvCol_PaymentID.Visible = false;
            // 
            // dgvCol_No
            // 
            this.dgvCol_No.HeaderText = "Voucher No";
            this.dgvCol_No.Name = "dgvCol_No";
            this.dgvCol_No.ReadOnly = true;
            this.dgvCol_No.Width = 91;
            // 
            // dgvCol_Amount
            // 
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            this.dgvCol_Amount.ReadOnly = true;
            this.dgvCol_Amount.Width = 78;
            // 
            // dgvCol_PaidAmount
            // 
            this.dgvCol_PaidAmount.HeaderText = "Paid Amount";
            this.dgvCol_PaidAmount.Name = "dgvCol_PaidAmount";
            this.dgvCol_PaidAmount.ReadOnly = true;
            this.dgvCol_PaidAmount.Width = 96;
            // 
            // dgvCol_Credit
            // 
            this.dgvCol_Credit.HeaderText = "Credit";
            this.dgvCol_Credit.Name = "dgvCol_Credit";
            this.dgvCol_Credit.ReadOnly = true;
            this.dgvCol_Credit.Width = 66;
            // 
            // dgvCol_Date
            // 
            dataGridViewCellStyle5.Format = "dd/MMM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvCol_Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCol_Date.HeaderText = "Date";
            this.dgvCol_Date.Name = "dgvCol_Date";
            this.dgvCol_Date.ReadOnly = true;
            this.dgvCol_Date.Width = 60;
            // 
            // dgvCol_ReceivedBy
            // 
            this.dgvCol_ReceivedBy.HeaderText = "Received By";
            this.dgvCol_ReceivedBy.Name = "dgvCol_ReceivedBy";
            this.dgvCol_ReceivedBy.ReadOnly = true;
            this.dgvCol_ReceivedBy.Width = 92;
            // 
            // dgvCol_PaidBy
            // 
            this.dgvCol_PaidBy.HeaderText = "Paid By";
            this.dgvCol_PaidBy.Name = "dgvCol_PaidBy";
            this.dgvCol_PaidBy.ReadOnly = true;
            this.dgvCol_PaidBy.Width = 56;
            // 
            // dgvCol_Remarks
            // 
            this.dgvCol_Remarks.HeaderText = "Remarks";
            this.dgvCol_Remarks.Name = "dgvCol_Remarks";
            this.dgvCol_Remarks.ReadOnly = true;
            this.dgvCol_Remarks.Width = 79;
            // 
            // frmPaymentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmPaymentTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ReceivedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_PaidBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Remarks;
    }
}