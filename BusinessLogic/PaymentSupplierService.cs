using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;

namespace POSBusinessLogic
{
    public class PaymentSupplierService
    {
        public static bool Save(SupplierPayment payment)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new SupplierPaymentDataUtility().Insert(payment);
                    new SupplierDataUtility().UpdateSupplierAccount_Payment(payment.Supplier, payment.PaidAmount);
                    ts.Complete();
                }
                return true;
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

        public static List<CustomerPayment> GetAllPayments(string customerID)
        {
            try
            {
                return new PaymentDataUtility().GetAllPayments(customerID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
