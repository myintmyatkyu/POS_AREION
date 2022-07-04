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
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
            LoadExpensesTitle();
        }

        private void LoadExpensesTitle()
        {
            cboExpense.DataSource = ExpenseService.GetUniqueExpenses();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                Expense expense = new Expense();
                expense.ExpenseID = System.Guid.NewGuid().ToString();
                expense.Amount = Convert.ToInt32(txtAmount.Text);
                expense.Date = dtpDate.Value;
                expense.Remarks = txtRemarks.Text;
                expense.Title = cboExpense.Text;
                ExpenseService.Save(expense);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.IsNumeric(sender, e);
        }
    }
}
