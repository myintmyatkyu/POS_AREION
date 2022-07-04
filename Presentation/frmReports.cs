using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            bool isFound = false;
            foreach (Control c in spc.Panel2.Controls)
            {
                c.Hide();
            }
            if (e.Node.Name == "nSaleByDate")
            {
                foreach (Control c in spc.Panel2.Controls)
                {
                    if (c is frmDailySale)
                    {
                        isFound = true;
                        frmDailySale frmdailysale = (frmDailySale)c;
                        frmdailysale.Show();
                        return;
                    }
                }

                frmDailySale frm = new frmDailySale();
                frm.TopLevel = false;
                spc.Panel2.Controls.Add(frm);
                frm.Show();
            }
            else if (e.Node.Name == "nSaleByItem")
            {

                foreach (Control c in spc.Panel2.Controls)
                {
                    if (c is frmSaleByItem)
                    {
                        isFound = true;
                        frmSaleByItem frmA = (frmSaleByItem)c;
                        frmA.Show();
                        return;
                    }
                }

                frmSaleByItem frm = new frmSaleByItem();
                frm.TopLevel = false;
                spc.Panel2.Controls.Add(frm);
                frm.Show();
            }
            else if (e.Node.Name == "nPurchaseByItem")
            {

                foreach (Control c in spc.Panel2.Controls)
                {
                    if (c is frmPurchaseByItem)
                    {
                        isFound = true;
                        frmPurchaseByItem frmA = (frmPurchaseByItem)c;
                        frmA.Show();
                        return;
                    }
                }

                frmPurchaseByItem frm = new frmPurchaseByItem();
                frm.TopLevel = false;
                spc.Panel2.Controls.Add(frm);
                frm.Show();
            }

            else if (e.Node.Name == "nPurchaseByDate")
            {

                foreach (Control c in spc.Panel2.Controls)
                {
                    if (c is frmPurchaseSearchByDate)
                    {
                        isFound = true;
                        frmPurchaseSearchByDate frmA = (frmPurchaseSearchByDate)c;
                        frmA.Show();
                        return;
                    }
                }

                frmPurchaseSearchByDate frm = new frmPurchaseSearchByDate();
                frm.TopLevel = false;
                spc.Panel2.Controls.Add(frm);
                frm.Show();
            }

            else if (e.Node.Name == "nStock")
            {

                foreach (Control c in spc.Panel2.Controls)
                {
                    if (c is frmStockList)
                    {
                        isFound = true;
                        frmStockList frmA = (frmStockList)c;
                        frmA.Show();
                        return;
                    }
                }

                frmStockList frm = new frmStockList();
                frm.TopLevel = false;
                spc.Panel2.Controls.Add(frm);
                frm.Show();
            }
        }
    }
}
