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
    public partial class frmSupplierDiscount : Form
    {
        public frmSupplierDiscount()
        {
            InitializeComponent();
            LoadSuppliers();
        }
        public frmSupplierDiscount(string supplierID)
        {
            InitializeComponent();
            LoadSuppliers(supplierID);
        }

        private void LoadSuppliers()
        {
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
        }
        private void LoadSuppliers(string supplierID)
        {
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
            cboSupplier.Text = SupplierService.GetSupplier(supplierID).Name;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDiscount sd = new SupplierDiscount();
                sd.Amount = Convert.ToInt32(txtAmount.Text);
                sd.Date = dtpDate.Value;
                sd.DiscountID = Guid.NewGuid().ToString();
                sd.Remarks = txtRemarks.Text;
                sd.Supplier = (Supplier)cboSupplier.SelectedValue;

                SupplierDiscountService.Save(sd);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
