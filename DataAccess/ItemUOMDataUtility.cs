using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class ItemUOMDataUtility
    {
        public List<ItemUOM> GetAllItemUOM()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Item_UOM";
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<ItemUOM> results = new List<ItemUOM>();
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        results.Add(BuildItemUOM(dr));
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItemUOMs(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Delete from Item_UOM where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);

                new DataUtilities().Delete(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ItemUOM> GetAllItemUOM(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Item_UOM where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<ItemUOM> results = new List<ItemUOM>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        results.Add( BuildItemUOM(dr));
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ItemUOM BuildItemUOM(DataRow dr)
        {
            try
            {
                ItemUOM ituom = new ItemUOM();
                ituom.ItemID = dr["ItemID"].ToString();
                ituom.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                ituom.isBaseUnit = Convert.ToBoolean(dr["isBaseUnit"]);
                ituom.isDefault = Convert.ToBoolean(dr["isDefault"]);
                ituom.PricePerBaseUnit = Convert.ToDecimal(dr["PricePerBaseUnit"]);
                ituom.PricePerCurrentUnit = Convert.ToDecimal(dr["PricePerCurrentUnit"]);
                ituom.QtyInBaseUnit = Convert.ToDecimal(dr["QtyInBaseUnit"]);
                return ituom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertUOM(ItemUOM ituom)
        {
            try
            {
                DataUtilities du = new DataUtilities();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Item_UOM(ItemID,UOMID,isBaseUnit,isDefault,QtyInBaseUnit,PricePerBaseUnit,PricePerCurrentUnit) values(@ItemID,@UOMID,@isBaseUnit,@isDefault,@QtyInBaseUnit,@PricePerBaseUnit,@PricePerCurrentUnit)";
                sqlcmd.Parameters.AddWithValue("@ItemID", ituom.ItemID);
                sqlcmd.Parameters.AddWithValue("@UOMID", ituom.UOM.UOMID);
                sqlcmd.Parameters.AddWithValue("@isBaseUnit", ituom.isBaseUnit);
                sqlcmd.Parameters.AddWithValue("@isDefault", ituom.isDefault);
                sqlcmd.Parameters.AddWithValue("@QtyInBaseUnit", ituom.QtyInBaseUnit);
                sqlcmd.Parameters.AddWithValue("@PricePerBaseUnit", ituom.PricePerBaseUnit);
                sqlcmd.Parameters.AddWithValue("@PricePerCurrentUnit", ituom.PricePerCurrentUnit);
                return du.Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
