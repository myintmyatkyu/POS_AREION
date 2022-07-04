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
using System.Globalization;

namespace Presentation
{
    public partial class frmPurchase_New : Form,IItemSubscriber
    {
        int normalWidth = 1174;
        int normalHeight = 600;


        bool isErrorFree_SaleDetail = true;
        DataGridView smalldgv = new DataGridView();

        List<Item> items = ItemService.GetAllItems();
        List<UOM> uoms = UOMService.GetAllUOMList();
        List<ItemUOM> itemuoms = ItemUOMService.GetAllItemUoms();

        public frmPurchase_New()
        {
            InitializeComponent();
            //txtVoucherNo.Text = GetNewInvoiceNo();
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
            
            smalldgv.DataSource=ItemService.GetAllItems();
            smalldgv.Visible = false;
            dgv.Controls.Add(smalldgv);
            //SetSizeNormal();
            
        }

        private string GetNewInvoiceNo()
        {
            string year = DateTime.Now.Year.ToString().Substring(2, 2);
            string month = DateTime.Now.Month.ToString();
            Fill_a_Zero(ref month);
            string day = DateTime.Now.Day.ToString();
            Fill_a_Zero(ref day);
            string hour = DateTime.Now.Hour.ToString();
            Fill_a_Zero(ref hour);
            string min = DateTime.Now.Minute.ToString();
            Fill_a_Zero(ref min);
            string sec = DateTime.Now.Second.ToString();
            Fill_a_Zero(ref sec);
            string milsec = DateTime.Now.Millisecond.ToString();
            Fill_a_Zero(ref milsec);

            string invoiceNo = year + month + day + hour + min + sec + milsec;
            return invoiceNo;
        }
        private void Fill_a_Zero(ref string str)
        {
            if (str.Length < 2)
            {
                str = "0" + str;
            }
        }

        public frmPurchase_New(string supplierID)
        {
            InitializeComponent();
            cboSupplier.DataSource = SupplierService.GetAllSuppliers();
            cboSupplier.Text = SupplierService.GetAllSuppliers().Find(i => i.SupplierID == supplierID).Name;

        }

        public frmPurchase_New(string mainVoucherNo,bool fromListForm)
        {
            InitializeComponent();
            //cboItemCode.DataSource = ItemService.GetAllItems();
            SetSizeNormal();


            txtVoucherNo.Text = mainVoucherNo;
            SendKeys.Send("{Enter}");
        }

        private void SetSizeNormal()
        {
            this.Width = normalWidth;
            this.Height = normalHeight;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count < 1)
                {
                    MessageBox.Show("No Item in the list !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                Save();
               // Print(txtVoucherNo.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
             }
        }

        private void Save()
        {
            try
            {
                PurchaseHeader header = new PurchaseHeader();
                header.VoucherNo = txtVoucherNo.Text;
                header.Supplier = (Supplier)cboSupplier.SelectedValue;
                header.Date = dtpOpeningDate.Value;
                header.Amount = Int32.Parse(txtTotalAmount.Text,NumberStyles.AllowThousands);
                header.TotalDiscount = Convert.ToInt32(txtDiscount.Text);
                header.Tax = Convert.ToDecimal(txtTax.Text);
                header.LabourCharges = 0;
                header.TransportCharges = 0;
                header.NetAmount = Int32.Parse(lblNetAmount.Text,NumberStyles.AllowThousands);
                header.PaidAmount = Int32.Parse(txtPaidAmount.Text,NumberStyles.AllowThousands);
                header.Credit =Int32.Parse(txtCredit.Text,NumberStyles.AllowThousands);
                
                foreach (DataGridViewRow dr in dgv.Rows)
                {
                    if (dr.Cells[dgvColCode.Name].Tag != null)
                    {
                        PurchaseDetail detail = new PurchaseDetail();
                        detail.VoucherNo = header.VoucherNo;
                        detail.Item = (Item)dr.Cells[dgvColCode.Name].Tag;
                        detail.UOM = ((ItemUOM)dr.Cells[dgvColUOM.Name].Tag).UOM;
                        detail.NetAmount = Convert.ToInt32(dr.Cells[dgvCol_Amount.Name].Value);
                        detail.Price = Convert.ToInt32(dr.Cells[dgvCol_Price.Name].Value);
                        detail.PriceBaseUnit = Convert.ToDecimal(dr.Cells[dgvColPriceBaseUnit.Name].Value);
                        detail.Qty = Convert.ToInt32(dr.Cells[dgvCol_Qty.Name].Value);
                        detail.QtyBaseUnit = ((ItemUOM)dr.Cells[dgvColUOM.Name].Tag).QtyInBaseUnit * Convert.ToInt32(dr.Cells[dgvCol_Qty.Name].Value);
                        detail.DiscountAmount = 0;
                        detail.DiscountType = "";
                        detail.DiscountValue = 0;
                        detail.SubTotal = Convert.ToInt32(dr.Cells[dgvCol_Amount.Name].Value);
                        header.PurchaseDetail.Add(detail);
                    }
                }
                PurchaseHeaderService.Save(header);
                RaiseRefreshEvents(header.VoucherNo);
                MessageBox.Show("Saving Succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print(string invoiceNo)
        {
            SaleHeader sh = SaleHeaderService.GetSaleHeader(invoiceNo);
            dsReports.SaleInvoiceDataTable dt = new dsReports.SaleInvoiceDataTable();
            Company company = CompanyService.GetCompanyTopOne();
            foreach (SaleDetail sd in sh.SaleDetail)
            {
                dsReports.SaleInvoiceRow dr = dt.NewSaleInvoiceRow();
                dr.Address = company.Address;
                dr.Company = company.CompanyName;
                dr.OpenDaily = company.OpenDaily;
                dr.PhoneNo = company.PhoneNo;

                dr.CustomerName = sh.Customer.Name;
                dr.InvoiceNo = sh.VoucherNo;
                dr.Date = sh.Date;
                dr.TotalAmount = sh.Amount;
                dr.NetAmount = sh.NetAmount;
                dr.PaidAmount = sh.PaidAmount;
                dr.Credit = sh.Refund;

                dr.Amount = sd.NetAmount;
                dr.Item = sd.Item.Description;
                dr.Price = sd.Price;
                dr.Qty = sd.Qty.ToString();

                dt.Rows.Add(dr);
            }

            //crpt_SaleInvoice crpt = new crpt_SaleInvoice();
            //crpt.SetDataSource(dt.DefaultView);
            //frmPreview frm = new frmPreview(crpt);
            //frm.Show();
            //crpt.PrintToPrinter(1, true, 0, 999);

        }

        private void RaiseRefreshEvents(object key)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                ISaleHeader saleForm = Application.OpenForms[i] as ISaleHeader;
                if (saleForm != null)
                {
                    saleForm.OnSaleChanged(key);
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaleHeaderService.isAlreadyExist(txtVoucherNo.Text))
                {
                    SaleHeader sh= SaleHeaderService.GetSaleHeader(txtVoucherNo.Text);
                }

                if (!isErrorFree_SaleDetail)
                {
                    MessageBox.Show("There are still errors in Data Entry. Please Check Entry Data again", "Errors still exsits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SaleDetail sd = new SaleDetail();
                //sd.Item = (Item)cboItemCode.SelectedValue;
                //sd.SubVoucherNo = txtSubVoucherNo.Text;
                sd.MainVoucherNo = txtVoucherNo.Text;
                sd.Price = sd.Item.Price;
                sd.Qty = Convert.ToInt32(1);
                //sd.SubVoucherNo = txtSubVoucherNo.Text;
                sd.SubTotal = sd.Price * sd.Qty;
                sd.DiscountType = "";
                sd.DiscountValue = 0;
                sd.DiscountAmount = 0;
                sd.NetAmount = 0;

                //dgv.Rows.Add(new object[] { sd.SubVoucherNo, sd.Item.Code, sd.Item.Description, sd.Item.Price, sd.Qty, sd.SubTotal,sd.DiscountType,sd.DiscountValue,sd.DiscountAmount,sd.NetAmount, sd });
                RefreshAmounts();
                ClearDetails();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearDetails()
        {
            try
            {
                dgv.Rows.Clear();
                txtVoucherNo.Text = GetNewInvoiceNo();
                txtPaidAmount.Text = "0";
                txtCredit.Text = "0";
                txtDiscount.Text = "0";
                txtTotalAmount.Text = "0";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshAmounts()
        {
            int currentTotal = CalculateTotalAmount(dgv, dgvCol_Amount.Name);
            double taxPercent = 0;
            int discount = Int32.Parse(txtDiscount.Text, NumberStyles.AllowThousands);
            double tax = (currentTotal / 100) * taxPercent;
            int netTotal = (currentTotal +Convert.ToInt32( tax)-discount);
            int paid = Int32.Parse(txtPaidAmount.Text,NumberStyles.AllowThousands);
            int refund = paid - netTotal;

            if (currentTotal != 0)
            {
                txtTotalAmount.Text = currentTotal.ToString("#,###");
            }
            else
            {
                txtTotalAmount.Text = "0";
            }
            NumberFormatInfo format = new NumberFormatInfo();
            format.CurrencyGroupSeparator = ",";
            if (netTotal != 0)
            {
                lblNetAmount.Text = netTotal.ToString("#,###");
            }
            else
            {
                lblNetAmount.Text = "0";
            }
            if (refund != 0)
            {
                refund = Math.Abs(refund);
                txtCredit.Text = refund.ToString("#,###");
            }
            else
            {
                txtCredit.Text = "0";
            }

        }

        private int CalculateDiscount(DataGridView mydgv, string DiscountColumnName)
        {
            return CalculateTotalAmount(mydgv, DiscountColumnName);
        }

        private int CalculateTotalAmount(DataGridView mydgv,string AmountColumnName)
        {
            int total=0;
            foreach (DataGridViewRow dr in mydgv.Rows)
            { 
                if(dr.Cells[AmountColumnName].Value != null)
                {
                    int amount = Convert.ToInt32(dr.Cells[AmountColumnName].Value);
                    total += amount;
                }
            }
            return total;
        }

        private void controlsKeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void AddItem(Item item)
        {
            try
            {
                
                dgv.Rows.Add(new object[] { 1, item.Description, item.Price, (1 * item.Price),item });
                dgv.Focus();
                dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
                dgv.BeginEdit(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPaidAmount_Validated(object sender, EventArgs e)
        {
            int paidAmount = 0;
            if (txtPaidAmount.Text == "")
            {
                paidAmount = 0;
            }
            else
            {
                paidAmount = Convert.ToInt32(txtPaidAmount.Text);
            }
            int refund = paidAmount - Int32.Parse(lblNetAmount.Text,NumberStyles.AllowThousands);
            refund = Math.Abs(refund);
            txtCredit.Text = refund.ToString();
        }


        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvColCode.Index)
                {
                    Item item = items.Find(i => i.Code == dgv.CurrentCell.Value.ToString()) == null ? new Item() : items.Find(i => i.Code == dgv.CurrentCell.Value.ToString());
                    if (item.ItemID == null)
                    {
                        MessageBox.Show("Invalid Item Code");
                        dgv.CurrentCell.Value = "";
                        return;
                    }
                    dgv.CurrentCell.Tag=item;
                    dgv.CurrentRow.Cells[dgvCol_Name.Name].Value = item.Name;
                }

                if (e.ColumnIndex == dgvColUOM.Index)
                { 
                    Item item=(Item)dgv.CurrentRow.Cells[dgvColCode.Name].Tag;
                    UOM uom = uoms.Find(i => i.Code == dgv.CurrentCell.Value.ToString());
                    ItemUOM ituom = itemuoms.Find(i => i.ItemID == item.ItemID && i.UOM.UOMID == uom.UOMID) == null ? new ItemUOM() : itemuoms.Find(i => i.ItemID == item.ItemID && i.UOM.UOMID == uom.UOMID);
                    dgv.CurrentCell.Tag=ituom;
                    dgv.CurrentRow.Cells[dgvCol_Price.Name].Value = ituom.PricePerCurrentUnit;
                    dgv.CurrentRow.Cells[dgvColPriceBaseUnit.Name].Value = ituom.PricePerBaseUnit;
                }

                if (e.ColumnIndex == dgvCol_Price.Index)
                {
                    ItemUOM ituom = (ItemUOM)dgv.CurrentRow.Cells[dgvColUOM.Name].Tag;
                    decimal qty = Convert.ToDecimal(dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value);
                    decimal price = Convert.ToDecimal(dgv.CurrentCell.Value);

                    decimal priceperbase =price/ituom.QtyInBaseUnit;
                    dgv.CurrentRow.Cells[dgvColPriceBaseUnit.Name].Value = priceperbase;

                    decimal subTotal = qty * ituom.QtyInBaseUnit * priceperbase;
                    dgv.CurrentRow.Cells[dgvCol_Amount.Name].Value = subTotal;
                }

                #region Old Code for Adding the same Item again and again
                //    int price = Convert.ToInt32(dgv.CurrentRow.Cells[dgvCol_Price.Name].Value);
            //    int qty = Convert.ToInt32(dgv.CurrentRow.Cells[dgvCol_Qty.Name].EditedFormattedValue);
            //    dgv.CurrentRow.Cells["dgvCol_Amount"].Value = price * qty;

            //    foreach (DataGridViewRow dvr in dgv.Rows)
            //    {
            //        if (dvr != dgv.CurrentRow)
            //        {
            //            if (dvr.Cells[dgvCol_Item.Name].Value == dgv.CurrentRow.Cells[dgvCol_Item.Name].Value)
            //            {
            //                int prevQty = Convert.ToInt32(dvr.Cells[dgvCol_Qty.Name].Value);
            //                int newQty = Convert.ToInt32(dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value);

            //                int prevAmount=Convert.ToInt32(dvr.Cells[dgvCol_Amount.Name].Value);
            //                int newAmount = Convert.ToInt32(dgv.CurrentRow.Cells[dgvCol_Amount.Name].Value);
            //                dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value = prevQty + newQty;
            //                dgv.CurrentRow.Cells[dgvCol_Amount.Name].Value = prevAmount + newAmount;
            //                dgv.Rows.Remove(dvr);
            //            }
            //        }
                //    }
                #endregion

                RefreshAmounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgv.CurrentCell.ColumnIndex == dgvColCode.Index)
            {
                var oops = items.Select(i => i.Code);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.AddRange(oops.ToArray());
                TextBox txtCell = (TextBox)e.Control;
                txtCell.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCell.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCell.AutoCompleteCustomSource = col;
            }
            
            if (dgv.CurrentCell.ColumnIndex == dgvColUOM.Index)
            {
                var oops = uoms.Select(i => i.Code);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.AddRange(oops.ToArray());
                TextBox txtCell = (TextBox)e.Control;
                txtCell.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCell.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCell.AutoCompleteCustomSource = col;
            }
        }

        private void frmSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                txtPaidAmount.Focus();
            }
            if (e.KeyCode == Keys.F5)
            {
                cmdSave.PerformClick();
            }
            if (e.KeyCode == Keys.N && e.Control)
            {
                cmdNew.PerformClick();
            }

            if (e.KeyCode==Keys.F12)
            {
                
            }
            if (e.KeyCode == Keys.F2)
            {
                dgv.Focus();
                if (dgv.Rows.Count > 0)
                {
                    if (dgv.SelectedCells.Count > 0)
                    {
                        dgv.Rows[dgv.SelectedCells[0].RowIndex].Selected = true;
                    }
                    else
                    {
                        dgv.Rows[0].Selected = true;
                    }
                }
            }
            if (e.KeyCode == Keys.F10)
            {
                new frmReprint().ShowDialog();
            }
        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            new frmAdminLogIn().ShowDialog();
        }

        #region IItemSubscriber Members

        public void OnItemChanged(object key)
        {
            items = ItemService.GetAllItems();
        }

        #endregion

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshAmounts();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (!Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cboItemCode_TextChanged(object sender, EventArgs e)
        {
            var oops = from item in items where item.Code.StartsWith("") select item.Code ;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            foreach (string s in oops)
            {
                col.Insert(0, s);
            }

        }

        private void dgvShortCuts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvColReprint.Index)
            {
                new frmReprint().ShowDialog();
            }
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvColCode.Index)
            {
                Item item = ItemService.GetAllItems().Where(i => i.Code == e.FormattedValue.ToString()).ToList()[0];
                dgv.Rows[e.RowIndex].Cells[dgvCol_Name.Index].Value = item.Name;

            }
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvColCode.Width = 100;
        }

        private void dgv_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvColPriceBaseUnit.Index)
            {
                if (dgv.CurrentRow.Cells[dgvColUOM.Name].Tag != null)
                {
                    ItemUOM ituom = (ItemUOM)dgv.CurrentRow.Cells[dgvColUOM.Name].Tag;
                    decimal qty = Convert.ToDecimal(dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value);
                    decimal price = Convert.ToDecimal(dgv.CurrentCell.Value);

                    decimal subTotal = qty * ituom.QtyInBaseUnit * price;
                    dgv.CurrentRow.Cells[dgvCol_Amount.Name].Value = subTotal;
                    RefreshAmounts();
                }
            }
        }

        private void chkFull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFull.Checked)
            {
                txtPaidAmount.Text = Int32.Parse( lblNetAmount.Text,NumberStyles.AllowThousands).ToString();
                RefreshAmounts();
                
            }
            else
            {
                txtPaidAmount.Text = "0";
            }
        }

        private void txtDiscount_Validated(object sender, EventArgs e)
        {
            RefreshAmounts();
        }
    }
}
