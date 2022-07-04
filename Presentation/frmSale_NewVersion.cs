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
    public partial class frmSale_NewVersion : Form,IItemSubscriber
    {
        int normalWidth = 1174;
        int normalHeight = 600;


        bool isErrorFree_SaleDetail = true;
        
        public frmSale_NewVersion()
        {
            InitializeComponent();
            txtVoucherNo.Text = GetNewInvoiceNo();
            cboSupplier.DataSource = CustomerService.GetAllCustomers();
            
            //SetSizeNormal();
            
        }

        private string GetNewInvoiceNo()
        {
            string year = DateTime.Now.Year.ToString().Substring(2, 2);
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            Fill_a_Zero(ref month,2);
            Fill_a_Zero(ref day, 2);
            

            int count     = Convert.ToInt32(SaleHeaderService.GetLastSaleInvoice(4));
            count++;
            string newlyGreneratedNo = count.ToString();
            Fill_a_Zero(ref newlyGreneratedNo, 4);

            string invoiceNo = year + month + day + newlyGreneratedNo;
            return invoiceNo;
        }

        private void Fill_a_Zero(ref string str,int count)
        {
            while (str.Length < count)
            {
                str = "0" + str;
            }
        }

        public frmSale_NewVersion(string customerID)
        {
            InitializeComponent();
            //cboItemCode.DataSource = ItemService.GetAllItems();
            SetSizeNormal();

        }

        public frmSale_NewVersion(string mainVoucherNo,bool fromListForm)
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
                SaleHeader sh = new SaleHeader();
                sh.VoucherNo = txtVoucherNo.Text;
                sh.Customer = (Customer)cboSupplier.SelectedValue;
                sh.Date = dtpOpeningDate.Value;
                sh.Amount = Int32.Parse(txtTotalAmount.Text,NumberStyles.AllowThousands);
                sh.TotalDiscount = Convert.ToInt32(txtDiscount.Text);
                sh.Tax = Convert.ToDecimal(txtTax.Text);
                sh.LabourCharges = 0;
                sh.TransportCharges = 0;
                sh.NetAmount = Int32.Parse(lblNetAmount.Text,NumberStyles.AllowThousands);
                sh.PaidAmount = Convert.ToInt32(txtPaidAmount.Text);
                sh.Credit =Int32.Parse(txtCredit.Text,NumberStyles.AllowThousands);
                sh.isCredit = true;
                sh.Refund = 0;
                foreach (DataGridViewRow dr in dgv.Rows)
                {
                    if (dr.Cells[dgvColCode.Name].Tag != null)
                    {
                        SaleDetail sd = new SaleDetail();
                        sd.MainVoucherNo = sh.VoucherNo;
                        sd.Item = (Item)dr.Cells[dgvColCode.Name].Tag;
                        sd.UOM = ((ItemUOM)dr.Cells[dgvColUOM.Name].Tag).UOM;
                        sd.NetAmount = Convert.ToInt32(dr.Cells[dgvCol_Amount.Name].Value);
                        sd.Price = Convert.ToInt32(dr.Cells[dgvCol_Price.Name].Value);
                        sd.PriceBaseUnit = Convert.ToDecimal(dr.Cells[dgvColPriceBaseUnit.Name].Value);
                        sd.Qty = Convert.ToInt32(dr.Cells[dgvCol_Qty.Name].Value);
                        sd.QtyBaseUnit = ((ItemUOM)dr.Cells[dgvColUOM.Name].Tag).QtyInBaseUnit * Convert.ToInt32(dr.Cells[dgvCol_Qty.Name].Value);
                        sd.DiscountAmount = 0;
                        sd.DiscountType = "";
                        sd.DiscountValue = 0;
                        sd.SubTotal = Convert.ToInt32(dr.Cells[dgvCol_Amount.Name].Value);
                        sh.SaleDetail.Add(sd);
                    }
                }
                SaleHeaderService.Save(sh);
                RaiseRefreshEvents(sh.VoucherNo);
                DialogResult result= MessageBox.Show("Saving Succesful.... Do you want to Print this Invoice?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Print(sh.VoucherNo);
                }

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
            int emptyRowCount = 0;
            foreach (SaleDetail sd in sh.SaleDetail)
            {
                dsReports.SaleInvoiceRow dr = dt.NewSaleInvoiceRow();
                dr.Address = company.Address;
                dr.Company = company.CompanyName;
                dr.Description = company.Description;
                dr.OpenDaily = company.OpenDaily;
                dr.PhoneNo = company.PhoneNo;


                dr.CustomerName = sh.Customer.Name;
                dr.InvoiceNo = sh.VoucherNo;
                dr.Date = sh.Date;
                dr.TotalAmount = sh.Amount;
                dr.Discount = sh.TotalDiscount;
                dr.NetAmount = sh.NetAmount;
                dr.PaidAmount = sh.PaidAmount;
                dr.Credit = Convert.ToInt32(sh.Credit);

                dr.Amount = sd.NetAmount;
                dr.Item = sd.Item.Name;
                dr.UOM = sd.UOM.Code;
                dr.Price = sd.Price;
                dr.Qty = sd.Qty.ToString();
                dr.Discount = sh.TotalDiscount;
                dt.Rows.Add(dr);
            }

            if (sh.SaleDetail.Count < 10)
            {
                emptyRowCount = 10 - sh.SaleDetail.Count;
                for (int i= 0;i<emptyRowCount;i++)
                {
                    dsReports.SaleInvoiceRow dr = dt.NewSaleInvoiceRow();
                    dr.Address = company.Address;
                    dr.Company = company.CompanyName;
                    dr.Description = company.Description;
                    dr.OpenDaily = company.OpenDaily;
                    dr.PhoneNo = company.PhoneNo;


                    dr.CustomerName = sh.Customer.Name;
                    dr.InvoiceNo = sh.VoucherNo;
                    dr.Date = sh.Date;
                    dr.TotalAmount = sh.Amount;
                    dr.Discount = sh.TotalDiscount;
                    dr.NetAmount = sh.NetAmount;
                    dr.PaidAmount = sh.PaidAmount;
                    dr.Credit = Convert.ToInt32(sh.Credit);

                    dt.Rows.Add(dr);
                }
            }



            //crpt_SaleInvoice_Daylia crpt = new crpt_SaleInvoice_Daylia();
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
                lblNetAmount.Text = "0";
                cboSupplier.SelectedIndex = -1;
                cboSupplier.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshAmounts()
        {
            int currentTotal = CalculateTotalAmount(dgv, dgvCol_Amount.Name);
            int discount = Int32.Parse(txtDiscount.Text, NumberStyles.AllowThousands);
            double taxPercent = 0;
            double tax = (currentTotal / 100) * taxPercent;
            int netTotal = (currentTotal +Convert.ToInt32( tax)-discount);
            int paid = Int32.Parse(txtPaidAmount.Text,NumberStyles.AllowThousands);
            int credit = netTotal - paid;
            

            
            txtTotalAmount.Text = currentTotal.ToString("#,###");
            lblNetAmount.Text = netTotal.ToString("#,###");
            if (credit > 0)
            {
                txtCredit.Text = Math.Abs(credit).ToString("#,###");
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
            //int paidAmount = 0;
            //if (txtPaidAmount.Text == "")
            //{
            //    paidAmount = 0;
            //}
            //else
            //{
            //    paidAmount = Convert.ToInt32(txtPaidAmount.Text);
            //}
            //int refund = paidAmount - Int32.Parse(lblNetAmount.Text,NumberStyles.AllowThousands);
            //txtCredit.Text = Math.Abs( refund).ToString();

            RefreshAmounts();
        }
        List<ItemUOM> itemuoms = ItemUOMService.GetAllItemUoms();
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
                    dgv.CurrentRow.Cells[dgvColUOM.Name].Value = item.UOMs.Find(i => i.isDefault).UOM.Code;
                    if (dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value == null) { dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value = 1; }
                    SendKeys.Send("{Tab}");
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
               
                RefreshAmounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<UOM> uoms = UOMService.GetAllUOMList();
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

        List<Item> items = ItemService.GetAllItems();
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
            if (e.ColumnIndex == dgvColUOM.Index)
            {
                if (dgv.CurrentRow.Cells[dgvColCode.Name].Tag == null) { return; }
                Item item = (Item)dgv.CurrentRow.Cells[dgvColCode.Name].Tag;
                UOM uom = uoms.Find(i => i.Code == dgv.CurrentCell.Value.ToString());
                if (uom == null)
                {
                    MessageBox.Show("Invalid UOM");
                    return;
                }
                ItemUOM ituom = itemuoms.Find(i => i.ItemID == item.ItemID && i.UOM.UOMID == uom.UOMID) == null ? new ItemUOM() : itemuoms.Find(i => i.ItemID == item.ItemID && i.UOM.UOMID == uom.UOMID);
                dgv.CurrentCell.Tag = ituom;
                dgv.CurrentRow.Cells[dgvCol_Price.Name].Value = ituom.PricePerCurrentUnit;
                dgv.CurrentRow.Cells[dgvColPriceBaseUnit.Name].Value = ituom.PricePerBaseUnit;
            }
            if (e.ColumnIndex == dgvColPriceBaseUnit.Index)
            {
                if (dgv.CurrentRow.Cells[dgvColUOM.Name].Tag == null) { return; }
                ItemUOM ituom = (ItemUOM)dgv.CurrentRow.Cells[dgvColUOM.Name].Tag;
                decimal qty = Convert.ToDecimal(dgv.CurrentRow.Cells[dgvCol_Qty.Name].Value);
                decimal price = Convert.ToDecimal(dgv.CurrentCell.Value);

                decimal subTotal = qty * ituom.QtyInBaseUnit * price;
                dgv.CurrentRow.Cells[dgvCol_Amount.Name].Value = subTotal;
                RefreshAmounts();
            }
        }



        private void txtDiscount_Validated(object sender, EventArgs e)
        {
            RefreshAmounts();
        }





    }

   
}
