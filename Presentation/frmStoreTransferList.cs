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
    public partial class frmStoreTransferList : Form
    {
        public frmStoreTransferList()
        {
            InitializeComponent();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHeader.Rows.Clear();
                List<StoreTransferHeader> headers = StoreTransferService.GetAllStoreTransfer(dtpFrom.Value.Date,dtpTo.Value.Date);
                foreach (StoreTransferHeader header in headers)
                {
                    dgvHeader.Rows.Add(new object[] { header, header.STN, header.FromStore.Name,header.ToStore.Name, header.Date.ToString("dd/MMM/yyyy")});
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
                    StoreTransferHeader header = (StoreTransferHeader)dgvHeader.CurrentRow.Cells[dgvColHeader.Name].Value;
                    foreach (StoreTransferDetail sd in header.Details)
                    {
                        dgvDetail.Rows.Add(new object[] { sd.Item.Name, sd.UOM.Code,sd.Qty,sd.QtyBaseUnit });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
