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
    public partial class frmPurchaseDetailList : Form
    {
        public frmPurchaseDetailList()
        {
            InitializeComponent();
        }
        public frmPurchaseDetailList(string mainVoucherNo)
        {
            InitializeComponent();
            PurchaseHeader purchaseHeader = PurchaseHeaderService.GetPurchaseHeader(mainVoucherNo);
            lblName.Text = purchaseHeader.Supplier.Name;
            lblOpeningDate.Text = purchaseHeader.Date.ToString("dd/MMM/yyyy");
            lblTotalAmount.Text = purchaseHeader.NetAmount.ToString("#,###");
            lblVoucherNo.Text = purchaseHeader.VoucherNo;
            int count = 1;
            foreach(PurchaseDetail pd in purchaseHeader.PurchaseDetail)
            {
                dgv.Rows.Add(new object[] { count++, pd.Item.Code, pd.Item.Name, pd.Qty,pd.UOM.Code,pd.Price,pd.PriceBaseUnit,pd.NetAmount});
            }

        }
    }
}
