namespace Presentation
{
    partial class frmItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.label1 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.dgvBeginning = new System.Windows.Forms.DataGridView();
            this.dgvColStoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColBasicUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPriceBaseUnit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.llbUOM = new System.Windows.Forms.LinkLabel();
            this.cboBasicUOM = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpUOM = new System.Windows.Forms.TabPage();
            this.dgvUOM = new System.Windows.Forms.DataGridView();
            this.dgvCol_UOMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColisBaseUnit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColQtyBaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPriceBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdEdit = new System.Windows.Forms.LinkLabel();
            this.tc.SuspendLayout();
            this.tpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeginning)).BeginInit();
            this.tpUOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUOM)).BeginInit();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Items";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpInfo);
            this.tc.Controls.Add(this.tpUOM);
            this.tc.Location = new System.Drawing.Point(12, 140);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(796, 307);
            this.tc.TabIndex = 2;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.cmdEdit);
            this.tpInfo.Controls.Add(this.dgvBeginning);
            this.tpInfo.Controls.Add(this.txtPriceBaseUnit);
            this.tpInfo.Controls.Add(this.txtBalance);
            this.tpInfo.Controls.Add(this.llbUOM);
            this.tpInfo.Controls.Add(this.cboBasicUOM);
            this.tpInfo.Controls.Add(this.cboCategory);
            this.tpInfo.Controls.Add(this.txtRemarks);
            this.tpInfo.Controls.Add(this.label3);
            this.tpInfo.Controls.Add(this.label9);
            this.tpInfo.Controls.Add(this.txtDescription);
            this.tpInfo.Controls.Add(this.label6);
            this.tpInfo.Controls.Add(this.label4);
            this.tpInfo.Controls.Add(this.label7);
            this.tpInfo.Location = new System.Drawing.Point(4, 30);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(788, 273);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // dgvBeginning
            // 
            this.dgvBeginning.AllowUserToAddRows = false;
            this.dgvBeginning.AllowUserToDeleteRows = false;
            this.dgvBeginning.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeginning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeginning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColStoreID,
            this.dgvColStore,
            this.dgvColBalance,
            this.dgvColBasicUOM});
            this.dgvBeginning.Location = new System.Drawing.Point(383, 35);
            this.dgvBeginning.Name = "dgvBeginning";
            this.dgvBeginning.RowHeadersVisible = false;
            this.dgvBeginning.Size = new System.Drawing.Size(383, 150);
            this.dgvBeginning.TabIndex = 20;
            // 
            // dgvColStoreID
            // 
            this.dgvColStoreID.HeaderText = "StoreID";
            this.dgvColStoreID.Name = "dgvColStoreID";
            this.dgvColStoreID.Visible = false;
            // 
            // dgvColStore
            // 
            this.dgvColStore.HeaderText = "Store";
            this.dgvColStore.Name = "dgvColStore";
            this.dgvColStore.Width = 150;
            // 
            // dgvColBalance
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.dgvColBalance.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvColBalance.HeaderText = "Balances";
            this.dgvColBalance.Name = "dgvColBalance";
            this.dgvColBalance.Width = 125;
            // 
            // dgvColBasicUOM
            // 
            this.dgvColBasicUOM.HeaderText = "Basic UOM";
            this.dgvColBasicUOM.Name = "dgvColBasicUOM";
            // 
            // txtPriceBaseUnit
            // 
            this.txtPriceBaseUnit.Location = new System.Drawing.Point(141, 225);
            this.txtPriceBaseUnit.Name = "txtPriceBaseUnit";
            this.txtPriceBaseUnit.Size = new System.Drawing.Size(217, 29);
            this.txtPriceBaseUnit.TabIndex = 4;
            this.txtPriceBaseUnit.Text = "0";
            this.txtPriceBaseUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceBaseUnit.Validated += new System.EventHandler(this.txtPriceBaseUnit_Validated);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(383, 191);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(217, 29);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.Visible = false;
            // 
            // llbUOM
            // 
            this.llbUOM.AutoSize = true;
            this.llbUOM.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbUOM.Location = new System.Drawing.Point(11, 194);
            this.llbUOM.Name = "llbUOM";
            this.llbUOM.Size = new System.Drawing.Size(70, 21);
            this.llbUOM.TabIndex = 19;
            this.llbUOM.TabStop = true;
            this.llbUOM.Text = "Basic UOM";
            // 
            // cboBasicUOM
            // 
            this.cboBasicUOM.DisplayMember = "Code";
            this.cboBasicUOM.FormattingEnabled = true;
            this.cboBasicUOM.Location = new System.Drawing.Point(141, 191);
            this.cboBasicUOM.Name = "cboBasicUOM";
            this.cboBasicUOM.Size = new System.Drawing.Size(217, 29);
            this.cboBasicUOM.TabIndex = 3;
            this.cboBasicUOM.ValueMember = "UOM";
            this.cboBasicUOM.SelectedIndexChanged += new System.EventHandler(this.cboBasicUOM_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DisplayMember = "Name";
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(141, 82);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(217, 29);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.ValueMember = "CategoryID";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(141, 116);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(217, 69);
            this.txtRemarks.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remarks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Price / Base Unit";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(141, 18);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 59);
            this.txtDescription.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Beginning Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Category";
            // 
            // tpUOM
            // 
            this.tpUOM.Controls.Add(this.dgvUOM);
            this.tpUOM.Controls.Add(this.label5);
            this.tpUOM.Location = new System.Drawing.Point(4, 22);
            this.tpUOM.Name = "tpUOM";
            this.tpUOM.Padding = new System.Windows.Forms.Padding(3);
            this.tpUOM.Size = new System.Drawing.Size(788, 311);
            this.tpUOM.TabIndex = 1;
            this.tpUOM.Text = "UOM";
            this.tpUOM.UseVisualStyleBackColor = true;
            // 
            // dgvUOM
            // 
            this.dgvUOM.AllowUserToAddRows = false;
            this.dgvUOM.AllowUserToDeleteRows = false;
            this.dgvUOM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_UOMID,
            this.dgvCol_Code,
            this.dgvCol_Description,
            this.dgvColPick,
            this.dgvColisBaseUnit,
            this.dgvColIsDefault,
            this.dgvColQtyBaseUnit,
            this.dgvColPrice,
            this.dgvColPriceBase});
            this.dgvUOM.Location = new System.Drawing.Point(7, 27);
            this.dgvUOM.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUOM.Name = "dgvUOM";
            this.dgvUOM.RowHeadersVisible = false;
            this.dgvUOM.RowHeadersWidth = 22;
            this.dgvUOM.Size = new System.Drawing.Size(774, 269);
            this.dgvUOM.TabIndex = 9;
            this.dgvUOM.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUOM_CellEndEdit);
            // 
            // dgvCol_UOMID
            // 
            this.dgvCol_UOMID.DataPropertyName = "UOMID";
            this.dgvCol_UOMID.HeaderText = "UOMID";
            this.dgvCol_UOMID.Name = "dgvCol_UOMID";
            this.dgvCol_UOMID.Visible = false;
            // 
            // dgvCol_Code
            // 
            this.dgvCol_Code.DataPropertyName = "Code";
            this.dgvCol_Code.HeaderText = "Code";
            this.dgvCol_Code.Name = "dgvCol_Code";
            this.dgvCol_Code.Width = 70;
            // 
            // dgvCol_Description
            // 
            this.dgvCol_Description.DataPropertyName = "Description";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCol_Description.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCol_Description.HeaderText = "Description";
            this.dgvCol_Description.Name = "dgvCol_Description";
            this.dgvCol_Description.Width = 130;
            // 
            // dgvColPick
            // 
            this.dgvColPick.HeaderText = "Pick";
            this.dgvColPick.Name = "dgvColPick";
            this.dgvColPick.Width = 50;
            // 
            // dgvColisBaseUnit
            // 
            this.dgvColisBaseUnit.HeaderText = "BaseUnit";
            this.dgvColisBaseUnit.Name = "dgvColisBaseUnit";
            this.dgvColisBaseUnit.ReadOnly = true;
            this.dgvColisBaseUnit.Width = 70;
            // 
            // dgvColIsDefault
            // 
            this.dgvColIsDefault.HeaderText = "DefaultUnit";
            this.dgvColIsDefault.Name = "dgvColIsDefault";
            // 
            // dgvColQtyBaseUnit
            // 
            this.dgvColQtyBaseUnit.HeaderText = "QtyInBaseUnit";
            this.dgvColQtyBaseUnit.Name = "dgvColQtyBaseUnit";
            // 
            // dgvColPrice
            // 
            this.dgvColPrice.HeaderText = "Price/Current";
            this.dgvColPrice.Name = "dgvColPrice";
            // 
            // dgvColPriceBase
            // 
            dataGridViewCellStyle12.Format = "N2";
            this.dgvColPriceBase.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvColPriceBase.HeaderText = "Price/Base";
            this.dgvColPriceBase.Name = "dgvColPriceBase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alternate UOMs";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.Location = new System.Drawing.Point(336, 53);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(217, 29);
            this.txtCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Code :";
            // 
            // ts
            // 
            this.ts.AutoSize = false;
            this.ts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSave,
            this.toolStripSeparator1,
            this.cmdDelete});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(818, 30);
            this.ts.TabIndex = 15;
            this.ts.Text = "toolStrip1";
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = false;
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(70, 30);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = false;
            this.cmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdDelete.ForeColor = System.Drawing.Color.White;
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(70, 30);
            this.cmdDelete.Text = "Delete";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(336, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 29);
            this.txtName.TabIndex = 1;
            // 
            // cmdEdit
            // 
            this.cmdEdit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.cmdEdit.AutoSize = true;
            this.cmdEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cmdEdit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.cmdEdit.Location = new System.Drawing.Point(735, 15);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(31, 17);
            this.cmdEdit.TabIndex = 21;
            this.cmdEdit.TabStop = true;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Visible = false;
            this.cmdEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdEdit_LinkClicked);
            // 
            // frmItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 459);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Add/Edit";
            this.tc.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeginning)).EndInit();
            this.tpUOM.ResumeLayout(false);
            this.tpUOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUOM)).EndInit();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpUOM;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUOM;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbUOM;
        private System.Windows.Forms.ComboBox cboBasicUOM;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceBaseUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_UOMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColPick;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColisBaseUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColIsDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQtyBaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPriceBase;
        private System.Windows.Forms.DataGridView dgvBeginning;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColBasicUOM;
        private System.Windows.Forms.LinkLabel cmdEdit;

    }
}