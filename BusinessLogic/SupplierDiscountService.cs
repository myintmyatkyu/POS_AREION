using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class SupplierDiscountService
    {
        public static void Save(SupplierDiscount supplierDiscount)
        {
            try
            {
                new SupplierDiscountDataUtility().Insert(supplierDiscount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CalcuateDiscount(string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                int totalDiscount = 0;
                int discountOnPurchase = 0;
                int discountLater = 0;
                discountOnPurchase = new PurchaseHeaderDataUtility().GetTotalDiscount(supplierID, fromDate, toDate);
                discountLater = new SupplierDiscountDataUtility().GetTotalDiscount(supplierID, fromDate, toDate);
                totalDiscount = discountLater + discountOnPurchase;

                return totalDiscount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
