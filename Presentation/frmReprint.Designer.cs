namespace Presentation
{
    partial class frmReprint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdFind = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dgvColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.dgvColHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColHVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdFind);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 70);
            this.panel1.TabIndex = 0;
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFind.ForeColor = System.Drawing.Color.White;
            this.cmdFind.Location = new System.Drawing.Point(444, 16);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(73, 30);
            this.cmdFind.TabIndex = 2;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = false;
            this.cmdFind.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // dtp
            // 
            this.dtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp.Location = new System.Drawing.Point(226, 17);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(212, 29);
            this.dtp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick A Date";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 18);
            this.toolStripStatusLabel1.Text = "Total ";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.dgvDetail);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetail.Location = new System.Drawing.Point(0, 327);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(696, 168);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Sale Items";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColItem,
            this.dgvColPrice,
            this.dgvColQty,
            this.dgvColDAmount});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 25);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(690, 140);
            this.dgvDetail.TabIndex = 2;
            // 
            // dgvColItem
            // 
            this.dgvColItem.HeaderText = "Item";
            this.dgvColItem.Name = "dgvColItem";
            this.dgvColItem.ReadOnly = true;
            this.dgvColItem.Width = 150;
            // 
            // dgvColPrice
            // 
            this.dgvColPrice.HeaderText = "Price";
            this.dgvColPrice.Name = "dgvColPrice";
            this.dgvColPrice.ReadOnly = true;
            // 
            // dgvColQty
            // 
            this.dgvColQty.HeaderText = "Qty";
            this.dgvColQty.Name = "dgvColQty";
            this.dgvColQty.ReadOnly = true;
            // 
            // dgvColDAmount
            // 
            this.dgvColDAmount.HeaderText = "Amount";
            this.dgvColDAmount.Name = "dgvColDAmount";
            this.dgvColDAmount.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHeader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vouchers";
            // 
            // dgvHeader
            // 
            this.dgvHeader.AllowUserToAddRows = false;
            this.dgvHeader.AllowUserToDeleteRows = false;
            this.dgvHeader.BackgroundColor = System.Drawing.Color.White;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColHeader,
            this.dgvColHVoucherNo,
            this.dgvColCustomer,
            this.dgvColDate,
            this.dgvColAmount,
            this.dgvColPrint});
            this.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeader.Location = new System.Drawing.Point(3, 25);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.ReadOnly = true;
            this.dgvHeader.Size = new System.Drawing.Size(690, 229);
            this.dgvHeader.TabIndex = 0;
            this.dgvHeader.SelectionChanged += new System.EventHandler(this.dgvHeader_SelectionChanged);
            this.dgvHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeader_CellContentClick);
            // 
            // dgvColHeader
            // 
            this.dgvColHeader.HeaderText = "Header";
            this.dgvColHeader.Name = "dgvColHeader";
            this.dgvColHeader.ReadOnly = true;
            this.dgvColHeader.Visible = false;
            this.dgvColHeader.Width = 130;
            // 
            // dgvColHVoucherNo
            // 
            this.dgvColHVoucherNo.HeaderText = "Invoice No";
            this.dgvColHVoucherNo.Name = "dgvColHVoucherNo";
            this.dgvColHVoucherNo.ReadOnly = true;
            this.dgvColHVoucherNo.Width = 150;
            // 
            // dgvColCustomer
            // 
            this.dgvColCustomer.HeaderText = "Customer";
            this.dgvColCustomer.Name = "dgvColCustomer";
            this.dgvColCustomer.ReadOnly = true;
            // 
            // dgvColDate
            // 
            this.dgvColDate.HeaderText = "Date";
            this.dgvColDate.Name = "dgvColDate";
            this.dgvColDate.ReadOnly = true;
            this.dgvColDate.Width = 150;
            // 
            // dgvColAmount
            // 
            this.dgvColAmount.HeaderText = "Amount";
            this.dgvColAmount.Name = "dgvColAmount";
            this.dgvColAmount.ReadOnly = true;
            // 
            // dgvColPrint
            // 
            this.dgvColPrint.HeaderText = "";
            this.dgvColPrint.Name = "dgvColPrint";
            this.dgvColPrint.ReadOnly = true;
            this.dgvColPrint.Text = "Print";
            this.dgvColPrint.UseColumnTextForButtonValue = true;
            // 
            // frmReprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmReprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColHVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgvColPrint;
    }
}