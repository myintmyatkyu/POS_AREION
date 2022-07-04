namespace Presentation
{
    partial class frmStoreTransferList
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dgvColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColQtyBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdReset = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.dgvColHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColHVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(305, 54);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(116, 23);
            this.dtpFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.dgvDetail);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetail.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(0, 190);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(767, 300);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Details";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColItem,
            this.dgvColUOM,
            this.dgvColQty,
            this.dgvColQtyBase});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 25);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(761, 272);
            this.dgvDetail.TabIndex = 2;
            // 
            // dgvColItem
            // 
            this.dgvColItem.HeaderText = "Item";
            this.dgvColItem.Name = "dgvColItem";
            this.dgvColItem.ReadOnly = true;
            this.dgvColItem.Width = 150;
            // 
            // dgvColUOM
            // 
            this.dgvColUOM.HeaderText = "UOM";
            this.dgvColUOM.Name = "dgvColUOM";
            this.dgvColUOM.ReadOnly = true;
            // 
            // dgvColQty
            // 
            this.dgvColQty.HeaderText = "Qty";
            this.dgvColQty.Name = "dgvColQty";
            this.dgvColQty.ReadOnly = true;
            // 
            // dgvColQtyBase
            // 
            this.dgvColQtyBase.HeaderText = "Qty Base Unit";
            this.dgvColQtyBase.Name = "dgvColQtyBase";
            this.dgvColQtyBase.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdReset);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.cmdFind);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 116);
            this.panel2.TabIndex = 4;
            // 
            // cmdReset
            // 
            this.cmdReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.ForeColor = System.Drawing.Color.White;
            this.cmdReset.Location = new System.Drawing.Point(498, 77);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(65, 26);
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(305, 80);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(116, 23);
            this.dtpTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "To :";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(660, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Records : 1";
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cmdFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFind.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFind.ForeColor = System.Drawing.Color.White;
            this.cmdFind.Location = new System.Drawing.Point(427, 77);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(65, 26);
            this.cmdFind.TabIndex = 1;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = false;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Transfer List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHeader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Transfer Headers";
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
            this.dgvColFrom,
            this.dgvColTo,
            this.dgvColDate});
            this.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeader.Location = new System.Drawing.Point(3, 25);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.ReadOnly = true;
            this.dgvHeader.Size = new System.Drawing.Size(761, 46);
            this.dgvHeader.TabIndex = 0;
            this.dgvHeader.SelectionChanged += new System.EventHandler(this.dgvHeader_SelectionChanged);
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
            this.dgvColHVoucherNo.HeaderText = "STN";
            this.dgvColHVoucherNo.Name = "dgvColHVoucherNo";
            this.dgvColHVoucherNo.ReadOnly = true;
            this.dgvColHVoucherNo.Width = 150;
            // 
            // dgvColFrom
            // 
            this.dgvColFrom.HeaderText = "From";
            this.dgvColFrom.Name = "dgvColFrom";
            this.dgvColFrom.ReadOnly = true;
            // 
            // dgvColTo
            // 
            this.dgvColTo.HeaderText = "To";
            this.dgvColTo.Name = "dgvColTo";
            this.dgvColTo.ReadOnly = true;
            // 
            // dgvColDate
            // 
            this.dgvColDate.HeaderText = "Date";
            this.dgvColDate.Name = "dgvColDate";
            this.dgvColDate.ReadOnly = true;
            this.dgvColDate.Width = 150;
            // 
            // frmStoreTransferList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmStoreTransferList";
            this.Text = "Store Trasfer List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColHVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQtyBase;
    }
}