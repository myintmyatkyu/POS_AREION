using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class UOMService
    {
        public static void Save(UOM uom)
        {
            try
            {
                if (uom.UOMID == "")
                {
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandText = "Insert into UOM(UOMID,Code,Description) values(@UOMID,@Code,@Description)";
                    sqlcmd.Parameters.AddWithValue("@UOMID", uom.UOMID == "" ? System.Guid.NewGuid().ToString() : uom.UOMID);
                    sqlcmd.Parameters.AddWithValue("@Code", uom.Code);
                    sqlcmd.Parameters.AddWithValue("@Description", uom.Description);

                    new DataUtilities().Insert(sqlcmd);
                }
                else
                {
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandText = "Update UOM set Code=@Code,Description=@Description where UOMID=@UOMID";
                    sqlcmd.Parameters.AddWithValue("@UOMID", uom.UOMID == "" ? System.Guid.NewGuid().ToString() : uom.UOMID);
                    sqlcmd.Parameters.AddWithValue("@Code", uom.Code);
                    sqlcmd.Parameters.AddWithValue("@Description", uom.Description);

                    new DataUtilities().Insert(sqlcmd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable GetAllUOMs()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from UOM";
                return new DataUtilities().Select_Datatable(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<UOM> GetAllUOMList()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from UOM";
                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<UOM> uoms = new List<UOM>();
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        UOM uom = new UOM();
                        uom.UOMID = dr["UOMID"].ToString();
                        uom.Description = dr["Description"].ToString();
                        uom.Code = dr["Code"].ToString();
                        uoms.Add(uom);
                    }
                }
                return uoms;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
