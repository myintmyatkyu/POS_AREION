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
    public partial class frmPurchase_List : Form,IPurchaseHeader,ISupplier
    {
        string SupplierID = "";
        public frmPurchase_List()
        {
            InitializeComponent();
        }



        private void cmdNewSupplier_Click(object sender, EventArgs e)
        {

            new frmSupplier().Show();

        }

        private void frmPurchase_List_Load(object sender, EventArgs e)
        {
            //var oops = from s in SupplierService.GetAllSuppliers() select new { s.SupplierID, s.Name };
            dgvSupplier.DataSource = SupplierService.GetAllSuppliers().OrderBy(i => i.Name).ToList() ;
            //dgvSupplier.DataSource = oops.ToList();

            lblTotalCount.Text = Convert.ToString(dgvSupplier.Rows.Count);
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                Supplier supplier = SupplierService.GetSupplier(dgvSupplier.SelectedRows[0].Cells["dgvCol_SupplierID"].Value.ToString());
                lblAddress.Text = supplier.Address;
                lblContact.Text = supplier.ContactPerson;
                lblCurrentCredit.Text = supplier.CurrentCredit.ToString();
                lblCurrentDebit.Text = supplier.CurrentDebit.ToString();
                lblName.Text = supplier.Name;
                lblName.Tag = supplier.SupplierID;
                lblPhone.Text = supplier.Phone1 + ", " + supplier.Phone2 + ", " + supplier.Phone3;

                List<PurchaseHeader> purchases = PurchaseHeaderService.GetPurchaseHeaders(supplier.SupplierID);
                dgvPurchase.Rows.Clear();
                int totalSummary = 0;
                foreach (PurchaseHeader purchase in purchases)
                {
                    totalSummary += purchase.NetAmount;
                    dgvPurchase.Rows.Add(new object[] { purchase.VoucherNo, purchase.Date, purchase.Amount, purchase.TotalDiscount, purchase.NetAmount, purchase.PaidAmount });
                }
                lblTotalSummary.Text = totalSummary.ToString("#,###");
            }
        }

        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            if (lblName.Tag != null)
            {
                new frmPurchase_New(lblName.Tag.ToString()).Show();
            }
            else
            {
                MessageBox.Show("Please choose supplier first...");
            }
        }

        private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                Supplier supplier = SupplierService.GetSupplier(dgvSupplier.SelectedRows[0].Cells["dgvCol_SupplierID"].Value.ToString());
                lblAddress.Text = supplier.Address;
                lblContact.Text = supplier.ContactPerson;
                lblCurrentCredit.Text = supplier.CurrentCredit.ToString();
                lblCurrentDebit.Text = supplier.CurrentDebit.ToString();
                lblName.Text = supplier.Name;
                lblName.Tag = supplier.SupplierID;
                lblPhone.Text = supplier.Phone1 + ", " + supplier.Phone2 + ", " + supplier.Phone3;

                List<PurchaseHeader> purchases = PurchaseHeaderService.GetPurchaseHeaders(supplier.SupplierID);
                dgvPurchase.Rows.Clear();
                foreach (PurchaseHeader purchase in purchases)
                {
                    dgvPurchase.Rows.Add(new object[] { purchase.VoucherNo, purchase.Date, purchase.Amount, purchase.TotalDiscount, purchase.NetAmount, purchase.PaidAmount });
                }
            }
        }

        private void cmdDiscount_Click(object sender, EventArgs e)
        {
            new frmSupplierDiscount(dgvSupplier.SelectedRows[0].Cells["dgvCol_SupplierID"].Value.ToString()).Show();
        }



        #region IPurchaseHeader Members

        public void OnPurchaseChanged(object key)
        {
            Supplier supplier = PurchaseHeaderService.GetPurchaseHeader(key.ToString()).Supplier;
            dgvSupplier.DataSource = SupplierService.GetAllSuppliers();
            Global.GridSort(dgvSupplier, supplier.SupplierID, dgvCol_SupplierID.Name, dgvCol_Name.Name);
        }

        #endregion

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPurchase.Columns[e.ColumnIndex].Name == dgvCol_Detail.Name)
            {
                string mainVoucherNo = dgvPurchase.CurrentRow.Cells["dgvCol_VoucherNo"].Value.ToString();
                new frmPurchaseDetailList(mainVoucherNo).Show();
            }
        }

        private void cmdEditSupplier_Click(object sender, EventArgs e)
        {
            new frmSupplier(dgvSupplier.SelectedRows[0].Cells["dgvCol_SupplierID"].Value.ToString()).Show();
        }

        #region ISupplier Members

        public void OnSupplierChanged(object key)
        {
            dgvSupplier.DataSource = SupplierService.GetAllSuppliers();
            Global.GridSort(dgvSupplier, key, dgvCol_SupplierID.Name, dgvCol_Name.Name);
        }

        #endregion

        private void dgvSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalCount.Text = dgvSupplier.Rows.Count.ToString();
            dgvSupplier.ClearSelection();
        }

        private void txtSuppliers_TextChanged(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = SupplierService.GetAllSuppliers().Where(i => i.Name.Contains(txtSuppliers.Text)).ToList();
        }

        private void cmdMakePayment_Click(object sender, EventArgs e)
        {
            if (lblName.Tag != null)
            {
                new frmPaymentSupplier(lblName.Tag.ToString()).Show();
            }
            else
            {
                MessageBox.Show("Please choose Supplier first");
            }
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (lblName.Tag == null)
            {
                MessageBox.Show("Please choose Supplier First");
                return;
            }
            Supplier supplier = SupplierService.GetSupplier(lblName.Tag.ToString());
            List<PurchaseHeader> purchases = PurchaseHeaderService.GetPurchaseHeaders(supplier.SupplierID).Where(i=>i.Date.Date >=dtpFrom.Value.Date && i.Date.Date<=dtpTo.Value.Date).ToList();
            dgvPurchase.Rows.Clear();
            int totalSummary = 0;
            foreach (PurchaseHeader purchase in purchases)
            {
                totalSummary += purchase.NetAmount;
                dgvPurchase.Rows.Add(new object[] { purchase.VoucherNo, purchase.Date, purchase.Amount, purchase.TotalDiscount,  purchase.NetAmount,purchase.PaidAmount });
            }
            lblTotalSummary.Text = totalSummary.ToString("#,###");
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {

            if (lblName.Tag == null)
            {
                MessageBox.Show("Please choose Supplier First");
                return;
            }
            Supplier supplier = SupplierService.GetSupplier(lblName.Tag.ToString());
            List<PurchaseHeader> purchases = PurchaseHeaderService.GetPurchaseHeaders(supplier.SupplierID);
            dgvPurchase.Rows.Clear();
            int totalSummary = 0;
            foreach (PurchaseHeader purchase in purchases)
            {
                totalSummary += purchase.NetAmount;
                dgvPurchase.Rows.Add(new object[] { purchase.VoucherNo, purchase.Date, purchase.Amount, purchase.TotalDiscount, purchase.NetAmount });
            }
            lblTotalSummary.Text = totalSummary.ToString("#,###");
        }
    }
}
