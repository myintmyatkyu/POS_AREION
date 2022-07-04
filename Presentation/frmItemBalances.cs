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
    public partial class frmItemBalances : Form
    {
        public frmItemBalances()
        {
            InitializeComponent();
            cboStore.DataSource = StoreService.GetAllStores();
            
        }

        public void LoadItems(string storeID)
        {
            dgv.Rows.Clear();
            foreach (Item i in ItemService.GetAllItems())
            {
                ItemUOM defaultiu=new ItemUOM();
                if (i.UOMs.Count > 1)
                {
                    defaultiu = i.UOMs.Find(a => a.isDefault);
                    //if (i.QtyInHand % defaultiu.QtyInBaseUnit != 0)
                    //{
                    //    decimal roundedValue = Math.Round(i.QtyInHand / defaultiu.QtyInBaseUnit, 0, MidpointRounding.AwayFromZero);
                    //}
                    //decimal roundedValue = Math.Round(i.QtyInHand / defaultiu.QtyInBaseUnit, 2, MidpointRounding.AwayFromZero);
                    //decimal roundedValue = Math.Floor(i.QtyInHand / defaultiu.QtyInBaseUnit);
                    decimal qtyInHand = Convert.ToDecimal(i.Stocks.Count == 0 ? 0 : i.Stocks.FirstOrDefault(s => s.Store.ID == storeID) == null ? 0 : i.Stocks.FirstOrDefault(s => s.Store.ID == storeID).Balance);
                    decimal roundedValue = Math.Floor(qtyInHand/defaultiu.QtyInBaseUnit);
                    if (Convert.ToInt32((qtyInHand % defaultiu.QtyInBaseUnit)) == 0)
                    {
                        dgv.Rows.Add(new object[] { i.ItemID, i.Code, i.Name, i.Description, qtyInHand + " " + i.CurrentUOM.UOM.Code, roundedValue + " " + defaultiu.UOM.Code + "   "});
                    }
                    else
                    {
                        dgv.Rows.Add(new object[] { i.ItemID, i.Code, i.Name, i.Description, qtyInHand + " " + i.CurrentUOM.UOM.Code, roundedValue + " " + defaultiu.UOM.Code + "   " + Convert.ToInt32((qtyInHand % defaultiu.QtyInBaseUnit)).ToString() + " " + i.CurrentUOM.UOM.Code });
                    }
                }
                else
                {
                    decimal qtyInHand = Convert.ToDecimal(i.Stocks.Count == 0 ? 0 : i.Stocks.FirstOrDefault(s => s.Store.ID == storeID) == null ? 0 : i.Stocks.FirstOrDefault(s => s.Store.ID == storeID).Balance);
                    dgv.Rows.Add(new object[] { i.ItemID, i.Code, i.Name, i.Description, qtyInHand + " " + i.CurrentUOM.UOM.Code, qtyInHand+ " " + i.CurrentUOM.UOM.Code});
                }
            }
            lblTotal.Text = "Total Records :" + dgv.Rows.Count.ToString();
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems(cboStore.SelectedValue.ToString());
        }

    }
}
