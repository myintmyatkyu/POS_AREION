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
    public partial class frmSaleDetailList : Form
    {
        public frmSaleDetailList()
        {
            InitializeComponent();

        }
        public frmSaleDetailList(string mainVoucherNo)
        {
            InitializeComponent();
            SaleHeader saleHeader = SaleHeaderService.GetSaleHeader(mainVoucherNo);
            lblName.Text = saleHeader.Customer.Name;
            lblOpeningDate.Text = saleHeader.Date.ToString("dd/MMM/yyyy");
            lblTotalAmount.Text = saleHeader.Amount.ToString();
            lblVoucherNo.Text = saleHeader.VoucherNo;

            int count = 1;
            foreach (SaleDetail sd in saleHeader.SaleDetail)
            {
                dgv.Rows.Add(new object[] { count++, sd.Item.Code, sd.Item.Name, sd.Qty, sd.UOM.Code, sd.Price, sd.PriceBaseUnit, sd.NetAmount });
            }


        }
    }
}
