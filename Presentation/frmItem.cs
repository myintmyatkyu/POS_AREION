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
    public partial class frmItem : Form
    {
        Item item;
        string ItemID = "";
        public frmItem()
        {
            InitializeComponent();
            LoadDgvUOM();
            dgvBeginning.Rows.Clear();
            foreach (Store s in StoreService.GetAllStores())
            {
                dgvBeginning.Rows.Add(new object[] { s.ID, s.Name, 0, "" });
            }
            dgvBeginning.ClearSelection();
            cboBasicUOM.DataSource = UOMService.GetAllUOMList();
            cboCategory.DataSource = CategoryService.GetAllCategories();
            
            item = new Item();
            
        }

        public frmItem(string itemID)
        {
            InitializeComponent();
            dgvBeginning.Enabled = false;
            cmdEdit.Visible = true;
            LoadDgvUOM();
            cboBasicUOM.DataSource = UOMService.GetAllUOMList();
            cboCategory.DataSource = CategoryService.GetAllCategories();
            dgvBeginning.Rows.Clear();
            item = ItemService.GetItem(itemID);
            ItemID = itemID;
            ReloadItemData(item);
        }

        public void LoadDgvUOM()
        {
            foreach(UOM uom in UOMService.GetAllUOMList())
            {
                dgvUOM.Rows.Add(new object[]{uom.UOMID, uom.Code,uom.Description,false,null,null,null});
            }
        }

        private void ReloadItemData(Item item)
        {
            txtCode.Text = item.Code;
            txtDescription.Text = item.Description;
            txtName.Text = item.Name;
            UOM basicUOM=item.UOMs.Find(i=>i.isBaseUnit).UOM;
            UOM currentUOM = ((List<UOM>)cboBasicUOM.DataSource).Find(i => i.UOMID == basicUOM.UOMID);
            cboBasicUOM.SelectedItem = currentUOM;
            txtPriceBaseUnit.Text = item.UOMs.Find(i => i.isBaseUnit).PricePerBaseUnit.ToString();
            cboCategory.SelectedValue = item.Category.CategoryID;

            ClearUOMGrid();
          

            foreach (ItemUOM iu in item.UOMs)
            {
                foreach (DataGridViewRow dr in dgvUOM.Rows)
                {
                    if (iu.UOM.UOMID == dr.Cells[dgvCol_UOMID.Name].Value.ToString())
                    {
                        dr.Cells[dgvColPick.Name].Value=true;
                        dr.Cells[dgvColisBaseUnit.Name].Value = iu.isBaseUnit;
                        dr.Cells[dgvColIsDefault.Name].Value = iu.isDefault;
                        dr.Cells[dgvColPrice.Name].Value = iu.PricePerCurrentUnit;
                        dr.Cells[dgvColPriceBase.Name].Value = iu.PricePerBaseUnit;
                        dr.Cells[dgvColQtyBaseUnit.Name].Value = iu.QtyInBaseUnit;
                    }
                }
            }
            dgvBeginning.Rows.Clear();
            foreach (Stock s in item.Stocks)
            {
                dgvBeginning.Rows.Add(new object[] { s.Store.ID, s.Store.Name, s.Balance,item.UOMs.Find(i=>i.isBaseUnit==true).UOM.Code });
            }

            dgvBeginning.ClearSelection();

            txtRemarks.Text = item.Remark;
            txtBalance.Text = item.QtyInHand.ToString();
            txtBalance.Enabled = false;
        }

        public void ClearUOMGrid()
        {
            foreach (DataGridViewRow dr in dgvUOM.Rows)
            {
                dr.Cells[dgvColPick.Name].Value = false;
                dr.Cells[dgvColisBaseUnit.Name].Value = false;
                dr.Cells[dgvColIsDefault.Name].Value = false;
                dr.Cells[dgvColPrice.Name].Value = null;
                dr.Cells[dgvColPriceBase.Name].Value = null;
                dr.Cells[dgvColQtyBaseUnit.Name].Value = null;

            }
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            item.ItemID = ItemID;
            if (item.ItemID == "" || item.ItemID==null)
            {
                item.ItemID = ItemService.GetNewID();
            }
            item.Code = txtCode.Text;
            item.Name = txtName.Text;
            item.Description = txtDescription.Text;
           
            item.Remark = txtRemarks.Text;
            item.Category = CategoryService.GetCategory(cboCategory.SelectedValue.ToString());
            item.QtyInHand = Convert.ToInt32(txtBalance.Text);
            UOM uom = new UOM();
            uom.UOMID = cboBasicUOM.SelectedValue.ToString();
            item.UOMs = new List<ItemUOM>();
            item.Stocks = new List<Stock>();
            foreach (DataGridViewRow dr in dgvUOM.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[dgvColPick.Name].Value) == true)
                {
                    ItemUOM iu = new ItemUOM();
                    iu.ItemID = item.ItemID;
                    iu.UOM = new UOM() { UOMID = dr.Cells[dgvCol_UOMID.Name].Value.ToString() };
                    iu.isBaseUnit = Convert.ToBoolean(dr.Cells[dgvColisBaseUnit.Name].FormattedValue);
                    iu.PricePerCurrentUnit=Convert.ToInt32(dr.Cells[dgvColPrice.Name].Value);
                    iu.QtyInBaseUnit=Convert.ToInt32(dr.Cells[dgvColQtyBaseUnit.Name].Value);
                    iu.PricePerBaseUnit=iu.PricePerCurrentUnit/iu.QtyInBaseUnit;
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells[dgvColIsDefault.Name];
                    iu.isDefault = Convert.ToBoolean( chk.EditedFormattedValue);
                    item.UOMs.Add(iu);
                }
            }
            foreach (DataGridViewRow dr in dgvBeginning.Rows)
            {
                Stock s = new Stock();
                s.ItemID = item.ItemID;
                s.Store = StoreService.GetStore(dr.Cells[dgvColStoreID.Name].Value.ToString());
                s.Balance = Convert.ToDouble(dr.Cells[dgvColBalance.Name].Value);
                item.Stocks.Add(s);
            }

            ItemService.Save(item);
            RaiseRefreshEvents(item.ItemID);
          

            this.Close();
            
        }

        public void RefreshAmounts(DataGridViewRow dr)
        {
            dr.Cells[dgvColQtyBaseUnit.Name].Value = dr.Cells[dgvColQtyBaseUnit.Name].Value == null ? 1 : dr.Cells[dgvColQtyBaseUnit.Name].Value;
            dr.Cells[dgvColPrice.Name].Value = dr.Cells[dgvColPrice.Name].Value == null ? 1 : dr.Cells[dgvColPrice.Name].Value; ;
            decimal qty = Convert.ToDecimal(dr.Cells[dgvColQtyBaseUnit.Name].Value.ToString());
            decimal price = Convert.ToDecimal(dr.Cells[dgvColPrice.Name].Value.ToString());
            decimal priceperbase = price / qty;

            dr.Cells[dgvColQtyBaseUnit.Name].Value = qty;
            dr.Cells[dgvColPrice.Name].Value = price;
            dr.Cells[dgvColPriceBase.Name].Value = priceperbase;   
        }

        public void RaiseRefreshEvents(string key)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                IItemSubscriber itemForm = Application.OpenForms[i] as IItemSubscriber;
                if (itemForm != null)
                {
                    itemForm.OnItemChanged(key);
                }
            }
        }

        private void rdo_Click(object sender, EventArgs e)
        {
        }

    

        private void controlsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Control c = (Control)sender;
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            txtBalance.Select(0, txtBalance.Text.Length);
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            if (ItemID == "")
            {
                var oops = from i in ItemService.GetAllItems() where i.Code == txtCode.Text select i;
                if (oops.ToList().Count > 0)
                {
                    MessageBox.Show("Code No " + txtCode.Text + "  is Already Existed.Please Select Another Code ");
                    txtCode.Focus();
                    txtCode.SelectAll();
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUOM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvColPrice.Index || e.ColumnIndex == dgvColQtyBaseUnit.Index)
            {
                RefreshAmounts(dgvUOM.Rows[e.RowIndex]);
            }
        }


        private void cboBasicUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBasicUOM.SelectedValue != null)
            {
                UOM uom = (UOM)cboBasicUOM.SelectedValue;

                foreach (DataGridViewRow dr in dgvUOM.Rows)
                {
                        dr.Cells[dgvColisBaseUnit.Name].Value = false;
                        if (Convert.ToBoolean( dr.Cells[dgvColPick.Name].Value) == false)
                        {
                            dr.Cells[dgvColQtyBaseUnit.Name].Value = null;
                        }
                }

                foreach (DataGridViewRow dr in dgvUOM.Rows)
                {
                    if (dr.Cells[dgvCol_UOMID.Name].Value.ToString() == uom.UOMID)
                    {
                        dr.Cells[dgvColPick.Name].Value = true;
                        dr.Cells[dgvColisBaseUnit.Name].Value = true;
                        dr.Cells[dgvColQtyBaseUnit.Name].Value = 1;
                        dr.Cells[dgvColPrice.Name].Value = txtPriceBaseUnit.Text;
                        dr.Cells[dgvColPriceBase.Name].Value = txtPriceBaseUnit.Text;
                    }
                }

                foreach (DataGridViewRow dr in dgvBeginning.Rows)
                {
                    dr.Cells[dgvColBasicUOM.Name].Value = uom.Code;
                }
                dgvBeginning.ClearSelection();
            }
        }

        private void txtPriceBaseUnit_Validated(object sender, EventArgs e)
        {
            if (cboBasicUOM.SelectedValue != null)
            {
                UOM uom = (UOM)cboBasicUOM.SelectedValue;

                foreach (DataGridViewRow dr in dgvUOM.Rows)
                {
                    if (dr.Cells[dgvCol_UOMID.Name].Value.ToString() == uom.UOMID)
                    {
                        dr.Cells[dgvColPick.Name].Value = true;
                        dr.Cells[dgvColPrice.Name].Value = txtPriceBaseUnit.Text;
                        dr.Cells[dgvColPriceBase.Name].Value = txtPriceBaseUnit.Text;

                    }
                }
            }
        }

        private void cmdEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Changing Item Balances can effect instability of the system. Are you sure you want to edit Item Balances? ", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            {
                if(dr==DialogResult.Yes)
                {
                    cmdEdit.Visible=false;
                    dgvBeginning.Enabled=true;
                }
            }
        }

    }
}
