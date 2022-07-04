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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            dgv.Rows.Clear();
            foreach (Category cat in CategoryService.GetAllCategories())
            {
                dgv.Rows.Add(new object[] { cat.CategoryID,cat.Name,cat.Description});
            }
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvColSave.Index)
                {
                    if (dgv.CurrentRow.Cells[dgvColName.Name].Value == DBNull.Value)
                    {
                        MessageBox.Show("Name Field cannot be blank");
                        return;
                    }

                    Category obj = new Category();
                    obj.Name = dgv.CurrentRow.Cells[dgvColName.Name].Value.ToString();
                    obj.Description = dgv.CurrentRow.Cells[dgvColDescription.Name].Value == null ? "" : dgv.CurrentRow.Cells[dgvColDescription.Name].Value.ToString();
                    obj.CategoryID = dgv.CurrentRow.Cells[dgvColID.Name].Value == null ? "" : dgv.CurrentRow.Cells[dgvColID.Name].Value.ToString();

                    CategoryService.Save(obj);
                    MessageBox.Show("Saving Successful");
                    BindGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
