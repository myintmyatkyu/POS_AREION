using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class SaleDetailService
    {
        public static void Save(SaleDetail saleDetail)
        { 
            //Save Sale Detail
            //Update Stock Balance

        }

        private static void UpdateStockBalance(Item item,int newBalance)
        {
            
        }

        public static int GetItemSaleQty(string itemID, string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new SaleDetailDataUtility().GetItemSaleQty(itemID, supplierID, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetItemSalePrice(string itemID, string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new SaleDetailDataUtility().GetItemSalePrice(itemID, supplierID, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  static List<SaleDetail> GetAllSales(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new SaleDetailDataUtility().GetSaleDetails(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<SaleDetail> GetAllSales(DateTime fromDate, DateTime toDate,string itemID)
        {
            try
            {
                return new SaleDetailDataUtility().GetSaleDetails(fromDate, toDate,itemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        



    }
}
