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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMain.Controls.Clear();
            frmItems frm = new frmItems();
            frm.TopLevel=false;
            panelMain.Controls.Add(frm);
        }

        private void llbProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            panelMain.Controls.Clear();
            frmItems frm = new frmItems();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void SetActive(object sender)
        {
            foreach (Control panel in tlp.Controls)
            {
                if (panel.Visible == true)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is LinkLabel)
                        {
                            c.BackColor = Color.FromArgb(240, 238, 238);
                            ((LinkLabel)c).LinkColor = Color.FromArgb(64, 64, 64);
                        }
                    }
                }
            }

            ((Control)sender).BackColor = Color.FromArgb(124, 123, 173);
            ((LinkLabel)sender).LinkColor = Color.White; 
        }

        private void SetActiveHeader(object sender, Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                {
                    //c.BackColor = Color.DimGray;
                    c.ForeColor = Color.DarkGray;
                }
            }
            ((Control)sender).ForeColor = Color.White;
        }

        private void mnuCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            panelMain.Controls.Clear();
            frmCustomer_List frm = new frmCustomer_List();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            
            ClearMenus();
            panelLogo.Visible = false;
            panelMain.Controls.Clear();
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llbSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmSale_NewVersion().Show();
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelSetting.Visible = true;
            panelProducts.Visible = true;

        }

        private void cmdSale_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelSale.Visible = true;
            panelProducts.Visible = true;
        }
        public void ClearMenus()
        {
            foreach (Control c in tlp.Controls)
            {
                if (c is Panel && c.Name !="panelLogo")
                {
                    c.Visible = false;
                }
            }
            panelLogo.Visible = true;
        }



        private void llbSales_Products_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            
            frmItems frm = new frmItems();
            frm.TopLevel = false;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llbPurchases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmPurchase_New frm = new frmPurchase_New();
            frm.Show();
        }

        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelPurchase.Visible = true;
            panelProducts.Visible = true;
        }


        private void llbSuppliers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);

            frmSupplier_List frm = new frmSupplier_List();
            frm.TopLevel = false;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();

            cmdSale.PerformClick();
        }

        private void cmdPayments_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelPayments.Visible = true;
        }

        private void llbPaymentCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPaymentCustomer().Show();
        }

        private void llbPaymentSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPaymentSupplier().Show();
        }

        private void llbSaleList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmSale_List frm = new frmSale_List();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
            
        }

        private void llbSaleReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmSaleReturn().Show();
        }

        private void llbPurchasesList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmPurchase_List frm = new frmPurchase_List();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llUOM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmUOM frm = new frmUOM();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llbCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmCompany frm = new frmCompany();
            frm.Show();
        }

        private void cmdReports_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelReports.Visible = true;
        }

        private void llbDailySale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmDailySale frm = new frmDailySale();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
            
        }

        private void llbMonthlySale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            //new frmSaleByItem().Show();
            frmSaleByItem frm = new frmSaleByItem();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llbItemBalance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            //new frmSaleByItem().Show();
            frmItemBalances frm = new frmItemBalances();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void llbStoreTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            new frmStoreTransfer().Show();
           
        }

        private void cmdStore_Click(object sender, EventArgs e)
        {
            SetActiveHeader(sender, panelTop);
            ClearMenus();
            panelStore.Visible = true;
            panelProducts.Visible = true;
        }

        private void llbStoreTransferList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmStoreTransferList frm = new frmStoreTransferList();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show(); 
        }

        private void llbPurchaseByItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmPurchaseByItem frm = new frmPurchaseByItem();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show(); 
        }

        private void llbPurchaseDateRange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmPurchaseByDate frm = new frmPurchaseByDate();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show(); 
        }

        private void llbProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetActive(sender);
            frmCategory frm = new frmCategory();
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.Show(); 
        }

    }
}
