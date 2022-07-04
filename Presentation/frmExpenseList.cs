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
    public partial class frmExpenseList : Form
    {
        public frmExpenseList()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
           dgv.DataSource =  ExpenseService.GetExpenseSummary(dtpFrom.Value, dtpTo.Value);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                double amount = Convert.ToDouble(dr.Cells["dgvCol_Amount"].Value);
                total += amount;
            }
            lblTotal.Text = total.ToString();
        }
    }
}
