using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace POSBusinessLogic
{
    public class ItemService
    {

        public static void Save(Item item)
        {
            try
            {
                if(!ItemService.isAlreadyExist(item.ItemID))
                {
                        TransactionScope ts = new TransactionScope();
                        using (ts)
                        {
                            new ItemDataUtility().Insert(item);
                            foreach (ItemUOM iu in item.UOMs)
                            {
                                new ItemUOMDataUtility().InsertUOM(iu);
                            }
                            foreach (Stock s in item.Stocks)
                            {
                                new ItemDataUtility().InsertNewStock(item, s.Store, s.Balance);
                            }
                            ts.Complete();
                        }
                }
                else
                {
                    TransactionScope ts = new TransactionScope();
                    using (ts)
                    {
                        new ItemDataUtility().Update(item);
                        new ItemUOMDataUtility().DeleteItemUOMs(item.ItemID);
                        foreach (ItemUOM iu in item.UOMs)
                        {
                            new ItemUOMDataUtility().InsertUOM(iu);
                        }
                        new ItemDataUtility().DeleteAllStocks(item.ItemID);
                        foreach (Stock s in item.Stocks)
                        {
                            new ItemDataUtility().InsertNewStock(item, s.Store, s.Balance);
                        }
                        ts.Complete();
                    }
                }

                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetBalance(string itemID)
        {
            try
            {
                return new ItemDataUtility().GetBalance(itemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Item item)
        {
            try
            {
                new ItemDataUtility().Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetNewID()
        {
            return System.Guid.NewGuid().ToString();
        }

        public static List<Item> GetAllItems()
        {
            return new ItemDataUtility().GetAllItems();
        }

        public static DataTable GetAllItemsDT()
        {
            return new ItemDataUtility().GetAllItemsDT();
        }

        public static Item GetItem(string itemID)
        {
            return new ItemDataUtility().GetItem(itemID);
        }

        public static void Delete(string itemID)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new ItemDataUtility().Delete(itemID);
                    new SaleDetailDataUtility().Delete(itemID);
                    new PurchaseDetailDataUtility().Delete(itemID);

                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool isAlreadyExist(string itemID)
        {
            try
            {
                Item item = ItemService.GetItem(itemID);
                if (item == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;      
            }
        }

       

        

    }
}
