using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;

namespace POSBusinessLogic
{
    public class SaleReturnService
    {
        public static void Save(SaleReturnHeader header)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new SaleReturnHeaderDataUtility().Insert(header);
                    foreach (SaleReturnDetail sd in header.SaleReturnDetail)
                    {
                        new SaleReturnDetailDataUtility().Insert(sd);
                        new ItemDataUtility().UpdateStockBalance_Purchase(sd.Item, Convert.ToInt32(sd.QtyBaseUnit), new Store() { ID="2"});
                    }
                    new CustomerDataUtility().UpdateCustomerBalance(header.Customer, header.Amount);
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
