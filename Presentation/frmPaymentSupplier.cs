using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSBusinessLogic;
using POSModel;

namespace Presentation
{
    public partial class frmPaymentSupplier : Form
    {
        public frmPaymentSupplier()
        {
            InitializeComponent();
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
            txtPaymentNo.Text = GetNewInvoiceNo();
            
        }

        public frmPaymentSupplier(string supplierID)
        {
            InitializeComponent();
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
            txtPaymentNo.Text = GetNewInvoiceNo();
            cboSupplier.Text = SupplierService.GetAllSuppliers().Find(i => i.SupplierID == supplierID).Name;

        }
        public void NewAction()
        {
            txtPaymentNo.Text = GetNewInvoiceNo();
            txtBalance.Text = "0";
            txtCreditAmount.Text = "0";
            txtPaidAmount.Text = "0";
            txtPaidBy.Text = "";
            txtReceivedBy.Text = "";
            txtRemarks.Text = "";
            cboSupplier.Focus();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewAction();
        }

        private string GetNewInvoiceNo()
        {
            string year = DateTime.Now.Year.ToString().Substring(2, 2);
            string month = DateTime.Now.Month.ToString();
            Fill_a_Zero(ref month);
            string day = DateTime.Now.Day.ToString();
            Fill_a_Zero(ref day);
            string hour = DateTime.Now.Hour.ToString();
            Fill_a_Zero(ref hour);
            string min = DateTime.Now.Minute.ToString();
            Fill_a_Zero(ref min);
            string sec = DateTime.Now.Second.ToString();
            Fill_a_Zero(ref sec);
            string milsec = DateTime.Now.Millisecond.ToString();
            Fill_a_Zero(ref milsec);

            string invoiceNo = year + month + day + hour + min + sec + milsec;
            return invoiceNo;
        }

        private void Fill_a_Zero(ref string str)
        {
            if (str.Length < 2)
            {
                str = "0" + str;
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = (Supplier)cboSupplier.SelectedValue;
            txtCreditAmount.Text = supplier.CurrentCredit.ToString();
            txtPaidAmount.Text = "0";
            txtBalance.Text = "0";
            
        }

        private void controlsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierPayment payment = new SupplierPayment();
                payment.PaymentNo = txtPaymentNo.Text;
                payment.Supplier = (Supplier)cboSupplier.SelectedValue;
                payment.CreditAmount = Convert.ToInt32(txtCreditAmount.Text);
                payment.PaidAmount = Convert.ToInt32(txtPaidAmount.Text);
                payment.Balance = Convert.ToInt32(txtBalance.Text);
                payment.Date = dtpDate.Value;
                payment.PaidBy = txtPaidBy.Text;
                payment.ReceivedBy = txtReceivedBy.Text;
                payment.Remarks = txtRemarks.Text;

                PaymentSupplierService.Save(payment);
                MessageBox.Show("Saving Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaidAmount_Validated(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(txtCreditAmount.Text) - Convert.ToInt32(txtPaidAmount.Text);
            txtBalance.Text = balance.ToString();
        }
    }
}
