namespace Presentation
{
    partial class frmSale_List
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdNewCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dgvCol_VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_OpeningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_DetailView = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdNewSale = new System.Windows.Forms.Button();
            this.cmdEditCustomer = new System.Windows.Forms.Button();
            this.lblCurrentCredit = new System.Windows.Forms.Label();
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
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.cmdReceivePayment = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.gbCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 498);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 42);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 22;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(200, 424);
            this.dgvCustomer.TabIndex = 4;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomer_DataBindingComplete);
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
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
            this.dgvCol_Name.HeaderText = "Customers";
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
            // dgvColCurrentCredit
            // 
            this.dgvColCurrentCredit.DataPropertyName = "CurrentCredit";
            this.dgvColCurrentCredit.HeaderText = "Current Credit";
            this.dgvColCurrentCredit.Name = "dgvColCurrentCredit";
            this.dgvColCurrentCredit.ReadOnly = true;
            this.dgvColCurrentCredit.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCustomerCount);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmdNewCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 2;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.Location = new System.Drawing.Point(129, 14);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(14, 13);
            this.lblCustomerCount.TabIndex = 7;
            this.lblCustomerCount.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Customers is : ";
            // 
            // cmdNewCustomer
            // 
            this.cmdNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewCustomer.AutoSize = true;
            this.cmdNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewCustomer.ForeColor = System.Drawing.Color.White;
            this.cmdNewCustomer.Location = new System.Drawing.Point(164, 0);
            this.cmdNewCustomer.Name = "cmdNewCustomer";
            this.cmdNewCustomer.Size = new System.Drawing.Size(31, 30);
            this.cmdNewCustomer.TabIndex = 5;
            this.cmdNewCustomer.Text = "+";
            this.ttp.SetToolTip(this.cmdNewCustomer, "Click to add \"New Customer\"");
            this.cmdNewCustomer.UseVisualStyleBackColor = false;
            this.cmdNewCustomer.Click += new System.EventHandler(this.cmdNewCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 0;
            // 
            // txtCustomers
            // 
            this.txtCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomers.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomers.Location = new System.Drawing.Point(12, 9);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(177, 25);
            this.txtCustomers.TabIndex = 0;
            this.txtCustomers.Text = "Type to Search Customers";
            this.txtCustomers.TextChanged += new System.EventHandler(this.txtCustomers_TextChanged);
            this.txtCustomers.Validated += new System.EventHandler(this.txtCustomers_Validated);
            this.txtCustomers.Enter += new System.EventHandler(this.txtCustomers_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSales);
            this.groupBox2.Controls.Add(this.panelSummary);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Records Summary";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_VoucherNo,
            this.dgvCol_OpeningDate,
            this.dgvCol_Amount,
            this.dgvCol_TotalDiscount,
            this.dgvCol_NetAmount,
            this.dgvCol_PaidAmount,
            this.dgvCol_Credit,
            this.dgvCol_DetailView});
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(3, 82);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 24;
            this.dgvSales.Size = new System.Drawing.Size(832, 211);
            this.dgvSales.TabIndex = 5;
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // dgvCol_VoucherNo
            // 
            this.dgvCol_VoucherNo.FillWeight = 111.38F;
            this.dgvCol_VoucherNo.HeaderText = "VoucherNo";
            this.dgvCol_VoucherNo.Name = "dgvCol_VoucherNo";
            // 
            // dgvCol_OpeningDate
            // 
            dataGridViewCellStyle3.Format = "dd/MMM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvCol_OpeningDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCol_OpeningDate.FillWeight = 111.38F;
            this.dgvCol_OpeningDate.HeaderText = "Date";
            this.dgvCol_OpeningDate.Name = "dgvCol_OpeningDate";
            this.dgvCol_OpeningDate.Width = 56;
            // 
            // dgvCol_Amount
            // 
            this.dgvCol_Amount.FillWeight = 111.38F;
            this.dgvCol_Amount.HeaderText = "Amount";
            this.dgvCol_Amount.Name = "dgvCol_Amount";
            // 
            // dgvCol_TotalDiscount
            // 
            this.dgvCol_TotalDiscount.HeaderText = "Total Discount";
            this.dgvCol_TotalDiscount.Name = "dgvCol_TotalDiscount";
            this.dgvCol_TotalDiscount.Width = 200;
            // 
            // dgvCol_NetAmount
            // 
            this.dgvCol_NetAmount.HeaderText = "Net Amount";
            this.dgvCol_NetAmount.Name = "dgvCol_NetAmount";
            // 
            // dgvCol_PaidAmount
            // 
            this.dgvCol_PaidAmount.FillWeight = 111.38F;
            this.dgvCol_PaidAmount.HeaderText = "Paid Amount";
            this.dgvCol_PaidAmount.Name = "dgvCol_PaidAmount";
            // 
            // dgvCol_Credit
            // 
            this.dgvCol_Credit.FillWeight = 111.38F;
            this.dgvCol_Credit.HeaderText = "Credit";
            this.dgvCol_Credit.Name = "dgvCol_Credit";
            // 
            // dgvCol_DetailView
            // 
            this.dgvCol_DetailView.FillWeight = 1F;
            this.dgvCol_DetailView.HeaderText = "";
            this.dgvCol_DetailView.Name = "dgvCol_DetailView";
            this.dgvCol_DetailView.Text = "View";
            this.dgvCol_DetailView.UseColumnTextForButtonValue = true;
            this.dgvCol_DetailView.Width = 50;
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.lblTotalSummary);
            this.panelSummary.Controls.Add(this.label6);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSummary.Location = new System.Drawing.Point(3, 293);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(832, 39);
            this.panelSummary.TabIndex = 4;
            // 
            // lblTotalSummary
            // 
            this.lblTotalSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSummary.Location = new System.Drawing.Point(360, 6);
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
            this.label6.Location = new System.Drawing.Point(251, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
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
            this.panel3.Location = new System.Drawing.Point(3, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 57);
            this.panel3.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(392, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(91, 29);
            this.dtpTo.TabIndex = 1;
            // 
            // cmdReset
            // 
            this.cmdReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.ForeColor = System.Drawing.Color.White;
            this.cmdReset.Location = new System.Drawing.Point(556, 13);
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
            this.cmdFind.Location = new System.Drawing.Point(495, 13);
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
            this.label4.Location = new System.Drawing.Point(360, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "To :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(250, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(91, 29);
            this.dtpFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "From :";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.groupBox1);
            this.gbCustomer.Controls.Add(this.lblCurrentCredit);
            this.gbCustomer.Controls.Add(this.lblCurrentDebit);
            this.gbCustomer.Controls.Add(this.label9);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.lblAddress);
            this.gbCustomer.Controls.Add(this.label11);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.label5);
            this.gbCustomer.Controls.Add(this.lblContact);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCustomer.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(0, 0);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(838, 163);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdReceivePayment);
            this.groupBox1.Controls.Add(this.cmdNewSale);
            this.groupBox1.Controls.Add(this.cmdEditCustomer);
            this.groupBox1.Location = new System.Drawing.Point(640, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Box";
            // 
            // cmdNewSale
            // 
            this.cmdNewSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewSale.ForeColor = System.Drawing.Color.White;
            this.cmdNewSale.Location = new System.Drawing.Point(8, 19);
            this.cmdNewSale.Name = "cmdNewSale";
            this.cmdNewSale.Size = new System.Drawing.Size(172, 27);
            this.cmdNewSale.TabIndex = 4;
            this.cmdNewSale.Text = "New Sale";
            this.cmdNewSale.UseVisualStyleBackColor = false;
            this.cmdNewSale.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdEditCustomer
            // 
            this.cmdEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditCustomer.ForeColor = System.Drawing.Color.White;
            this.cmdEditCustomer.Location = new System.Drawing.Point(8, 51);
            this.cmdEditCustomer.Name = "cmdEditCustomer";
            this.cmdEditCustomer.Size = new System.Drawing.Size(172, 27);
            this.cmdEditCustomer.TabIndex = 4;
            this.cmdEditCustomer.Text = "Edit Customer Information";
            this.cmdEditCustomer.UseVisualStyleBackColor = false;
            this.cmdEditCustomer.Click += new System.EventHandler(this.cmdEditCustomer_Click);
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
            // cmdReceivePayment
            // 
            this.cmdReceivePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.cmdReceivePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReceivePayment.ForeColor = System.Drawing.Color.White;
            this.cmdReceivePayment.Location = new System.Drawing.Point(8, 85);
            this.cmdReceivePayment.Name = "cmdReceivePayment";
            this.cmdReceivePayment.Size = new System.Drawing.Size(172, 27);
            this.cmdReceivePayment.TabIndex = 5;
            this.cmdReceivePayment.Text = "Receive Payment";
            this.cmdReceivePayment.UseVisualStyleBackColor = false;
            this.cmdReceivePayment.Click += new System.EventHandler(this.cmdReceivePayment_Click);
            // 
            // frmSale_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 498);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmSale_List";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSale_List_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_List_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button cmdEditCustomer;
        private System.Windows.Forms.Button cmdNewSale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdNewCustomer;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomer;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_OpeningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Credit;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCol_DetailView;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdReceivePayment;
    }
}