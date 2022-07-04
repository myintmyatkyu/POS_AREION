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
    public partial class frmCustomerCreditList : Form
    {
        public frmCustomerCreditList()
        {
            InitializeComponent();
            List<Customer> customers = CustomerService.GetAllCustomers();
            dgv.Rows.Clear();
            int totalAmount = 0;
            foreach (Customer customer in customers)
            {
                CustomerAccount ca = CustomerService.GetCustomerAccount(customer.CustomerID);
               
                if (ca.CurrentCredit > 0)
                {
                    dgv.Rows.Add(new object[] { customer.Name,customer.ContactPerson,customer.Address,customer.Phone1,customer.Phone2,customer.Phone3,ca.CurrentCredit});
                    totalAmount += ca.CurrentCredit;
                }
                
            }
            lblTotal.Text = totalAmount.ToString("#,##");
        }


    }
}
