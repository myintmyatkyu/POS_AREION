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
    public partial class frmSaleByItem : Form
    {
        public frmSaleByItem()
        {
            InitializeComponent();
            cboItemCode.DataSource = ItemService.GetAllItems();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            foreach (SaleDetail sd in SaleDetailService.GetAllSales(dtpFrom.Value.Date, dtpTo.Value.Date,cboItemCode.SelectedValue.ToString()))
            {
                SaleHeader sh = SaleHeaderService.GetSaleHeader(sd.MainVoucherNo);
                dgv.Rows.Add(new object[] { sh.VoucherNo, sh.Date.ToString("dd-MM-yyyy"), sh.Customer.Name,  sd.Qty, sd.UOM.Code, sd.Price, sd.NetAmount });
            }

            lblTotalCount.Text = dgv.Rows.Count.ToString();
            lblTotalQty.Text = CalculateTotalAmount(dgv, dgvCol_Qty.Name).ToString();
            lblTotal.Text = CalculateTotalAmount(dgv, dgvCol_Amount.Name).ToString();
            if (lblTotalQty.Text != "0")
            {
                lblAvgPrice.Text = (Convert.ToInt32(lblTotal.Text) / Convert.ToInt32(lblTotalQty.Text)).ToString();
            }
            else
            {
                lblAvgPrice.Text = "0";
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalCount.Text = dgv.Rows.Count.ToString();
            lblTotalQty.Text = CalculateTotalAmount(dgv, dgvCol_Qty.Name).ToString();
            lblTotal.Text = CalculateTotalAmount(dgv, dgvCol_Amount.Name).ToString();
            if (lblTotalQty.Text != "0")
            {
                lblAvgPrice.Text = (Convert.ToInt32(lblTotal.Text) / Convert.ToInt32(lblTotalQty.Text)).ToString();
            }
            else
            {
                lblAvgPrice.Text = "0";
            }
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
