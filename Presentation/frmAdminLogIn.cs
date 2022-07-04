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
    public partial class frmAdminLogIn : Form
    {
        public frmAdminLogIn()
        {
            InitializeComponent();
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "9900")
            {
                this.Close();
                new frmMainForm().ShowDialog();
            }
            else
            {
                txtPassword.SelectAll();
                MessageBox.Show("Password is incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdLogIn.PerformClick();
            }
        }
    }
}
