namespace Presentation
{
    partial class frmStoreTransfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShortCuts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColReprint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStoreTo = new System.Windows.Forms.ComboBox();
            this.cboStoreFrom = new System.Windows.Forms.ComboBox();
            this.dtpOpeningDate = new System.Windows.Forms.DateTimePicker();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv = new Presentation.ArcherDataGridView();
            this.dgvCol_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPriceBaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortCuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtVoucherNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvShortCuts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboStoreTo);
            this.panel1.Controls.Add(this.cboStoreFrom);
            this.panel1.Controls.Add(this.dtpOpeningDate);
            this.panel1.Controls.Add(this.cmdNew);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 639);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date :";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Font = new System.Drawing.Font("Zawgyi-One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Location = new System.Drawing.Point(194, 55);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(174, 42);
            this.txtVoucherNo.TabIndex = 1;
            this.txtVoucherNo.TabStop = false;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlsKeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(842, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Transfer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShortCuts
            // 
            this.dgvShortCuts.AllowUserToAddRows = false;
            this.dgvShortCuts.AllowUserToDeleteRows = false;
            this.dgvShortCuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShortCuts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShortCuts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShortCuts.ColumnHeadersHeight = 45;
            this.dgvShortCuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.dgvColReprint});
            this.dgvShortCuts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShortCuts.Location = new System.Drawing.Point(0, 594);
            this.dgvShortCuts.Name = "dgvShortCuts";
            this.dgvShortCuts.ReadOnly = true;
            this.dgvShortCuts.RowHeadersVisible = false;
            this.dgvShortCuts.Size = new System.Drawing.Size(842, 45);
            this.dgvShortCuts.TabIndex = 19;
            this.dgvShortCuts.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShortCuts_ColumnHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ctrl+N - New Invoice";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F2 - Jump To GRID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "F5 - Save & Print";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F6 - Jump To PAID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "F12 - Admin Mode";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dgvColReprint
            // 
            this.dgvColReprint.HeaderText = "F10 - Reprint Invoice";
            this.dgvColReprint.Name = "dgvColReprint";
            this.dgvColReprint.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "From :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Transfer No :";
            // 
            // cboStoreTo
            // 
            this.cboStoreTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStoreTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStoreTo.DisplayMember = "Name";
            this.cboStoreTo.FormattingEnabled = true;
            this.cboStoreTo.Location = new System.Drawing.Point(574, 104);
            this.cboStoreTo.Name = "cboStoreTo";
            this.cboStoreTo.Size = new System.Drawing.Size(174, 39);
            this.cboStoreTo.TabIndex = 4;
            this.cboStoreTo.TabStop = false;
            this.cboStoreTo.ValueMember = "Store";
            this.cboStoreTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlsKeyDown);
            // 
            // cboStoreFrom
            // 
            this.cboStoreFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStoreFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStoreFrom.DisplayMember = "Name";
            this.cboStoreFrom.FormattingEnabled = true;
            this.cboStoreFrom.Location = new System.Drawing.Point(194, 104);
            this.cboStoreFrom.Name = "cboStoreFrom";
            this.cboStoreFrom.Size = new System.Drawing.Size(174, 39);
            this.cboStoreFrom.TabIndex = 3;
            this.cboStoreFrom.TabStop = false;
            this.cboStoreFrom.ValueMember = "Store";
            this.cboStoreFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlsKeyDown);
            // 
            // dtpOpeningDate
            // 
            this.dtpOpeningDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpOpeningDate.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpeningDate.Location = new System.Drawing.Point(574, 55);
            this.dtpOpeningDate.Name = "dtpOpeningDate";
            this.dtpOpeningDate.Size = new System.Drawing.Size(174, 39);
            this.dtpOpeningDate.TabIndex = 2;
            this.dtpOpeningDate.TabStop = false;
            // 
            // cmdNew
            // 
            this.cmdNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNew.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.ForeColor = System.Drawing.Color.White;
            this.cmdNew.Location = new System.Drawing.Point(492, 536);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(107, 38);
            this.cmdNew.TabIndex = 6;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = false;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Location = new System.Drawing.Point(605, 535);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(105, 38);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(716, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_Item,
            this.dgvColCode,
            this.dgvCol_Name,
            this.dgvCol_Qty,
            this.dgvColUOM,
            this.dgvCol_Price,
            this.dgvColPriceBaseUnit,
            this.dgvCol_Amount});
            this.dgv.GridColor = System.Drawing.Color.Silver;
            this.dgv.Location = new System.Drawing.Point(25, 149);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 25;
            this.dgv.Size = new System.Drawing.Size(798, 370);
            this.dgv.TabIndex = 5;
            this.dgv.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValidated);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
            // 
            // dgvCol_Item
            // 
            this.dgvCol_Item.HeaderText = "Item";
            this.dgvCol_Item.Name = "dgvCol_Item";
            this.dgvCol_Item.Visible = false;
            this.dgvCol_Item.Width = 85;
            // 
            // dgvColCode
            // 
            this.dgvColCode.FillWeight = 152.2843F;
            this.dgvColCode.HeaderText = "Code";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.Width = 70;
            // 
            // dgvCol_Name
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCol_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCol_Name.FillWeight = 49.38853F;
            this.dgvCol_Name.HeaderText = "ပစၥည္းအမည္";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            this.dgvCol_Name.Width = 150;
            // 
            // dgvCol_Qty
            // 
            this.dgvCol_Qty.FillWeight = 61.20817F;
            this.dgvCol_Qty.HeaderText = "အေရ အတြက္";
            this.dgvCol_Qty.Name = "dgvCol_Qty";
            this.dgvCol_Qty.Width = 80;
            // 
            // dgvColUOM
            // 
            this.dgvColUOM.FillWeight = 23.37537F;
            this.dgvColUOM.HeaderText = "ယူနစ္";
            this.dgvColUOM.Name = "dgvColUOM";
            this.dgvColUOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColUOM.Width = 65;
            // 
            // dgvCol_Price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.dgvCol_Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCol_Price.FillWeight = 1F;
            this.dgvCol_Price.HeaderText = "ေစ်းႏႈန္း (လက္ရွိယူနစ္)";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            this.dgvCol_Price.Width = 120;
            // 
            // dgvColPriceBaseUnit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.dgvColPriceBaseUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColPriceBaseUnit.HeaderText = "ေစ်းႏႈန္း (တစ္ခုခ်င္း)";
            this.dgvColPriceBaseUnit.Name = "dgvColPriceBaseUnit";
            this.dgvColPriceBaseUnit.ReadOnly = true;
            // 
            // dgvCol_Amount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.dgvCol_Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCol_Amount.FillWeight = 1F;
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            this.dgvCol_Amount.ReadOnly = true;
            this.dgvCol_Amount.Width = 185;
            // 
            // frmStoreTransfer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(182)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(924, 663);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmStoreTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dranker Liquor - Puggy POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortCuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpOpeningDate;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button button2;
        private ArcherDataGridView dgv;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.DataGridView dgvShortCuts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColReprint;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStoreFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStoreTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPriceBaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;

    }
}