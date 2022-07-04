using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class ItemDataUtility
    {
        public int Insert(Item item)
        {
            try
            {
                DataUtilities du = new DataUtilities();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Item(ItemID,Code,Name,Description,Price,Remarks,CategoryID,QtyInHand) values(@ItemID,@Code,@Name,@Description,@Price,@Remarks,@CategoryID,@QtyInHand)";
                sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                sqlcmd.Parameters.AddWithValue("@Code", item.Code);
                sqlcmd.Parameters.AddWithValue("@Name", item.Name);
                sqlcmd.Parameters.AddWithValue("@Description", item.Description);
                sqlcmd.Parameters.AddWithValue("@Price", item.Price);
                sqlcmd.Parameters.AddWithValue("@Remarks", item.Remark);
                sqlcmd.Parameters.AddWithValue("@CategoryID", item.Category.CategoryID);
                sqlcmd.Parameters.AddWithValue("@QtyInHand", item.QtyInHand);
               
                return du.Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetBalance(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select Balance from Stock where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                object result = new DataUtilities().SelectValue(sqlcmd);
                if (result == DBNull.Value)
                {
                    result = 0;
                }
                return Convert.ToInt32(result);
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
                sqlcmd.CommandText = "Insert into Item_UOM(ItemID,UOMID,isBaseUnit,QtyInBaseUnit,PricePerBaseUnit,PricePerCurrentUnit) values(@ItemID,@UOMID,@isBaseUnit,@QtyInBaseUnit,@PricePerBaseUnit,@PricePerCurrentUnit)";
                sqlcmd.Parameters.AddWithValue("@ItemID", ituom.ItemID);
                sqlcmd.Parameters.AddWithValue("@UOMID",ituom.UOM.UOMID);
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

        public int Update(Item item)
        {
            try
            {
                DataUtilities du = new DataUtilities();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Item set ItemID=@ItemID,Code=@Code,Name=@Name, Description=@Description,Price=@Price,Remarks=@Remarks,CategoryID=@CategoryID where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                sqlcmd.Parameters.AddWithValue("@Code", item.Code);
                sqlcmd.Parameters.AddWithValue("@Name", item.Name);
                sqlcmd.Parameters.AddWithValue("@Description", item.Description);
                sqlcmd.Parameters.AddWithValue("@Price", item.Price);
                sqlcmd.Parameters.AddWithValue("@Remarks", item.Remark);
                sqlcmd.Parameters.AddWithValue("@CategoryID", item.Category.CategoryID);
                sqlcmd.Parameters.AddWithValue("@QtyInHand", item.QtyInHand);
                return du.Update(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Item> GetAllItems()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select * from Item");
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Item> items = new List<Item>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Item item = new Item();
                        item.ItemID = dr["ItemID"].ToString();
                        item.Price = Convert.ToInt32(dr["Price"]);
                        item.Remark = dr["Remarks"].ToString();
                        item.Code = dr["Code"].ToString();
                        item.Description = dr["Description"].ToString();
                        item.Name = dr["Name"].ToString();
                        item.Category = new CategoryDataUtility().GetCategory(dr["CategoryID"].ToString());
                        item.UOMs = new ItemUOMDataUtility().GetAllItemUOM(item.ItemID);
                        item.QtyInHand = Convert.ToDecimal(dr["QtyInHand"]);
                        item.Stocks = this.GetAllStocks(dr["ItemID"]);
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Stock> GetAllStocks(object itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Stock where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);

                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<Stock> stocks = new List<Stock>();
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Stock s = new Stock();
                        s.ItemID = dr["ItemID"].ToString();
                        s.Store = new StoreDataUtility().GetStore(dr["StoreID"].ToString());
                        s.Balance = Convert.ToDouble(dr["Balance"].ToString());
                        stocks.Add(s);
                    }
                }
                return stocks;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable GetAllItemsDT()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select i.*,uom.* from Item i inner join Item_UOM as uom on i.ItemID = uom.ItemID where isBaseUnit='True'");
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStockBalance_Sale(Item item, int soldQty)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Item set QtyInHand= QtyInHand-@soldQty where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@soldQty", soldQty);
                sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                new DataUtilities().Update(new SqlCommand() { CommandText = "Update Item set QtyInHand=0 where QtyInHand is null" });
                int result= new DataUtilities().Update(sqlcmd);
                if (result == 0)
                {
                    throw new Exception("Error in Updating Stock Balance");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStockBalance_Sale(Item item, int soldQty,Store store)
        {
            try
            {
                if (Convert.ToInt32(new DataUtilities().SelectValue(new SqlCommand("Select Count(*) from Stock where ItemID='" + item.ItemID + "' and StoreID='" + store.ID + "'"))) == 0)
                {
                    InsertNewStock(item, store, 0);
                }

                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandText = "Update Stock set Balance=Balance-@soldQty where ItemID=@ItemID and StoreID=@storeID";
                    sqlcmd.Parameters.AddWithValue("@soldQty", soldQty);
                    sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                    sqlcmd.Parameters.AddWithValue("@storeID", store.ID);

                   //new DataUtilities().Update(new SqlCommand() { CommandText = "Update Item set QtyInHand=0 where QtyInHand is null" });
                    int result = new DataUtilities().Update(sqlcmd);
                    if (result == 0)
                    {
                        throw new Exception("Error in Updating Stock Balance");
                    }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertNewStock(Item item,Store store,double balance)
        {
            try
            {
                    SqlCommand sqlcmdInsert = new SqlCommand();
                    sqlcmdInsert.CommandText = "Insert into Stock(ItemID,StoreID,Balance) values(@ItemID,@StoreID,@Balance)";
                    sqlcmdInsert.Parameters.AddWithValue("@ItemID", item.ItemID);
                    sqlcmdInsert.Parameters.AddWithValue("@StoreID", store.ID);
                    sqlcmdInsert.Parameters.AddWithValue("@Balance", balance);
                    new DataUtilities().Insert(sqlcmdInsert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStockBalance_Purchase(Item item, int purchaseQty)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Item set QtyInHand= QtyInHand+@purchaseQty where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@purchaseQty", purchaseQty);
                sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                new DataUtilities().Update(new SqlCommand() { CommandText = "Update Item set QtyInHand=0 where QtyInHand is null" });
                int result = new DataUtilities().Update(sqlcmd);
                if (result == 0)
                {
                    throw new Exception("Error in Updating Stock Balance");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStockBalance_Purchase(Item item, int purchaseQty, Store store)
        {
            try
            {
                if (Convert.ToInt32(new DataUtilities().SelectValue(new SqlCommand("Select Count(*) from Stock where ItemID='" + item.ItemID + "' and StoreID='" + store.ID + "'"))) == 0)
                {
                    InsertNewStock(item, store, 0);
                }

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Stock set Balance=Balance+@purchaseQty where ItemID=@ItemID and StoreID=@storeID";
                sqlcmd.Parameters.AddWithValue("@purchaseQty", purchaseQty);
                sqlcmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                sqlcmd.Parameters.AddWithValue("@storeID", store.ID);

                int result = new DataUtilities().Update(sqlcmd);
                if (result == 0)
                {
                    throw new Exception("Error in Updating Stock Balance");
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetItem(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select * from Item where ItemID=@ItemID");
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                Item item = new Item();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    item.ItemID = dr["ItemID"].ToString();
                    item.Price = Convert.ToInt32(dr["Price"]);
                    item.Remark = dr["Remarks"].ToString();
                    item.Name = dr["Name"].ToString();
                    item.Code = dr["Code"].ToString();
                    item.Description = dr["Description"].ToString();
                    item.Category = new CategoryDataUtility().GetCategory( dr["CategoryID"].ToString());
                    item.UOMs = new ItemUOMDataUtility().GetAllItemUOM(item.ItemID);
                    item.Stocks = new ItemDataUtility().GetAllStocks(item.ItemID);
                    item.QtyInHand = Convert.ToDecimal(dr["QtyInHand"].ToString());
                    return item;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Delete from Item where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID",itemID);
                new DataUtilities().Delete(sqlcmd);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAllStocks(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Delete from Stock where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);

                new DataUtilities().Delete(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }

}
