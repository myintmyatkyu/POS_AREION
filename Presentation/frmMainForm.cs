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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            lv.Items[2].Remove();
        }


        private void lv_DoubleClick(object sender, EventArgs e)
        {
            if (lv.SelectedItems[0].Tag == "Sale")
            {
                new frmSale().Show();
            }
            if (lv.SelectedItems[0].Tag == "Sale (List Mode)")
            {
            
            }
            else if (lv.SelectedItems[0].Tag == "Customers")
            {
                new frmCustomer_List().Show();
            }
            else if (lv.SelectedItems[0].Tag == "CustomerCreditList")
            {
                new frmCustomerCreditList().Show();
            }
            else if (lv.SelectedItems[0].Tag == "Purchase")
            {
                
            }
            else if (lv.SelectedItems[0].Tag == "PurchaseList")
            {
                new frmPurchase_List().Show();
            }
            else if (lv.SelectedItems[0].Tag == "Expense")
            {
                new frmExpense().Show();
            }
            else if (lv.SelectedItems[0].Tag == "ExpenseList")
            {
                new frmExpenseList().Show();
            }
            else if (lv.SelectedItems[0].Tag == "Suppliers")
            {
                new frmSupplier_List().Show();
            }
            //else if (lv.SelectedItems[0].Tag == "Users")
            //{
            //    new frmUsers().Show();
            //}
            //else if (lv.SelectedItems[0].Tag == "Issue")
            //{
            //    new frmIssue().Show();
            //}
            else if (lv.SelectedItems[0].Tag == "Company Profile")
            {
                new frmCompany().Show();
            }
            //else if (lv.SelectedItems[0].Tag == "Settings")
            //{
            //    new frmSettings().Show();
            //}
            else if (lv.SelectedItems[0].Tag == "Items")
            {
                new frmItems().Show();
            }
            else if (lv.SelectedItems[0].Tag == "Reports")
            {
                new frmReports().Show();
            }
            else if (lv.SelectedItems[0].Tag == "UOM")
            {
                new frmUOM().Show();
            }
        }

        private void lv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                lv_DoubleClick(sender, new EventArgs());
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
