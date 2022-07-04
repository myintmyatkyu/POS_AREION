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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();

            LoadCompany();

        }

        private void LoadCompany()
        {
            if (CompanyService.isExist())
            {
                Company company = CompanyService.GetCompanyTopOne();
                txtAddress.Text = company.Address;
                txtCompany.Text = company.CompanyName;
                txtDescription.Text = company.Description;
                txtFaxNo.Text = company.FaxNo;
                txtOpenDaily.Text = company.OpenDaily;
                txtPhoneNo.Text = company.PhoneNo;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company();
                company.CompanyID = Guid.NewGuid().ToString();
                company.Description = txtDescription.Text;
                company.CompanyName = txtCompany.Text;
                company.Address = txtAddress.Text;
                company.FaxNo = txtFaxNo.Text;
                company.OpenDaily = txtOpenDaily.Text;
                company.PhoneNo = txtPhoneNo.Text;

                CompanyService.Save(company);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
