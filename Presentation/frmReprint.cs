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
    public partial class frmReprint : Form
    {
        public frmReprint()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHeader.Rows.Clear();
                List<SaleHeader> headers = SaleHeaderService.GetSaleHeaders(dtp.Value);
                foreach (SaleHeader header in headers)
                {
                    dgvHeader.Rows.Add(new object[] { header, header.VoucherNo,header.Customer.Name, header.Date, header.NetAmount });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHeader_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvHeader.CurrentRow != null)
                {
                    dgvDetail.Rows.Clear();
                    SaleHeader header = (SaleHeader)dgvHeader.CurrentRow.Cells[dgvColHeader.Name].Value;
                    foreach (SaleDetail sd in header.SaleDetail)
                    {
                        dgvDetail.Rows.Add(new object[] { sd.Item.Name, sd.Price, sd.Qty, sd.NetAmount });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (e.ColumnIndex == dgvColPrint.Index)
            { 
                if(dgvHeader.CurrentRow!=null)
                {
                    SaleHeader sh = (SaleHeader) dgvHeader.CurrentRow.Cells[dgvColHeader.Name].Value;
                    Print(sh.VoucherNo);
                }
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print(string invoiceNo)
        {
            SaleHeader sh = SaleHeaderService.GetSaleHeader(invoiceNo);
            dsReports.SaleInvoiceDataTable dt = new dsReports.SaleInvoiceDataTable();
            Company company = CompanyService.GetCompanyTopOne();
            int emptyRowCount = 0;
            foreach (SaleDetail sd in sh.SaleDetail)
            {
                dsReports.SaleInvoiceRow dr = dt.NewSaleInvoiceRow();
                dr.Address = company.Address;
                dr.Company = company.CompanyName;
                dr.Description = company.Description;
                dr.OpenDaily = company.OpenDaily;
                dr.PhoneNo = company.PhoneNo;


                dr.CustomerName = sh.Customer.Name;
                dr.InvoiceNo = sh.VoucherNo;
                dr.Date = sh.Date;
                dr.TotalAmount = sh.Amount;
                dr.Discount = sh.TotalDiscount;
                dr.NetAmount = sh.NetAmount;
                dr.PaidAmount = sh.PaidAmount;
                dr.Credit = Convert.ToInt32(sh.Credit);

                dr.Amount = sd.NetAmount;
                dr.Item = sd.Item.Name;
                dr.UOM = sd.UOM.Code;
                dr.Price = sd.Price;
                dr.Qty = sd.Qty.ToString();
                dr.Discount = sh.TotalDiscount;
                dt.Rows.Add(dr);
            }

            if (sh.SaleDetail.Count < 10)
            {
                emptyRowCount = 10 - sh.SaleDetail.Count;
                for (int i = 0; i < emptyRowCount; i++)
                {
                    dsReports.SaleInvoiceRow dr = dt.NewSaleInvoiceRow();
                    dr.Address = company.Address;
                    dr.Company = company.CompanyName;
                    dr.Description = company.Description;
                    dr.OpenDaily = company.OpenDaily;
                    dr.PhoneNo = company.PhoneNo;


                    dr.CustomerName = sh.Customer.Name;
                    dr.InvoiceNo = sh.VoucherNo;
                    dr.Date = sh.Date;
                    dr.TotalAmount = sh.Amount;
                    dr.Discount = sh.TotalDiscount;
                    dr.NetAmount = sh.NetAmount;
                    dr.PaidAmount = sh.PaidAmount;
                    dr.Credit = Convert.ToInt32(sh.Credit);

                    dt.Rows.Add(dr);
                }
            }



            //crpt_SaleInvoice_Daylia crpt = new crpt_SaleInvoice_Daylia();
            //crpt.SetDataSource(dt.DefaultView);
            //frmPreview frm = new frmPreview(crpt);
            //frm.Show();
            //crpt.PrintToPrinter(1, true, 0, 999);

        }
    }
}
