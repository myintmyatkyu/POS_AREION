using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using POSModel;
using System.Data;

namespace POSDataAccess
{
    public class StoreTransferDetailDataUtility
    {
        public void Save(StoreTransferDetail detail)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into StoreTransferDetail(STN,ItemID,UOMID,Qty,QtyBaseUnit) values(@STN,@ItemID,@UOMID,@Qty,@QtyBaseUnit)";
                sqlcmd.Parameters.AddWithValue("@STN", detail.STN);
                sqlcmd.Parameters.AddWithValue("@ItemID", detail.Item.ItemID);
                sqlcmd.Parameters.AddWithValue("@UOMID", detail.UOM.UOMID);
                sqlcmd.Parameters.AddWithValue("@Qty", detail.Qty);
                sqlcmd.Parameters.AddWithValue("@QtyBaseUnit", detail.QtyBaseUnit);
                new DataUtilities().Insert(sqlcmd);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StoreTransferDetail> GetStoreTransferDetails(string STN)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from StoreTransferDetail where STN=@STN";
                sqlcmd.Parameters.AddWithValue("@STN", STN);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<StoreTransferDetail> details = new List<StoreTransferDetail>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        details.Add(BuildObject(dr));
                    }
                }
                return details;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public StoreTransferDetail BuildObject(DataRow dr)
        {
            try
            {
                StoreTransferDetail d = new StoreTransferDetail();
                d.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                d.Qty = Convert.ToDecimal(dr["Qty"].ToString());
                d.QtyBaseUnit = Convert.ToDecimal(dr["QtyBaseUnit"].ToString());
                d.STN = dr["STN"].ToString();
                d.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                return d;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
