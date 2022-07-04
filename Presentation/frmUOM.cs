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
    public partial class frmUOM : Form
    {
        public frmUOM()
        {
            InitializeComponent();
        }

        private void frmUOM_Load(object sender, EventArgs e)
        {
            dgv.DataSource = UOMService.GetAllUOMs();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvColSave.Index)
                {
                    if (dgv.CurrentRow.Cells[dgvCol_Code.Name].Value == DBNull.Value)
                    {
                        MessageBox.Show("Code Field cannot be blank");
                        return;
                    }

                    UOM uom = new UOM();
                    uom.Code = dgv.CurrentRow.Cells[dgvCol_Code.Name].Value.ToString();
                    uom.Description = dgv.CurrentRow.Cells[dgvCol_Description.Name].Value.ToString();
                    uom.UOMID = dgv.CurrentRow.Cells[dgvCol_UOMID.Name].Value == null ? "" : dgv.CurrentRow.Cells[dgvCol_UOMID.Name].Value.ToString();

                    UOMService.Save(uom);
                    MessageBox.Show("Saving Successful");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
