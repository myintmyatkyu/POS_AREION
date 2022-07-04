using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data; 

namespace POSDataAccess
{
    public class StoreTransferHeaderDataUtility
    {
        public void Save(StoreTransferHeader transfer)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into StoreTransferHeader(STN,Date,FromStore,ToStore,IssuedBy) values(@STN,@Date,@FromStore,@ToStore,@IssuedBy)";
                sqlcmd.Parameters.AddWithValue("@STN", transfer.STN);
                sqlcmd.Parameters.AddWithValue("@Date", transfer.Date);
                sqlcmd.Parameters.AddWithValue("@FromStore", transfer.FromStore.ID);
                sqlcmd.Parameters.AddWithValue("@ToStore", transfer.ToStore.ID);
                sqlcmd.Parameters.AddWithValue("@IssuedBy", transfer.IssuedBy);

                new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetLastInvoiceNo(int leftCount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select Top 1 Right(STN,"+leftCount+") from StoreTransferHeader where SubString(STN,0,7)=RIGHT('0' + RTRIM(Year(GETDATE())), 2)+RIGHT('0' + RTRIM(MONTH(GETDATE())), 2)+RIGHT('0' + RTRIM(Day(GETDATE())), 2) order by RIGHT(STN,6) desc";

                object obj = new DataUtilities().SelectValue(sqlcmd);
                if (obj == DBNull.Value)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StoreTransferHeader> GetAllStoreTransferHeader(DateTime from,DateTime to)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from StoreTransferHeader where Convert(date,Date) >= Convert(date,@fromDate) and Convert(date,Date) <=Convert(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@fromDate", from);
                sqlcmd.Parameters.AddWithValue("@toDate", to);

                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<StoreTransferHeader> headers = new List<StoreTransferHeader>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    { 
                        headers.Add(BuildObject(dr));
                    }
                }
                return headers;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StoreTransferHeader BuildObject(DataRow dr)
        {
            try
            {
                StoreTransferHeader h = new StoreTransferHeader();
                h.Date = Convert.ToDateTime(dr["Date"]);
                h.Details = new StoreTransferDetailDataUtility().GetStoreTransferDetails(dr["STN"].ToString());
                h.FromStore = new StoreDataUtility().GetStore(dr["FromStore"].ToString());
                h.ToStore = new StoreDataUtility().GetStore(dr["ToStore"].ToString());
                h.STN = dr["STN"].ToString();
                h.IssuedBy = dr["IssuedBy"].ToString();
                return h;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
