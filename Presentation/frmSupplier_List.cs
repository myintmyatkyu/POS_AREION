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
    public partial class frmSupplier_List : Form,ISupplier
    {
        public frmSupplier_List()
        {
            InitializeComponent();
            //dgv.Rows.Add(new object[]{"Diamond Quality Feed","Sein Wut Hmon","01682087","","","seinwyuthone@diamond.com","Sein Pan Street, Bayint Naung Pwe Yone"});
            //dgv.Rows.Add(new object[]{"Myanmar CP Live Stock","Mr Wirat Wongpornpakdee","01660546","","","wwpkdee@cplivestock.com","Sein Pan Street, Bayint Naung Pwe Yone"});
            LoadSuppliers();

        }
        private void LoadSuppliers()
        {
            try
            {
                //dgv.Columns.Clear();
                //var oops = from s in SupplierService.GetAllSuppliers() where s.Name=="CP" select new { s.SupplierID, s.Name };
                //dgv.DataSource = oops.ToList();
                //return;
                List<Supplier> suppliers = SupplierService.GetAllSuppliers();
                dgv.Rows.Clear();
                foreach (Supplier supplier in suppliers)
                {
                    dgv.Rows.Add(new object[] { supplier.SupplierID, supplier.Name, supplier.ContactPerson, supplier.Phone1, supplier.Phone2, supplier.Phone3, supplier.Email, supplier.Address,supplier.CurrentCredit });
                }
                lblTotal.Text = dgv.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            new frmSupplier().ShowDialog();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }


        #region ISupplier Members

        public void OnSupplierChanged(object key)
        {
            LoadSuppliers();
            Global.GridSort(dgv, key);
        }

        #endregion

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                new frmSupplier(dgv.CurrentRow.Cells[dgvCol_SupplierID.Name].Value.ToString()).Show();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delele this Supplier?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SupplierService.Delete(dgv.CurrentRow.Cells[dgvCol_SupplierID.Name].Value.ToString());
                LoadSuppliers();
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotal.Text = dgv.Rows.Count.ToString();
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            new frmSupplier().Show();
        }

        private void cmdEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                new frmSupplier(dgv.CurrentRow.Cells[dgvCol_SupplierID.Name].Value.ToString()).Show();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null && e.RowIndex !=-1)
            {
                new frmSupplier(dgv.CurrentRow.Cells[dgvCol_SupplierID.Name].Value.ToString()).Show();
            }
        }
    }
}
