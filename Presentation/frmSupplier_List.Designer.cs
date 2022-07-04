namespace Presentation
{
    partial class frmSupplier_List
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdEdit = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCurrentCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(728, 23);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 18);
            this.toolStripStatusLabel1.Text = "Total Records : ";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 18);
            this.lblTotal.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmdCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 88);
            this.panel1.TabIndex = 6;
            // 
            // cmdEdit
            // 
            this.cmdEdit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.cmdEdit.AutoSize = true;
            this.cmdEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cmdEdit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.cmdEdit.Location = new System.Drawing.Point(102, 59);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(31, 17);
            this.cmdEdit.TabIndex = 5;
            this.cmdEdit.TabStop = true;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdEdit_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(80, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "or";
            // 
            // cmdCreate
            // 
            this.cmdCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cmdCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreate.ForeColor = System.Drawing.Color.White;
            this.cmdCreate.Location = new System.Drawing.Point(8, 53);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(65, 26);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Create";
            this.cmdCreate.UseVisualStyleBackColor = false;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suppliers";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_SupplierID,
            this.dgvCol_Name,
            this.dgvCol_ContactPerson,
            this.dgvCol_Phone1,
            this.dgvCol_Phone2,
            this.dgvCol_Phone3,
            this.dgvCol_Email,
            this.dgvCol_Address,
            this.dgvColCurrentCredit});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 88);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 22;
            this.dgv.Size = new System.Drawing.Size(728, 289);
            this.dgv.TabIndex = 7;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dgvCol_SupplierID
            // 
            this.dgvCol_SupplierID.HeaderText = "SupplierID";
            this.dgvCol_SupplierID.Name = "dgvCol_SupplierID";
            this.dgvCol_SupplierID.ReadOnly = true;
            this.dgvCol_SupplierID.Visible = false;
            // 
            // dgvCol_Name
            // 
            this.dgvCol_Name.HeaderText = "Name";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            // 
            // dgvCol_ContactPerson
            // 
            this.dgvCol_ContactPerson.HeaderText = "Contact Person";
            this.dgvCol_ContactPerson.Name = "dgvCol_ContactPerson";
            this.dgvCol_ContactPerson.ReadOnly = true;
            // 
            // dgvCol_Phone1
            // 
            this.dgvCol_Phone1.HeaderText = "Phone 1";
            this.dgvCol_Phone1.Name = "dgvCol_Phone1";
            this.dgvCol_Phone1.ReadOnly = true;
            // 
            // dgvCol_Phone2
            // 
            this.dgvCol_Phone2.HeaderText = "Phone 2";
            this.dgvCol_Phone2.Name = "dgvCol_Phone2";
            this.dgvCol_Phone2.ReadOnly = true;
            // 
            // dgvCol_Phone3
            // 
            this.dgvCol_Phone3.HeaderText = "Phone 3";
            this.dgvCol_Phone3.Name = "dgvCol_Phone3";
            this.dgvCol_Phone3.ReadOnly = true;
            // 
            // dgvCol_Email
            // 
            this.dgvCol_Email.HeaderText = "Email";
            this.dgvCol_Email.Name = "dgvCol_Email";
            this.dgvCol_Email.ReadOnly = true;
            // 
            // dgvCol_Address
            // 
            this.dgvCol_Address.HeaderText = "Address";
            this.dgvCol_Address.Name = "dgvCol_Address";
            this.dgvCol_Address.ReadOnly = true;
            // 
            // dgvColCurrentCredit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.dgvColCurrentCredit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColCurrentCredit.HeaderText = "Current Credit";
            this.dgvColCurrentCredit.Name = "dgvColCurrentCredit";
            this.dgvColCurrentCredit.ReadOnly = true;
            // 
            // frmSupplier_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 400);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSupplier_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel cmdEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCurrentCredit;
    }
}