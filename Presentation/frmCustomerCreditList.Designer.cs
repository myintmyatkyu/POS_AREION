namespace Presentation
{
    partial class frmCustomerCreditList
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Phone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_CurrentCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label13.Size = new System.Drawing.Size(722, 49);
            this.label13.TabIndex = 34;
            this.label13.Text = "Customer Credit List";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblTotal);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 453);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(722, 50);
            this.panel.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(375, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 21);
            this.lblTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 15);
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
            this.dgvCol_Name,
            this.dgvCol_ContactPerson,
            this.dgvCol_Address,
            this.dgvCol_Phone1,
            this.dgvCol_Phone2,
            this.dgvCol_Phone3,
            this.dgvCol_CurrentCredit});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 49);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 22;
            this.dgv.Size = new System.Drawing.Size(722, 404);
            this.dgv.TabIndex = 37;
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
            // dgvCol_CurrentCredit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvCol_CurrentCredit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_CurrentCredit.HeaderText = "CurrentCredit";
            this.dgvCol_CurrentCredit.Name = "dgvCol_CurrentCredit";
            this.dgvCol_CurrentCredit.ReadOnly = true;
            // 
            // frmCustomerCreditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 503);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label13);
            this.Name = "frmCustomerCreditList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Credit List";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Phone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CurrentCredit;
    }
}