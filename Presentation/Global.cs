using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    public static class Global
    {
        public static int UserID=1;
        public static void GridSort(DataGridView datagrid, object key)
        {
            DataGridViewRowCollection dgvRows = datagrid.Rows;
            int index = -1;
            for (int rowIndex = 0; rowIndex < dgvRows.Count; rowIndex++)
            {
                    if (dgvRows[rowIndex].Cells[0].Value.Equals(key))
                    {
                        index = rowIndex;
                        goto Here;
                    }

                
            }
        Here:
            if (index != -1)
            {
               // datagrid.Rows[index].Selected = true;
                datagrid.CurrentCell = datagrid.Rows[index].Cells[1];
            }
        }

        public static void GridSort(DataGridView datagrid, object key,string primaryKeyColumnName,string AVisibleColumnName)
        {
            DataGridViewRowCollection dgvRows = datagrid.Rows;
            int index = -1;
            for (int rowIndex = 0; rowIndex < dgvRows.Count; rowIndex++)
            {
                if (dgvRows[rowIndex].Cells[primaryKeyColumnName].Value.Equals(key))
                {
                    index = rowIndex;
                    goto Here;
                }


            }
        Here:
            if (index != -1)
            {
                // datagrid.Rows[index].Selected = true;
                datagrid.CurrentCell = datagrid.Rows[index].Cells[AVisibleColumnName];
            }
        }

        public static void IsNumeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #region ForUserAccountLogin
        public static string uname;
        public static string uID;
        public static string uLevel;
        public static string sLoginTime;
        public static string btnStatus;
        #endregion

        #region ForUserAccountLogin
        public static string DataSource;
        public static string InitialCatalog;
        public static string DBUserID;
        public static string Password;
        //public static string btnStatus;
        #endregion

    }
}
