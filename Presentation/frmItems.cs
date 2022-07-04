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
    public partial class frmItems : Form,IItemSubscriber
    {
        public frmItems()
        {
            InitializeComponent();
            LoadItems();
        }

        public void LoadItems()
        {
            dgv.Rows.Clear();
            foreach (Item i in ItemService.GetAllItems())
            {
                dgv.Rows.Add(new object[] { i.ItemID, i.Code, i.Name, i.Description, i.CurrentUOM.PricePerCurrentUnit,i.CurrentUOM.UOM.Code});
            }
            lblTotal.Text = "Total Records :" + dgv.Rows.Count.ToString();
        }

        #region IItemSubscriber Members

        public void OnItemChanged(object key)
        {
            LoadItems();
        }

        #endregion

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            new frmItem().Show();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmdEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                new frmItem(dgv.CurrentRow.Cells[dgvColItemID.Name].Value.ToString()).Show();
            }
        }

        private void llbPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dsReports.ItemDataTable dt = new dsReports.ItemDataTable();
            int count = 1;
            foreach (Item i in ItemService.GetAllItems().OrderBy(i => i.Code))
            {
                dsReports.ItemRow item = dt.NewItemRow();
                Company com = CompanyService.GetCompanyTopOne();
                item.Company = com.CompanyName;
                item.ComDescription = com.Description;
                item.Address = com.Address;
                item.PhoneNo = com.PhoneNo;
                item.Code = i.Code;
                item.Name = i.Name;
                item.Description = i.Description;
                item.PriceCurrentUnit = i.UOMs.Find(a => a.isDefault == true).PricePerCurrentUnit;
                item.UOM = i.UOMs.Find(a => a.isDefault == true).UOM.Code;
                item.SrNo = count++;
                //item.BalanceDefaultUnit = i.Stocks.Find(a => a.Store.ID == "1") == null ? 0 : i.Stocks.Find(a => a.Store.ID == "1").Balance;
                dt.Rows.Add(item);
            }
            //crptItems rpt = new crptItems();
            //rpt.SetDataSource(dt.DefaultView);
            //new frmPreview(rpt).Show();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
