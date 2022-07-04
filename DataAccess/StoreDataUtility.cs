using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class StoreDataUtility
    {

        public Store BuildObject(DataRow dr)
        {
            try
            {
                Store store = new Store();
                store.ID = dr["ID"].ToString();
                store.Code = dr["Code"].ToString();
                store.Name = dr["Name"].ToString();
                return store;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Store> GetAllStores()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText="Select * from Store";

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Store> stores = new List<Store>();
                if(dt.Rows.Count>0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        stores.Add(BuildObject(dr));
                    }
                }
                return stores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Store GetStore(string storeID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText="Select * from Store where ID=@ID";
                sqlcmd.Parameters.AddWithValue("@ID",storeID);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                Store store = new Store();
                if(dt.Rows.Count>0)
                {
                    store=BuildObject(dt.Rows[0]);
                }
                return store;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
