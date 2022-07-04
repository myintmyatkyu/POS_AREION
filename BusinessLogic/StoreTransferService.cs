using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;

namespace POSBusinessLogic
{
    public class StoreTransferService
    {
        public static void Save(StoreTransferHeader header)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new StoreTransferHeaderDataUtility().Save(header);
                    foreach (StoreTransferDetail std in header.Details)
                    {
                        new StoreTransferDetailDataUtility().Save(std);
                        new ItemDataUtility().UpdateStockBalance_Sale(std.Item, Convert.ToInt32( std.QtyBaseUnit), header.FromStore);
                        new ItemDataUtility().UpdateStockBalance_Purchase(std.Item, Convert.ToInt32( std.QtyBaseUnit), header.ToStore);
                        
                    }
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetLastInvoice(int leftCount)
        {
            try
            {
                return new StoreTransferHeaderDataUtility().GetLastInvoiceNo(leftCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<StoreTransferHeader> GetAllStoreTransfer(DateTime from, DateTime to)
        {
            try
            {
                return new StoreTransferHeaderDataUtility().GetAllStoreTransferHeader(from, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
