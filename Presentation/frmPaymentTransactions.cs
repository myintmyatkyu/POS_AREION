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
    public partial class frmPaymentTransactions : Form
    {
        public frmPaymentTransactions(string customerID)
        {
            InitializeComponent();
            Customer customer = CustomerService.GetCustomer(customerID);
            CustomerAccount ca = CustomerService.GetCustomerAccount(customerID);
            lblName.Text = customer.Name;
            lblCurrentCredit.Text = ca.CurrentCredit.ToString();


            List<CustomerPayment> payments = PaymentService.GetAllPayments(customerID);

            foreach (CustomerPayment payment in payments)
            {
                dgv.Rows.Add(new object[] {payment.ReceiptNo,payment.ReceiptNo,payment.PaidAmount,payment.CreditAmount,payment.Balance,payment.Date,payment.ReceivedBy,payment.PaidBy,payment.Remarks });
            }
        }
    }
}
