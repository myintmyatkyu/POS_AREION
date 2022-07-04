namespace Presentation
{
    partial class frmPurchase_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSuppliers = new System.Windows.Forms.TextBox();
            this.gbSupplier = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPurchase = new System.Windows.Forms.Button();
            this.cmdMakePayment = new System.Windows.Forms.Button();
            this.cmdEditSupplier = new System.Windows.Forms.Button();
            this.cmdDiscount = new System.Windows.Forms.Button();
            this.lblCurrentCredit = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCurrentDebit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.dgvCol_SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvCol_CurrentCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_CurrentDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdNewSupplier = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalSummary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.dgvCol_VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCol_Payment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.gbSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSuppliers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 42);
            this.panel1.TabIndex = 0;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliers.ForeColor = System.Drawing.Color.DimGray;
            this.txtSuppliers.Location = new System.Drawing.Point(12, 12);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(228, 20);
            this.txtSuppliers.TabIndex = 0;
            this.txtSuppliers.Text = "Type to Search Supplier";
            this.txtSuppliers.TextChanged += new System.EventHandler(this.txtSuppliers_TextChanged);
            // 
            // gbSupplier
            // 
            this.gbSupplier.Controls.Add(this.groupBox1);
            this.gbSupplier.Controls.Add(this.cmdDiscount);
            this.gbSupplier.Controls.Add(this.lblCurrentCredit);
            this.gbSupplier.Controls.Add(this.button2);
            this.gbSupplier.Controls.Add(this.lblCurrentDebit);
            this.gbSupplier.Controls.Add(this.label9);
            this.gbSupplier.Controls.Add(this.label7);
            this.gbSupplier.Controls.Add(this.lblAddress);
            this.gbSupplier.Controls.Add(this.label11);
            this.gbSupplier.Controls.Add(this.lblPhone);
            this.gbSupplier.Controls.Add(this.label5);
            this.gbSupplier.Controls.Add(this.lblContact);
            this.gbSupplier.Controls.Add(this.label3);
            this.gbSupplier.Controls.Add(this.lblName);
            this.gbSupplier.Controls.Add(this.label1);
            this.gbSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSupplier.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplier.Location = new System.Drawing.Point(0, 0);
            this.gbSupplier.Name = "gbSupplier";
            this.gbSupplier.Size = new System.Drawing.Size(787, 161);
            this.gbSupplier.TabIndex = 0;
            this.gbSupplier.TabStop = false;
            this.gbSupplier.Text = "Supplier Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdPurchase);
            this.groupBox1.Controls.Add(this.cmdMakePayment);
            this.groupBox1.Controls.Add(this.cmdEditSupplier);
            this.groupBox1.Location = new System.Drawing.Point(588, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Box";
            // 
            // cmdPurchase
            // 
            this.cmdPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPurchase.ForeColor = System.Drawing.Color.White;
            this.cmdPurchase.Location = new System.Drawing.Point(7, 19);
            this.cmdPurchase.Name = "cmdPurchase";
            this.cmdPurchase.Size = new System.Drawing.Size(172, 27);
            this.cmdPurchase.TabIndex = 4;
            this.cmdPurchase.Text = "New Purchase";
            this.cmdPurchase.UseVisualStyleBackColor = false;
            this.cmdPurchase.Click += new System.EventHandler(this.cmdPurchase_Click);
            // 
            // cmdMakePayment
            // 
            this.cmdMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMakePayment.ForeColor = System.Drawing.Color.White;
            this.cmdMakePayment.Location = new System.Drawing.Point(7, 85);
            this.cmdMakePayment.Name = "cmdMakePayment";
            this.cmdMakePayment.Size = new System.Drawing.Size(172, 27);
            this.cmdMakePayment.TabIndex = 4;
            this.cmdMakePayment.Text = "Make Payment";
            this.cmdMakePayment.UseVisualStyleBackColor = false;
            this.cmdMakePayment.Click += new System.EventHandler(this.cmdMakePayment_Click);
            // 
            // cmdEditSupplier
            // 
            this.cmdEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditSupplier.ForeColor = System.Drawing.Color.White;
            this.cmdEditSupplier.Location = new System.Drawing.Point(7, 52);
            this.cmdEditSupplier.Name = "cmdEditSupplier";
            this.cmdEditSupplier.Size = new System.Drawing.Size(172, 27);
            this.cmdEditSupplier.TabIndex = 4;
            this.cmdEditSupplier.Text = "Edit Supplier Information";
            this.cmdEditSupplier.UseVisualStyleBackColor = false;
            this.cmdEditSupplier.Click += new System.EventHandler(this.cmdEditSupplier_Click);
            // 
            // cmdDiscount
            // 
            this.cmdDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDiscount.ForeColor = System.Drawing.Color.White;
            this.cmdDiscount.Location = new System.Drawing.Point(361, 92);
            this.cmdDiscount.Name = "cmdDiscount";
            this.cmdDiscount.Size = new System.Drawing.Size(172, 27);
            this.cmdDiscount.TabIndex = 4;
            this.cmdDiscount.Text = "Supplier Discount";
            this.cmdDiscount.UseVisualStyleBackColor = false;
            this.cmdDiscount.Visible = false;
            this.cmdDiscount.Click += new System.EventHandler(this.cmdDiscount_Click);
            // 
            // lblCurrentCredit
            // 
            this.lblCurrentCredit.AutoSize = true;
            this.lblCurrentCredit.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredit.Location = new System.Drawing.Point(112, 102);
            this.lblCurrentCredit.Name = "lblCurrentCredit";
            this.lblCurrentCredit.Size = new System.Drawing.Size(17, 20);
            this.lblCurrentCredit.TabIndex = 2;
            this.lblCurrentCredit.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(361, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Payment Transactions";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // lblCurrentDebit
            // 
            this.lblCurrentDebit.AutoSize = true;
            this.lblCurrentDebit.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDebit.Location = new System.Drawing.Point(112, 75);
            this.lblCurrentDebit.Name = "lblCurrentDebit";
            this.lblCurrentDebit.Size = new System.Drawing.Size(17, 20);
            this.lblCurrentDebit.TabIndex = 2;
            this.lblCurrentDebit.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Current Credit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Debit";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(338, 49);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(195, 66);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(338, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(33, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone No";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(112, 49);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(33, 20);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(112, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSupplier);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.gbSupplier);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 498);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_SupplierID,
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
            this.dgvCol_CurrentCredit,
            this.dgvCol_CurrentDebit});
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 42);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowHeadersWidth = 22;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(251, 424);
            this.dgvSupplier.TabIndex = 4;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            this.dgvSupplier.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSupplier_DataBindingComplete);
            // 
            // dgvCol_SupplierID
            // 
            this.dgvCol_SupplierID.DataPropertyName = "SupplierID";
            this.dgvCol_SupplierID.HeaderText = "SupplierID";
            this.dgvCol_SupplierID.Name = "dgvCol_SupplierID";
            this.dgvCol_SupplierID.ReadOnly = true;
            this.dgvCol_SupplierID.Visible = false;
            // 
            // dgvCol_Name
            // 
            this.dgvCol_Name.DataPropertyName = "Name";
            this.dgvCol_Name.HeaderText = "Suppliers";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            // 
            // dgvCol_ContactPerson
            // 
            this.dgvCol_ContactPerson.DataPropertyName = "ContactPerson";
            this.dgvCol_ContactPerson.HeaderText = "Contact Person";
            this.dgvCol_ContactPerson.Name = "dgvCol_ContactPerson";
            this.dgvCol_ContactPerson.ReadOnly = true;
            this.dgvCol_ContactPerson.Visible = false;
            // 
            // dgvCol_Address
            // 
            this.dgvCol_Address.DataPropertyName = "Address";
            this.dgvCol_Address.HeaderText = "Address";
            this.dgvCol_Address.Name = "dgvCol_Address";
            this.dgvCol_Address.ReadOnly = true;
            this.dgvCol_Address.Visible = false;
            // 
            // dgvCol_Phone1
            // 
            this.dgvCol_Phone1.DataPropertyName = "Phone1";
            this.dgvCol_Phone1.HeaderText = "Phone 1";
            this.dgvCol_Phone1.Name = "dgvCol_Phone1";
            this.dgvCol_Phone1.ReadOnly = true;
            this.dgvCol_Phone1.Visible = false;
            // 
            // dgvCol_Phone2
            // 
            this.dgvCol_Phone2.DataPropertyName = "Phone2";
            this.dgvCol_Phone2.HeaderText = "Phone 2";
            this.dgvCol_Phone2.Name = "dgvCol_Phone2";
            this.dgvCol_Phone2.ReadOnly = true;
            this.dgvCol_Phone2.Visible = false;
            // 
            // dgvCol_Phone3
            // 
            this.dgvCol_Phone3.DataPropertyName = "Phone3";
            this.dgvCol_Phone3.HeaderText = "Phone 3";
            this.dgvCol_Phone3.Name = "dgvCol_Phone3";
            this.dgvCol_Phone3.ReadOnly = true;
            this.dgvCol_Phone3.Visible = false;
            // 
            // dgvCol_email
            // 
            this.dgvCol_email.DataPropertyName = "Email";
            this.dgvCol_email.HeaderText = "Email";
            this.dgvCol_email.Name = "dgvCol_email";
            this.dgvCol_email.ReadOnly = true;
            this.dgvCol_email.Visible = false;
            // 
            // dgvCol_TransferPerson
            // 
            this.dgvCol_TransferPerson.DataPropertyName = "TransferPerson";
            this.dgvCol_TransferPerson.HeaderText = "Transfer Person";
            this.dgvCol_TransferPerson.Name = "dgvCol_TransferPerson";
            this.dgvCol_TransferPerson.ReadOnly = true;
            this.dgvCol_TransferPerson.Visible = false;
            // 
            // dgvCol_NRCNo
            // 
            this.dgvCol_NRCNo.DataPropertyName = "NRCNo";
            this.dgvCol_NRCNo.HeaderText = "NRCNo";
            this.dgvCol_NRCNo.Name = "dgvCol_NRCNo";
            this.dgvCol_NRCNo.ReadOnly = true;
            this.dgvCol_NRCNo.Visible = false;
            // 
            // dgvCol_BankAccount
            // 
            this.dgvCol_BankAccount.DataPropertyName = "BankAccount";
            this.dgvCol_BankAccount.HeaderText = "Bank Account";
            this.dgvCol_BankAccount.Name = "dgvCol_BankAccount";
            this.dgvCol_BankAccount.ReadOnly = true;
            this.dgvCol_BankAccount.Visible = false;
            // 
            // dgvCol_Bank
            // 
            this.dgvCol_Bank.DataPropertyName = "Bank";
            this.dgvCol_Bank.HeaderText = "Bank";
            this.dgvCol_Bank.Name = "dgvCol_Bank";
            this.dgvCol_Bank.ReadOnly = true;
            this.dgvCol_Bank.Visible = false;
            // 
            // dgvCol_CurrentCredit
            // 
            this.dgvCol_CurrentCredit.DataPropertyName = "CurrentCredit";
            this.dgvCol_CurrentCredit.HeaderText = "CurrentCredit";
            this.dgvCol_CurrentCredit.Name = "dgvCol_CurrentCredit";
            this.dgvCol_CurrentCredit.ReadOnly = true;
            this.dgvCol_CurrentCredit.Visible = false;
            // 
            // dgvCol_CurrentDebit
            // 
            this.dgvCol_CurrentDebit.DataPropertyName = "CurrentDebit";
            this.dgvCol_CurrentDebit.HeaderText = "CurrentDebit";
            this.dgvCol_CurrentDebit.Name = "dgvCol_CurrentDebit";
            this.dgvCol_CurrentDebit.ReadOnly = true;
            this.dgvCol_CurrentDebit.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalCount);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmdNewSupplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 32);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(110, 13);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(14, 13);
            this.lblTotalCount.TabIndex = 7;
            this.lblTotalCount.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Supplier is : ";
            // 
            // cmdNewSupplier
            // 
            this.cmdNewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewSupplier.AutoSize = true;
            this.cmdNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewSupplier.ForeColor = System.Drawing.Color.White;
            this.cmdNewSupplier.Location = new System.Drawing.Point(215, 0);
            this.cmdNewSupplier.Name = "cmdNewSupplier";
            this.cmdNewSupplier.Size = new System.Drawing.Size(31, 30);
            this.cmdNewSupplier.TabIndex = 5;
            this.cmdNewSupplier.Text = "+";
            this.ttp.SetToolTip(this.cmdNewSupplier, "Click to add \"New Customer\"");
            this.cmdNewSupplier.UseVisualStyleBackColor = false;
            this.cmdNewSupplier.Click += new System.EventHandler(this.cmdNewSupplier_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPurchase);
            this.groupBox2.Controls.Add(this.panelSummary);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Records Summary";
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_VoucherNo,
            this.dgvCol_Date,
            this.dgvCol_Amount,
            this.dgvCol_Discount,
            this.dgvCol_NetAmount,
            this.dgvColPaidAmount,
            this.dgvCol_Detail,
            this.dgvCol_Payment});
            this.dgvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchase.Location = new System.Drawing.Point(3, 78);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersWidth = 24;
            this.dgvPurchase.Size = new System.Drawing.Size(781, 217);
            this.dgvPurchase.TabIndex = 6;
            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellContentClick);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.lblTotalSummary);
            this.panelSummary.Controls.Add(this.label6);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSummary.Location = new System.Drawing.Point(3, 295);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(781, 39);
            this.panelSummary.TabIndex = 3;
            // 
            // lblTotalSummary
            // 
            this.lblTotalSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSummary.Location = new System.Drawing.Point(334, 6);
            this.lblTotalSummary.Name = "lblTotalSummary";
            this.lblTotalSummary.Size = new System.Drawing.Size(172, 24);
            this.lblTotalSummary.TabIndex = 0;
            this.lblTotalSummary.Text = "0";
            this.lblTotalSummary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Summary :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpTo);
            this.panel3.Controls.Add(this.cmdReset);
            this.panel3.Controls.Add(this.cmdFind);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtpFrom);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 57);
            this.panel3.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(366, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(91, 25);
            this.dtpTo.TabIndex = 1;
            // 
            // cmdReset
            // 
            this.cmdReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.ForeColor = System.Drawing.Color.White;
            this.cmdReset.Location = new System.Drawing.Point(530, 13);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(55, 27);
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFind.ForeColor = System.Drawing.Color.White;
            this.cmdFind.Location = new System.Drawing.Point(469, 13);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(55, 27);
            this.cmdFind.TabIndex = 4;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = false;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "To :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(224, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(91, 25);
            this.dtpFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "From :";
            // 
            // dgvCol_VoucherNo
            // 
            this.dgvCol_VoucherNo.FillWeight = 138.7311F;
            this.dgvCol_VoucherNo.HeaderText = "VoucherNo";
            this.dgvCol_VoucherNo.Name = "dgvCol_VoucherNo";
            // 
            // dgvCol_Date
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "dd/MMM/yyyy";
            this.dgvCol_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_Date.FillWeight = 138.7311F;
            this.dgvCol_Date.HeaderText = "Date";
            this.dgvCol_Date.Name = "dgvCol_Date";
            // 
            // dgvCol_Amount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvCol_Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCol_Amount.FillWeight = 138.7311F;
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            // 
            // dgvCol_Discount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.dgvCol_Discount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCol_Discount.HeaderText = "Discount";
            this.dgvCol_Discount.Name = "dgvCol_Discount";
            // 
            // dgvCol_NetAmount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.dgvCol_NetAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCol_NetAmount.HeaderText = "NetAmount";
            this.dgvCol_NetAmount.Name = "dgvCol_NetAmount";
            // 
            // dgvColPaidAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.dgvColPaidAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColPaidAmount.HeaderText = "Paid Amount";
            this.dgvColPaidAmount.Name = "dgvColPaidAmount";
            this.dgvColPaidAmount.Width = 150;
            // 
            // dgvCol_Detail
            // 
            this.dgvCol_Detail.FillWeight = 45.73554F;
            this.dgvCol_Detail.HeaderText = "";
            this.dgvCol_Detail.Name = "dgvCol_Detail";
            this.dgvCol_Detail.Text = "Detail";
            this.dgvCol_Detail.UseColumnTextForButtonValue = true;
            this.dgvCol_Detail.Width = 70;
            // 
            // dgvCol_Payment
            // 
            this.dgvCol_Payment.FillWeight = 38.07107F;
            this.dgvCol_Payment.HeaderText = "";
            this.dgvCol_Payment.Name = "dgvCol_Payment";
            this.dgvCol_Payment.Text = "Payment";
            this.dgvCol_Payment.UseColumnTextForButtonValue = true;
            this.dgvCol_Payment.Visible = false;
            this.dgvCol_Payment.Width = 70;
            // 
            // frmPurchase_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 498);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchase_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchase_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSupplier.ResumeLayout(false);
            this.gbSupplier.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSuppliers;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPurchase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdEditSupplier;
        private System.Windows.Forms.Label lblCurrentCredit;
        private System.Windows.Forms.Label lblCurrentDebit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdNewSupplier;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_SupplierID;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CurrentCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CurrentDebit;
        private System.Windows.Forms.Button cmdDiscount;
        private System.Windows.Forms.Button cmdMakePayment;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPaidAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCol_Detail;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCol_Payment;
    }
}