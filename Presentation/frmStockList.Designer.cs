namespace Presentation
{
    partial class frmStockList
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
            this.label13 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb.SuspendLayout();
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
            this.label13.Size = new System.Drawing.Size(816, 49);
            this.label13.TabIndex = 0;
            this.label13.Text = "Stock";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cboItemCode);
            this.gb.Controls.Add(this.cboItemName);
            this.gb.Controls.Add(this.lblTotalCount);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.cmdClear);
            this.gb.Controls.Add(this.label4);
            this.gb.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb.Location = new System.Drawing.Point(0, 49);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(816, 105);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            // 
            // cboItemCode
            // 
            this.cboItemCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItemCode.DisplayMember = "Code";
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(324, 26);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(245, 29);
            this.cboItemCode.TabIndex = 7;
            this.cboItemCode.ValueMember = "Item";
            this.cboItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboItemCode_KeyDown);
            // 
            // cboItemName
            // 
            this.cboItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItemName.DisplayMember = "Description";
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(324, 61);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(245, 29);
            this.cboItemName.TabIndex = 1;
            this.cboItemName.ValueMember = "Item";
            this.cboItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboItemName_KeyDown);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(787, 73);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(17, 21);
            this.lblTotalCount.TabIndex = 6;
            this.lblTotalCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Records :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.ForeColor = System.Drawing.Color.White;
            this.cmdClear.Location = new System.Drawing.Point(575, 59);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(73, 30);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "CODE";
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 466);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(816, 50);
            this.panel.TabIndex = 35;
            this.panel.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_ItemID,
            this.dgvCol_Code,
            this.dgvCol_Description,
            this.dgvCol_Category,
            this.dgvCol_Price,
            this.dgvCol_Remarks,
            this.dgvCol_CurrentBalance});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 154);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 22;
            this.dgv.Size = new System.Drawing.Size(816, 312);
            this.dgv.TabIndex = 36;
            // 
            // dgvCol_ItemID
            // 
            this.dgvCol_ItemID.DataPropertyName = "ItemID";
            this.dgvCol_ItemID.HeaderText = "ItemID";
            this.dgvCol_ItemID.Name = "dgvCol_ItemID";
            this.dgvCol_ItemID.ReadOnly = true;
            this.dgvCol_ItemID.Visible = false;
            // 
            // dgvCol_Code
            // 
            this.dgvCol_Code.DataPropertyName = "Code";
            this.dgvCol_Code.HeaderText = "Code";
            this.dgvCol_Code.Name = "dgvCol_Code";
            this.dgvCol_Code.ReadOnly = true;
            // 
            // dgvCol_Description
            // 
            this.dgvCol_Description.DataPropertyName = "Description";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCol_Description.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_Description.HeaderText = "Description";
            this.dgvCol_Description.Name = "dgvCol_Description";
            this.dgvCol_Description.ReadOnly = true;
            // 
            // dgvCol_Category
            // 
            this.dgvCol_Category.DataPropertyName = "Category";
            this.dgvCol_Category.HeaderText = "Category";
            this.dgvCol_Category.Name = "dgvCol_Category";
            this.dgvCol_Category.ReadOnly = true;
            // 
            // dgvCol_Price
            // 
            this.dgvCol_Price.DataPropertyName = "Price";
            this.dgvCol_Price.HeaderText = "Price";
            this.dgvCol_Price.Name = "dgvCol_Price";
            this.dgvCol_Price.ReadOnly = true;
            // 
            // dgvCol_Remarks
            // 
            this.dgvCol_Remarks.DataPropertyName = "Remark";
            this.dgvCol_Remarks.HeaderText = "Remarks";
            this.dgvCol_Remarks.Name = "dgvCol_Remarks";
            this.dgvCol_Remarks.ReadOnly = true;
            // 
            // dgvCol_CurrentBalance
            // 
            this.dgvCol_CurrentBalance.HeaderText = "Current Balance";
            this.dgvCol_CurrentBalance.Name = "dgvCol_CurrentBalance";
            this.dgvCol_CurrentBalance.ReadOnly = true;
            // 
            // frmStockList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStockList";
            this.Text = "frmStockList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CurrentBalance;
        private System.Windows.Forms.ComboBox cboItemCode;
    }
}