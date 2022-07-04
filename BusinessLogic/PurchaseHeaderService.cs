using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;

namespace POSBusinessLogic
{
    public class PurchaseHeaderService
    {
        public static bool Save(PurchaseHeader purchaseheader)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new PurchaseHeaderDataUtility().Insert(purchaseheader);              
                    foreach (PurchaseDetail d in purchaseheader.PurchaseDetail)
                    {
                        new PurchaseDetailDataUtility().Insert(d);
                        new ItemDataUtility().UpdateStockBalance_Purchase(d.Item, Convert.ToInt32(d.QtyBaseUnit), new Store() { ID = "1" });
                    }
                    new SupplierDataUtility().UpdateSupplierAccount(purchaseheader.Supplier, purchaseheader.Credit);
                    ts.Complete();
                    return true;
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(PurchaseHeader purchaseheader)
        {

            try
            {
                int result = new PurchaseHeaderDataUtility().Update(purchaseheader);
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

        public static List<PurchaseHeader> GetPurchaseHeaders(string supplierID)
        {
            try
            {
                return new PurchaseHeaderDataUtility().GetPurchaseHeaders(supplierID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static PurchaseHeader GetPurchaseHeader(string voucherNo)
        {
            try
            {
                return new PurchaseHeaderDataUtility().GetPurchaseHeader(voucherNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
