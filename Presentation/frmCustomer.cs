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
    public partial class frmCustomer : Form
    {
        string CustomerID = "";
        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(string customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            Customer customer = CustomerService.GetCustomer(customerID);
            ReloadCustomerData(customer);

        }
        public void ReloadCustomerData(Customer customer)
        {
            txtAddress.Text = customer.Address;
            txtBankAccount.Text = customer.BankAccount;
            txtBankName.Text = customer.Bank;
            txtContactPerson.Text = customer.ContactPerson;
            txtEmail.Text = customer.Email;
            txtName.Text = customer.Name;
            txtNRCNo.Text = customer.NRCNO;
            txtPhone1.Text = customer.Phone1;
            txtPhone2.Text = customer.Phone2;
            txtPhone3.Text = customer.Phone3;
            txtTransferPerson.Text = customer.TransferPerson;
            txtCurrentCredit.Text = customer.CurrentCredit.ToString();

        
        }

  

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerID == "")
                {
                    Customer customer = new Customer();
                    customer.Address = txtAddress.Text;
                    customer.Bank = txtBankName.Text;
                    customer.BankAccount = txtBankAccount.Text;
                    customer.ContactPerson = txtContactPerson.Text;
                    customer.CustomerID = CustomerService.GetNewID();
                    customer.Email = txtEmail.Text;
                    customer.Name = txtName.Text;
                    customer.NRCNO = txtNRCNo.Text;
                    customer.Phone1 = txtPhone1.Text;
                    customer.Phone2 = txtPhone2.Text;
                    customer.Phone3 = txtPhone3.Text;
                    customer.TransferPerson = txtTransferPerson.Text;
                    customer.CurrentCredit = Convert.ToInt32(txtCurrentCredit.Text);


                    CustomerService.Save(customer);
                    Refresher.RaiseRefreshEvents<Customer>(customer.CustomerID);
                    this.Close();
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Address = txtAddress.Text;
                    customer.Bank = txtBankName.Text;
                    customer.BankAccount = txtBankAccount.Text;
                    customer.ContactPerson = txtContactPerson.Text;
                    customer.CustomerID = CustomerID;
                    customer.Email = txtEmail.Text;
                    customer.Name = txtName.Text;
                    customer.NRCNO = txtNRCNo.Text;
                    customer.Phone1 = txtPhone1.Text;
                    customer.Phone2 = txtPhone2.Text;
                    customer.Phone3 = txtPhone3.Text;
                    customer.TransferPerson = txtTransferPerson.Text;
                    customer.CurrentCredit = Convert.ToInt32(txtCurrentCredit.Text);
                 
                    CustomerService.Update(customer);
                    Refresher.RaiseRefreshEvents<Customer>(customer.CustomerID);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            { 
                
            }
        }

        private void RaiseRefreshEvent(object key)
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

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
