using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;

namespace POSBusinessLogic
{
    public class PaymentService
    {
        public static bool Save(CustomerPayment payment)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new PaymentDataUtility().Insert(payment);
                    CustomerService.UpdateCustomerBalance_Deduct(payment.Customer, payment.PaidAmount);
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
