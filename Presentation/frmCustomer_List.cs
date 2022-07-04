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
    public partial class frmCustomer_List : Form,IRefreshable<Customer>
    {
        public frmCustomer_List()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgv.DataSource = CustomerService.GetAllCustomers();
            lblTotal.Text = dgv.Rows.Count.ToString();

            //dgv.Rows.Add(new object[]{"IT Current","Myint Myat Kyu","3rd Floor, Myaynegone Plaza,Sanchaung","0936029871","","","mmk@gmail.com","Myint Myat Kyu","14/MaMaNa(Naing)197903","","ADG Kamyayut"});
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new frmCustomer().Show();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {

        }

        #region ICustomer Members

        public void OnCustomerChanged(object key)
        {
            dgv.DataSource = CustomerService.GetAllCustomers();
            lblTotal.Text = dgv.Rows.Count.ToString();
            Global.GridSort(dgv,key);
        }

        #endregion

        #region IRefreshable<Customer> Members

        public void OnListChanged(object key)
        {
            dgv.DataSource = CustomerService.GetAllCustomers();
            lblTotal.Text = dgv.Rows.Count.ToString();
            Global.GridSort(dgv, key);
        }

        #endregion

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            new frmCustomer().Show();
        }

        private void cmdEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                new frmCustomer(dgv.CurrentRow.Cells["dgvCol_CustomerID"].Value.ToString()).Show();

            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null && e.RowIndex!=-1)
            {
                new frmCustomer(dgv.CurrentRow.Cells["dgvCol_CustomerID"].Value.ToString()).Show();

            }
        }
    }
}
