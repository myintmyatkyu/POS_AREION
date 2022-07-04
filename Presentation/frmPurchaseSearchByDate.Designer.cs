namespace Presentation
{
    partial class frmPurchaseSearchByDate
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
            this.label13 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label13.Size = new System.Drawing.Size(874, 49);
            this.label13.TabIndex = 34;
            this.label13.Text = "Purchases";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dtpTo);
            this.gb.Controls.Add(this.lblTotalCount);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.cmdShow);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.lblDate);
            this.gb.Controls.Add(this.dtpFrom);
            this.gb.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb.Location = new System.Drawing.Point(0, 49);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(874, 98);
            this.gb.TabIndex = 35;
            this.gb.TabStop = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.Location = new System.Drawing.Point(353, 58);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(245, 29);
            this.dtpTo.TabIndex = 7;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(844, 68);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(17, 21);
            this.lblTotalCount.TabIndex = 6;
            this.lblTotalCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Records :";
            // 
            // cmdShow
            // 
            this.cmdShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShow.ForeColor = System.Drawing.Color.White;
            this.cmdShow.Location = new System.Drawing.Point(613, 53);
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
            this.label3.Location = new System.Drawing.Point(296, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(296, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Location = new System.Drawing.Point(353, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(245, 29);
            this.dtpFrom.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblTotal);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 440);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(874, 50);
            this.panel.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(451, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 21);
            this.lblTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 15);
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
            this.dgvCol_Description,
            this.dgvCol_Date,
            this.dgvCol_Price,
            this.dgvCol_Qty,
            this.dgvCol_Amount,
            this.dgvCol_Discount,
            this.dgvCol_NetAmount});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 147);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.Size = new System.Drawing.Size(874, 293);
            this.dgv.TabIndex = 37;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // dgvCol_Description
            // 
            this.dgvCol_Description.DataPropertyName = "Description";
            this.dgvCol_Description.HeaderText = "Item";
            this.dgvCol_Description.Name = "dgvCol_Description";
            this.dgvCol_Description.ReadOnly = true;
            this.dgvCol_Description.Width = 200;
            // 
            // dgvCol_Date
            // 
            this.dgvCol_Date.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvCol_Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCol_Date.HeaderText = "Date";
            this.dgvCol_Date.Name = "dgvCol_Date";
            this.dgvCol_Date.ReadOnly = true;
            // 
            // dgvCol_Price
            // 
            this.dgvCol_Price.DataPropertyName = "BuyingPrice";
            this.dgvCol_Price.HeaderText = "Price";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            // 
            // dgvCol_Qty
            // 
            this.dgvCol_Qty.DataPropertyName = "Qty";
            this.dgvCol_Qty.HeaderText = "Qty";
            this.dgvCol_Qty.Name = "dgvCol_Qty";
            this.dgvCol_Qty.ReadOnly = true;
            // 
            // dgvCol_Amount
            // 
            this.dgvCol_Amount.DataPropertyName = "Amount";
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            this.dgvCol_Amount.ReadOnly = true;
            // 
            // dgvCol_Discount
            // 
            this.dgvCol_Discount.DataPropertyName = "DiscountAmount";
            this.dgvCol_Discount.HeaderText = "Discount";
            this.dgvCol_Discount.Name = "dgvCol_Discount";
            this.dgvCol_Discount.ReadOnly = true;
            // 
            // dgvCol_NetAmount
            // 
            this.dgvCol_NetAmount.DataPropertyName = "NetAmount";
            this.dgvCol_NetAmount.HeaderText = "NetAmount";
            this.dgvCol_NetAmount.Name = "dgvCol_NetAmount";
            this.dgvCol_NetAmount.ReadOnly = true;
            // 
            // frmPurchaseSearchByDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 490);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchaseSearchByDate";
            this.Text = "Purchases - Search By DATE";
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
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_NetAmount;
    }
}