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
    public partial class frmPurchaseSearchByDate : Form
    {
        public frmPurchaseSearchByDate()
        {
            InitializeComponent();
        }


        private void cmdShow_Click(object sender, EventArgs e)
        {
            try
            {
                var result = from pd in PurchaseDetailService.GetAllPurchases(dtpFrom.Value, dtpTo.Value) select new { pd.Item.Description, PurchaseHeaderService.GetPurchaseHeader(pd.VoucherNo).Date, BuyingPrice = pd.Price, pd.Qty, Amount = pd.SubTotal, pd.DiscountAmount, pd.NetAmount };
                //var result= from saleHeader in SaleHeaderService.GetAllSaleHeaders() where saleHeader.OpeningDate.Date==dtpDate.Value.Date select saleHeader ;
                dgv.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalCount.Text = dgv.Rows.Count.ToString();
            lblTotal.Text = CalculateTotalAmount(dgv, dgvCol_NetAmount.Name).ToString();
           
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
