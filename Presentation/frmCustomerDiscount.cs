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
    public partial class frmCustomerDiscount : Form
    {
        public frmCustomerDiscount(string customerID)
        {
            InitializeComponent();
            LoadCustomers(customerID);
        }
        public frmCustomerDiscount()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            cboCustomer.DataSource = CustomerService.GetAllCustomers();
        }

        private void LoadCustomers(string customerID)
        {
            cboCustomer.DataSource = CustomerService.GetAllCustomers();
            cboCustomer.Text = CustomerService.GetCustomer(customerID).Name;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDiscount cd = new CustomerDiscount();
                cd.Amount = Convert.ToInt32(txtAmount.Text);
                cd.Customer = ((Customer)cboCustomer.SelectedValue);
                cd.Date = dtpDate.Value;
                cd.DiscountID = Guid.NewGuid().ToString();
                cd.Remarks = txtRemarks.Text;

                CustomerDiscountService.Save(cd);
                RaiseRefreshEvents(cd.Customer.CustomerID);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RaiseRefreshEvents(string key)
        {
            try
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    ICustomer customerForm = Application.OpenForms[i] as ICustomer;
                    if (customerForm != null)
                    {
                        customerForm.OnCustomerChanged(key);
                    }
                }
            }
            catch (Exception ex)
            { 
                
            }
        }

        
    }
}
