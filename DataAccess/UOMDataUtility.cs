using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class UOMDataUtility
    {
        public UOM GetUOM(string uomID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from UOM where UOMID=@UOMID";
                sqlcmd.Parameters.AddWithValue("@UOMID", uomID);

                UOM uom = new UOM();
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    uom.UOMID = dr["UOMID"].ToString();
                    uom.Description = dr["Description"].ToString();
                    uom.Code = dr["Code"].ToString();
                }
                return uom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
