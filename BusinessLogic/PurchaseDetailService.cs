using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
namespace POSBusinessLogic
{
    public class PurchaseDetailService
    {
        public static bool Save(PurchaseDetail purchaseheader)
        {
            try
            {
                int result = new PurchaseDetailDataUtility().Insert(purchaseheader);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(PurchaseDetail purchaseheader)
        {

            try
            {
                int result = new PurchaseDetailDataUtility().Insert(purchaseheader);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetItemPurchasePrice(string itemID,string supplierID,DateTime fromDate,DateTime toDate)
        {
            try
            {
                return new PurchaseDetailDataUtility().GetItemPurchasePrice(itemID, supplierID, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PurchaseDetail> GetAllPurchases(DateTime fromDate, DateTime toDate, string itemID)
        {
            try
            {
                return new PurchaseDetailDataUtility().GetPurchaseDetails(fromDate, toDate, itemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PurchaseDetail> GetAllPurchases(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new PurchaseDetailDataUtility().GetPurchaseDetails(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
