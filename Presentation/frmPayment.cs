using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSModel;
using POSBusinessLogic;

namespace Presentation
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(string mainVoucherNo)
        {
            InitializeComponent();
            txtVoucherNo.Text = mainVoucherNo;
            SendKeys.Send("{Enter}");
        }


        private void txtVoucherNoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    SaleHeader saleHeader = SaleHeaderService.GetSaleHeader(txtVoucherNo.Text);
                    txtAmount.Text = saleHeader.Amount.ToString();
                    txtCredit.Text = saleHeader.Refund.ToString();
                    txtCredit.Tag = saleHeader.Refund;
                    lblVoucherNo.Text = saleHeader.VoucherNo;
                    lblName.Text = saleHeader.Customer.Name;
                    lblOpeningDate.Text = saleHeader.Date.ToString("dd/MMM/yyyy");
                    
                    dgv.Rows.Clear();
                    txtPaidAmount.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wrong Voucher No", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectAll();
                }
            }
        }

        private void txtVoucherNo_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerPayment payment = new CustomerPayment();
                payment.ReceiptNo = PaymentService.GetNewID();
                payment.ReceiptNo = txtVoucherNo.Text;
                payment.PaidAmount = Convert.ToInt32(txtAmount.Text);
                payment.Balance = Convert.ToInt32(txtCredit.Text);
                payment.CreditAmount = Convert.ToInt32(txtPaidAmount.Text);
                payment.Remarks = txtRemarks.Text;
                payment.ReceivedBy = txtReceivedBy.Text;
                payment.PaidBy = txtPaidBy.Text;
                payment.Date = dtpDate.Value;

                PaymentService.Save(payment);
                RaiseRefreshEvents(payment.ReceiptNo);
                this.Close();
             

            }
            catch(Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void RaiseRefreshEvents(object key)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                IPayment paymentForm = Application.OpenForms[i] as IPayment;
                if (paymentForm != null)
                {
                    paymentForm.OnPaymentChanged(key);
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPaidAmount_Validated(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(txtAmount.Text);
                int paid = 0;
                if (txtPaidAmount.Text == "")
                {
                    paid = 0;
                }
                else
                {
                    paid = Convert.ToInt32(txtPaidAmount.Text);
                }
                int credit = Convert.ToInt32(txtCredit.Tag);

                credit = credit - paid;

                txtCredit.Text = credit.ToString();
            }
            catch
            { }
        }

    }
}
