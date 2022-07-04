namespace Presentation
{
    partial class frmCustomer_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdEdit = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_TransferPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_NRCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_BankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 23);
            this.statusStrip1.TabIndex = 2;
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdCreate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 88);
            this.panel1.TabIndex = 4;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Records : 1";
            this.label2.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_CustomerID,
            this.dgvCol_Name,
            this.dgvCol_ContactPerson,
            this.dgvCol_Address,
            this.dgvCol_Phone1,
            this.dgvCol_Phone2,
            this.dgvCol_Phone3,
            this.dgvCol_email,
            this.dgvCol_TransferPerson,
            this.dgvCol_NRCNo,
            this.dgvCol_BankAccount,
            this.dgvCol_Bank,
            this.dgvColCurrentCredit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 88);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 22;
            this.dgv.Size = new System.Drawing.Size(727, 372);
            this.dgv.TabIndex = 5;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dgvCol_CustomerID
            // 
            this.dgvCol_CustomerID.DataPropertyName = "CustomerID";
            this.dgvCol_CustomerID.HeaderText = "CustomerID";
            this.dgvCol_CustomerID.Name = "dgvCol_CustomerID";
            this.dgvCol_CustomerID.ReadOnly = true;
            this.dgvCol_CustomerID.Visible = false;
            // 
            // dgvCol_Name
            // 
            this.dgvCol_Name.DataPropertyName = "Name";
            this.dgvCol_Name.HeaderText = "Name";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            // 
            // dgvCol_ContactPerson
            // 
            this.dgvCol_ContactPerson.DataPropertyName = "ContactPerson";
            this.dgvCol_ContactPerson.HeaderText = "Contact Person";
            this.dgvCol_ContactPerson.Name = "dgvCol_ContactPerson";
            this.dgvCol_ContactPerson.ReadOnly = true;
            // 
            // dgvCol_Address
            // 
            this.dgvCol_Address.DataPropertyName = "Address";
            this.dgvCol_Address.HeaderText = "Address";
            this.dgvCol_Address.Name = "dgvCol_Address";
            this.dgvCol_Address.ReadOnly = true;
            // 
            // dgvCol_Phone1
            // 
            this.dgvCol_Phone1.DataPropertyName = "Phone1";
            this.dgvCol_Phone1.HeaderText = "Phone 1";
            this.dgvCol_Phone1.Name = "dgvCol_Phone1";
            this.dgvCol_Phone1.ReadOnly = true;
            // 
            // dgvCol_Phone2
            // 
            this.dgvCol_Phone2.DataPropertyName = "Phone2";
            this.dgvCol_Phone2.HeaderText = "Phone 2";
            this.dgvCol_Phone2.Name = "dgvCol_Phone2";
            this.dgvCol_Phone2.ReadOnly = true;
            // 
            // dgvCol_Phone3
            // 
            this.dgvCol_Phone3.DataPropertyName = "Phone3";
            this.dgvCol_Phone3.HeaderText = "Phone 3";
            this.dgvCol_Phone3.Name = "dgvCol_Phone3";
            this.dgvCol_Phone3.ReadOnly = true;
            // 
            // dgvCol_email
            // 
            this.dgvCol_email.DataPropertyName = "Email";
            this.dgvCol_email.HeaderText = "Email";
            this.dgvCol_email.Name = "dgvCol_email";
            this.dgvCol_email.ReadOnly = true;
            // 
            // dgvCol_TransferPerson
            // 
            this.dgvCol_TransferPerson.DataPropertyName = "TransferPerson";
            this.dgvCol_TransferPerson.HeaderText = "Transfer Person";
            this.dgvCol_TransferPerson.Name = "dgvCol_TransferPerson";
            this.dgvCol_TransferPerson.ReadOnly = true;
            // 
            // dgvCol_NRCNo
            // 
            this.dgvCol_NRCNo.DataPropertyName = "NRCNo";
            this.dgvCol_NRCNo.HeaderText = "NRCNo";
            this.dgvCol_NRCNo.Name = "dgvCol_NRCNo";
            this.dgvCol_NRCNo.ReadOnly = true;
            // 
            // dgvCol_BankAccount
            // 
            this.dgvCol_BankAccount.DataPropertyName = "BankAccount";
            this.dgvCol_BankAccount.HeaderText = "Bank Account";
            this.dgvCol_BankAccount.Name = "dgvCol_BankAccount";
            this.dgvCol_BankAccount.ReadOnly = true;
            // 
            // dgvCol_Bank
            // 
            this.dgvCol_Bank.DataPropertyName = "Bank";
            this.dgvCol_Bank.HeaderText = "Bank";
            this.dgvCol_Bank.Name = "dgvCol_Bank";
            this.dgvCol_Bank.ReadOnly = true;
            // 
            // dgvColCurrentCredit
            // 
            this.dgvColCurrentCredit.DataPropertyName = "CurrentCredit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.dgvColCurrentCredit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColCurrentCredit.HeaderText = "Credit";
            this.dgvColCurrentCredit.Name = "dgvColCurrentCredit";
            this.dgvColCurrentCredit.ReadOnly = true;
            // 
            // frmCustomer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 483);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomer_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_TransferPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_NRCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_BankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCurrentCredit;

    }
}