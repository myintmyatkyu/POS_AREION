namespace Presentation
{
    partial class frmSaleByItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvColInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Zawgyi-One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(861, 49);
            this.label13.TabIndex = 32;
            this.label13.Text = "Sales Report";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cboItemCode);
            this.gb.Controls.Add(this.dtpTo);
            this.gb.Controls.Add(this.lblTotalCount);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.cmdShow);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.lblDate);
            this.gb.Controls.Add(this.dtpFrom);
            this.gb.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb.Location = new System.Drawing.Point(0, 49);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(861, 132);
            this.gb.TabIndex = 33;
            this.gb.TabStop = false;
            // 
            // cboItemCode
            // 
            this.cboItemCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItemCode.DisplayMember = "Name";
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(346, 21);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(245, 28);
            this.cboItemCode.TabIndex = 8;
            this.cboItemCode.ValueMember = "ItemID";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.Location = new System.Drawing.Point(346, 90);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(245, 27);
            this.dtpTo.TabIndex = 7;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(833, 97);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(16, 20);
            this.lblTotalCount.TabIndex = 6;
            this.lblTotalCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Records :";
            // 
            // cmdShow
            // 
            this.cmdShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShow.ForeColor = System.Drawing.Color.White;
            this.cmdShow.Location = new System.Drawing.Point(606, 85);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(73, 30);
            this.cmdShow.TabIndex = 4;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = false;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Item";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(289, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Location = new System.Drawing.Point(346, 55);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(245, 27);
            this.dtpFrom.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblAvgPrice);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.lblTotalQty);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.lblTotal);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 439);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(861, 50);
            this.panel.TabIndex = 34;
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.Location = new System.Drawing.Point(464, 13);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(18, 21);
            this.lblAvgPrice.TabIndex = 7;
            this.lblAvgPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Price :";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(262, 13);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(18, 21);
            this.lblTotalQty.TabIndex = 7;
            this.lblTotalQty.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Qty :";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(640, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Amount :";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColInvoice,
            this.dgvCol_Date,
            this.dgvColCustomer,
            this.dgvCol_Qty,
            this.dgvColUOM,
            this.dgvCol_Price,
            this.dgvCol_Amount});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 181);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.Size = new System.Drawing.Size(861, 258);
            this.dgv.TabIndex = 35;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // dgvColInvoice
            // 
            this.dgvColInvoice.HeaderText = "InvoiceNo";
            this.dgvColInvoice.Name = "dgvColInvoice";
            this.dgvColInvoice.ReadOnly = true;
            // 
            // dgvCol_Date
            // 
            this.dgvCol_Date.DataPropertyName = "OpeningDate";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvCol_Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCol_Date.HeaderText = "Date";
            this.dgvCol_Date.Name = "dgvCol_Date";
            this.dgvCol_Date.ReadOnly = true;
            // 
            // dgvColCustomer
            // 
            this.dgvColCustomer.HeaderText = "Customer";
            this.dgvColCustomer.Name = "dgvColCustomer";
            this.dgvColCustomer.ReadOnly = true;
            // 
            // dgvCol_Qty
            // 
            this.dgvCol_Qty.DataPropertyName = "Qty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCol_Qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCol_Qty.HeaderText = "Qty";
            this.dgvCol_Qty.Name = "dgvCol_Qty";
            this.dgvCol_Qty.ReadOnly = true;
            // 
            // dgvColUOM
            // 
            this.dgvColUOM.HeaderText = "UOM";
            this.dgvColUOM.Name = "dgvColUOM";
            this.dgvColUOM.ReadOnly = true;
            // 
            // dgvCol_Price
            // 
            this.dgvCol_Price.DataPropertyName = "Price";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.dgvCol_Price.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCol_Price.HeaderText = "Price";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            // 
            // dgvCol_Amount
            // 
            this.dgvCol_Amount.DataPropertyName = "NetAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.dgvCol_Amount.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            this.dgvCol_Amount.ReadOnly = true;
            // 
            // frmSaleByItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 489);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSaleByItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
    }
}