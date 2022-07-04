namespace Presentation
{
    partial class frmPurchaseDetailList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOpeningDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPriceBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalAmount);
            this.groupBox2.Controls.Add(this.lblOpeningDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblVoucherNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(368, 95);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(33, 20);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "N/A";
            // 
            // lblOpeningDate
            // 
            this.lblOpeningDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpeningDate.AutoSize = true;
            this.lblOpeningDate.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningDate.Location = new System.Drawing.Point(368, 71);
            this.lblOpeningDate.Name = "lblOpeningDate";
            this.lblOpeningDate.Size = new System.Drawing.Size(33, 20);
            this.lblOpeningDate.TabIndex = 7;
            this.lblOpeningDate.Text = "N/A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Net Amount";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherNo.Location = new System.Drawing.Point(368, 47);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(33, 20);
            this.lblVoucherNo.TabIndex = 8;
            this.lblVoucherNo.Text = "N/A";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Voucher No";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(368, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "N/A";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Supplier Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Detail Records";
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
            this.dgvCol_Qty,
            this.dgvColUOM,
            this.dgvCol_Price,
            this.dgvColPriceBase,
            this.dgvCol_NetAmount});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 21);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.Size = new System.Drawing.Size(798, 297);
            this.dgv.TabIndex = 0;
            // 
            // dgvCol_No
            // 
            this.dgvCol_No.HeaderText = "No";
            this.dgvCol_No.Name = "dgvCol_No";
            this.dgvCol_No.ReadOnly = true;
            this.dgvCol_No.Width = 70;
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
            // dgvCol_Qty
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCol_Qty.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCol_Qty.HeaderText = "Qty";
            this.dgvCol_Qty.Name = "dgvCol_Qty";
            this.dgvCol_Qty.ReadOnly = true;
            this.dgvCol_Qty.Width = 71;
            // 
            // dgvColUOM
            // 
            this.dgvColUOM.HeaderText = "UOM";
            this.dgvColUOM.Name = "dgvColUOM";
            this.dgvColUOM.ReadOnly = true;
            // 
            // dgvCol_Price
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvCol_Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_Price.HeaderText = "Price/Current";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            // 
            // dgvColPriceBase
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.dgvColPriceBase.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColPriceBase.HeaderText = "Price/Base";
            this.dgvColPriceBase.Name = "dgvColPriceBase";
            this.dgvColPriceBase.ReadOnly = true;
            this.dgvColPriceBase.Width = 80;
            // 
            // dgvCol_NetAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.dgvCol_NetAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCol_NetAmount.HeaderText = "Net Amount";
            this.dgvCol_NetAmount.Name = "dgvCol_NetAmount";
            this.dgvCol_NetAmount.ReadOnly = true;
            this.dgvCol_NetAmount.Width = 150;
            // 
            // frmPurchaseDetailList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPurchaseDetailList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Detail";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpeningDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPriceBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_NetAmount;
    }
}