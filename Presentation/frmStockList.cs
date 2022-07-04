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
    public partial class frmStockList : Form
    {
        List<Item> items;
        public frmStockList()
        {
            InitializeComponent();
            items = ItemService.GetAllItems();
            cboItemCode.DataSource = ItemService.GetAllItems();
            cboItemName.DataSource = ItemService.GetAllItems();
            cboItemCode.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            cboItemCode.SelectedItem = null;
            cboItemName.SelectedItem  = null;
            items = ItemService.GetAllItems();
            foreach (Item item in items)
            {
                int balance = ItemService.GetBalance(item.ItemID);
                dgv.Rows.Add(new object[] { item.ItemID, item.Code, item.Description, item.Category, item.Price, item.Remark, balance });
            }
            lblTotalCount.Text = dgv.Rows.Count.ToString();
        }

        private void cboItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv.Rows.Clear();
                Item item = (Item)cboItemCode.SelectedValue;
                int balance = ItemService.GetBalance(item.ItemID);
                dgv.Rows.Add(new object[] { item.ItemID, item.Code, item.Description, item.Category, item.Price, item.Remark, balance });
                lblTotalCount.Text = dgv.Rows.Count.ToString();
            }
        }

        private void cboItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv.Rows.Clear();
                Item item = (Item)cboItemName.SelectedValue;
                int balance = ItemService.GetBalance(item.ItemID);
                dgv.Rows.Add(new object[] { item.ItemID, item.Code, item.Description, item.Category, item.Price, item.Remark, balance });
                lblTotalCount.Text = dgv.Rows.Count.ToString();
            }
        }


    }
}
