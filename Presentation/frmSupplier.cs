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
    public partial class frmSupplier : Form
    {
        string SupplierID = "";
        Supplier s = new Supplier();
        public frmSupplier()
        {
            InitializeComponent();
        }

        public frmSupplier(string supplierid)
        {
            InitializeComponent();
            SupplierID = supplierid;
            Supplier supplier = SupplierService.GetSupplier(supplierid);
            ReLoadSupplierData(supplier);
        }

        private void ReLoadSupplierData(Supplier s)
        {
            txtName.Text = s.Name;
            txtContactPerson.Text = s.ContactPerson;
            txtAddress.Text = s.Address;
            txtPhone1.Text = s.Phone1;
            txtPhone2.Text = s.Phone2;
            txtPhone3.Text = s.Phone3;
            txtEmail.Text = s.Email;
            txtCurrentCredit.Text = s.CurrentCredit.ToString();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SupplierID == "")
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierID = SupplierService.GetNewID();
                    supplier.Name = txtName.Text;
                    supplier.ContactPerson = txtContactPerson.Text;
                    supplier.Email = txtEmail.Text;
                    supplier.Phone1 = txtPhone1.Text;
                    supplier.Phone2 = txtPhone2.Text;
                    supplier.Phone3 = txtPhone3.Text;
                    supplier.Address = txtAddress.Text;
                    supplier.CurrentCredit = Convert.ToInt32(txtCurrentCredit.Text);
                    SupplierService.Save(supplier);
                    RaiseRefreshEvents(supplier.SupplierID);
                    this.Close();
                }
                else
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierID = SupplierID;
                    supplier.Name = txtName.Text;
                    supplier.ContactPerson = txtContactPerson.Text;
                    supplier.Email = txtEmail.Text;
                    supplier.Phone1 = txtPhone1.Text;
                    supplier.Phone2 = txtPhone2.Text;
                    supplier.Phone3 = txtPhone3.Text;
                    supplier.Address = txtAddress.Text;
                    supplier.CurrentCredit = Convert.ToInt32(txtCurrentCredit.Text);
                    SupplierService.Update(supplier);
                    RaiseRefreshEvents(supplier.SupplierID);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            { 
                
            
            }
        }

        private void RaiseRefreshEvents(object key)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                ISupplier supplierForm = Application.OpenForms[i] as ISupplier;
                if (supplierForm != null)
                {
                    supplierForm.OnSupplierChanged(key);
                }
            }
        }

        private void controlsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Control c = (Control)sender;
                SendKeys.Send("{Tab}");
            }
        }



        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
