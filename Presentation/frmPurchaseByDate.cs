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
    public partial class frmPurchaseByDate : Form
    {
        public frmPurchaseByDate()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.Clear();
                foreach(PurchaseDetail pd in PurchaseDetailService.GetAllPurchases(dtpFrom.Value.Date,dtpTo.Value.Date))
                {
                    PurchaseHeader ph =PurchaseHeaderService.GetPurchaseHeader(pd.VoucherNo);
                    dgv.Rows.Add(new object[]{ph.VoucherNo,ph.Date.ToString("dd-MM-yyyy"),ph.Supplier.Name,pd.Item.Name,pd.Qty,pd.UOM.Code,pd.Price,pd.NetAmount});
                }
                lblTotalCount.Text = dgv.Rows.Count.ToString();
                lblTotal.Text = CalculateTotalAmount(dgv, dgvCol_Amount.Name).ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalCount.Text = dgv.Rows.Count.ToString();
            lblTotal.Text= CalculateTotalAmount(dgv, dgvCol_Amount.Name).ToString();
        }
        private int CalculateTotalAmount(DataGridView mydgv, string AmountColumnName)
        {
            int total = 0;
            foreach (DataGridViewRow dr in mydgv.Rows)
            {
                if (dr.Cells[AmountColumnName].Value != null)
                {
                    int amount = Convert.ToInt32(dr.Cells[AmountColumnName].Value);
                    total += amount;
                }
            }
            return total;
        }
    }
}
