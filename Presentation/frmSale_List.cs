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
    public partial class frmSale_List : Form,ISaleHeader,IPayment,ICustomer
    {
        private const string txtCustomerText = "Type to Search Customers";
        public frmSale_List()
        {
            InitializeComponent();
        }

        private void frmSale_List_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = CustomerService.GetAllCustomers().OrderBy(i => i.Name).ToList() ;
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSales.Columns[e.ColumnIndex].Name == dgvCol_DetailView.Name)
            {
                string mainVoucherNo = dgvSales.CurrentRow.Cells["dgvCol_VoucherNo"].Value.ToString();
                new frmSaleDetailList(mainVoucherNo).ShowDialog();
            }
          
            

          
        }

        private void txtCustomers_Enter(object sender, EventArgs e)
        {
            if (txtCustomers.Text == txtCustomerText)
            {
                txtCustomers.Clear();
            }

        }

        private void txtCustomers_Validated(object sender, EventArgs e)
        {
            if (txtCustomers.Text == "")
            {
                txtCustomers.Text = txtCustomerText;
            }
        }

        private void txtCustomers_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomers.Text != txtCustomerText && txtCustomers.Text != "")
            {
                this.txtCustomers.Font = new System.Drawing.Font("ZawGyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtCustomers.ForeColor = System.Drawing.Color.Black;

                dgvCustomer.DataSource = CustomerService.FindByName(txtCustomers.Text);

            }
            else
            {
                this.txtCustomers.Font = new System.Drawing.Font("ZawGyi-One", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtCustomers.ForeColor = System.Drawing.Color.DimGray;
                dgvCustomer.DataSource = CustomerService.GetAllCustomers();
            }
        }

        private void cmdNewCustomer_Click(object sender, EventArgs e)
        {
            new frmCustomer().Show();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            new frmSale(lblName.Tag.ToString()).Show();
        }



        private void cmdEditCustomer_Click(object sender, EventArgs e)
        {
            new frmCustomer(dgvCustomer.CurrentRow.Cells["dgvCol_CustomerID"].Value.ToString()).Show();
        }

        private void dgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblCustomerCount.Text = dgvCustomer.Rows.Count.ToString();
        }

        private void frmSale_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                cmdNewSale.PerformClick();
            }
        }

        private void cmdViewPayment_Click(object sender, EventArgs e)
        {
            new frmPaymentTransactions(lblName.Tag.ToString()).ShowDialog();
        }

        #region ISaleHeader Members

        public void OnSaleChanged(object key)
        {
            Customer c = SaleHeaderService.GetSaleHeader(key.ToString()).Customer;
            dgvCustomer.DataSource = CustomerService.GetAllCustomers();
            Global.GridSort(dgvCustomer, c.CustomerID);
            //dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Selected = true;
        }

        #endregion

        #region IPayment Members

        public void OnPaymentChanged(object key)
        {
            Customer c = SaleHeaderService.GetSaleHeader(key.ToString()).Customer;
            dgvCustomer.DataSource = CustomerService.GetAllCustomers();
            //dgvCustomer.Refresh();
            Global.GridSort(dgvCustomer, c.CustomerID);
            //dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Selected = true;

        }

        #endregion

        #region ICustomer Members

        public void OnCustomerChanged(object key)
        {
            Customer c = CustomerService.GetCustomer(key.ToString()); ;
            dgvCustomer.DataSource = CustomerService.GetAllCustomers();
            Global.GridSort(dgvCustomer, c.CustomerID);
            //dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Selected = true;
        }

        #endregion

        private void cmdGiveDiscount_Click(object sender, EventArgs e)
        {
            new frmCustomerDiscount(dgvCustomer.CurrentRow.Cells["dgvCol_CustomerID"].Value.ToString()).Show();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCustomerData();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (lblName.Tag == null)
            {
                MessageBox.Show("Please choose Customer First");
                return;
            }
            Customer customer = CustomerService.GetCustomer(lblName.Tag.ToString());
            List<SaleHeader> sales = SaleHeaderService.GetSaleHeaders(customer.CustomerID).Where(i => i.Date.Date >= dtpFrom.Value.Date && i.Date.Date <= dtpTo.Value.Date).ToList();
            dgvSales.Rows.Clear();
            int totalSummary = 0;
            foreach (SaleHeader sale in sales)
            {
                totalSummary += sale.NetAmount;
                dgvSales.Rows.Add(new object[] { sale.VoucherNo, sale.Date, sale.Amount, sale.TotalDiscount, sale.NetAmount ,sale.PaidAmount,sale.Credit});
            }
            lblTotalSummary.Text = totalSummary.ToString("#,###");
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            if (lblName.Tag == null)
            {
                MessageBox.Show("Please choose Customer First");
                return;
            }
            Customer customer = CustomerService.GetCustomer(lblName.Tag.ToString());
            List<SaleHeader> sales = SaleHeaderService.GetSaleHeaders(customer.CustomerID);
            dgvSales.Rows.Clear();
            int totalSummary = 0;
            foreach (SaleHeader sale in sales)
            {
                totalSummary += sale.NetAmount;
                dgvSales.Rows.Add(new object[] { sale.VoucherNo, sale.Date, sale.Amount, sale.TotalDiscount, sale.NetAmount,sale.PaidAmount,sale.Credit });
            }
            lblTotalSummary.Text = totalSummary.ToString("#,###");
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.Focused == false ) 
            {
                return; 
            }
            
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                LoadCustomerData();
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                Customer customer = CustomerService.GetCustomer(dgvCustomer.SelectedRows[0].Cells[dgvCol_CustomerID.Name].Value.ToString());
                lblAddress.Text = customer.Address;
                lblContact.Text = customer.ContactPerson;
                lblCurrentCredit.Text = customer.CurrentCredit.ToString();
                lblCurrentDebit.Text = "0";
                lblName.Text = customer.Name;
                lblName.Tag = customer.CustomerID;
                lblPhone.Text = customer.Phone1 + ", " + customer.Phone2 + ", " + customer.Phone3;

                List<SaleHeader> sales = SaleHeaderService.GetSaleHeaders(customer.CustomerID);
                dgvSales.Rows.Clear();
                int totalSummary = 0;
                foreach (SaleHeader sale in sales)
                {
                    totalSummary += sale.NetAmount;
                    dgvSales.Rows.Add(new object[] { sale.VoucherNo, sale.Date, sale.Amount, sale.TotalDiscount, sale.NetAmount, sale.PaidAmount, sale.Credit });
                }
                lblTotalSummary.Text = totalSummary.ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Customer Data.... \n Detail:\n" + ex.ToString());
            }
        }

        private void cmdReceivePayment_Click(object sender, EventArgs e)
        {
            if (lblName.Tag != null)
            {
                new frmPaymentCustomer(lblName.Tag.ToString()).Show();
            }
            else
            {
                MessageBox.Show("Please choose Supplier first");
            }
        }
    }
}
