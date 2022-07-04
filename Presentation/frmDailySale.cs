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
    public partial class frmDailySale : Form
    {
        public frmDailySale()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.Clear();
                foreach(SaleDetail sd in SaleDetailService.GetAllSales(dtpFrom.Value.Date,dtpTo.Value.Date))
                {
                    SaleHeader sh =SaleHeaderService.GetSaleHeader(sd.MainVoucherNo);
                    dgv.Rows.Add(new object[]{sh.VoucherNo,sh.Date.ToString("dd-MM-yyyy"),sh.Customer.Name,sd.Item.Name,sd.Qty,sd.UOM.Code,sd.Price,sd.NetAmount});
                }
                lblTotalCount.Text = dgv.Rows.Count.ToString();
                lblTotal.Text = CalculateTotalAmount(dgv, dgvCol_Amount.Name).ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //var result= from saleHeader in SaleHeaderService.GetAllSaleHeaders() where saleHeader.OpeningDate.Date==dtpDate.Value.Date select saleHeader ;
            //dgv.DataSource =result.ToList();
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
