using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class CustomerDiscountService
    {
        public static void Save(CustomerDiscount customerDiscount)
        {
            try
            {
                new CustomerDiscountDataUtility().Insert(customerDiscount);
                new CustomerDataUtility().UpdateCustomerBalance_Deduct(customerDiscount.Customer,customerDiscount.Amount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CalculateTotalDiscount(string customerID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                int totalDiscount = 0;
                int discountOnSale = 0;
                int discountLater = 0;

                discountOnSale = new SaleHeaderDataUtility().GetTotalDiscount(customerID, fromDate, toDate);
                discountLater = new CustomerDiscountDataUtility().GetTotalDiscount(customerID, fromDate, toDate);
                totalDiscount = discountOnSale + discountLater;
                return totalDiscount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
