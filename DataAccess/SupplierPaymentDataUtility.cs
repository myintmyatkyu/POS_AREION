using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class SupplierPaymentDataUtility
    {
        public int Insert(SupplierPayment payment)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into PaymentSupplier(PaymentNo,SupplierID,Date,CreditAmount,PaidAmount,Balance,Remarks,ReceivedBy,PaidBy) "+
                                                             "values (@PaymentNo,@SupplierID,@Date,@CreditAmount,@PaidAmount,@Balance,@Remarks,@ReceivedBy,@PaidBy)";
                sqlcmd.Parameters.AddWithValue("@PaymentNo", payment.PaymentNo);
                sqlcmd.Parameters.AddWithValue("@SupplierID", payment.Supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Date", payment.Date);
                sqlcmd.Parameters.AddWithValue("@CreditAmount", payment.CreditAmount);
                sqlcmd.Parameters.AddWithValue("@PaidAmount", payment.PaidAmount);
                sqlcmd.Parameters.AddWithValue("@Balance", payment.Balance);
                sqlcmd.Parameters.AddWithValue("@Remarks", payment.Remarks);
                sqlcmd.Parameters.AddWithValue("@ReceivedBy", payment.ReceivedBy);
                sqlcmd.Parameters.AddWithValue("@PaidBy", payment.PaidBy);
                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerPayment> GetAllPayments(string customerID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select payTran.* from PaymentTransactions payTran inner join SaleHeader on SaleHeader.MainVoucherNo =payTran.VoucherNo  where SaleHeader.CustomerID=@CustomerID order by VoucherNo";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);

                List<CustomerPayment> payments = new List<CustomerPayment>();
                foreach (DataRow dr in dt.Rows)
                {
                    CustomerPayment payment = new CustomerPayment();
                    payment.PaidAmount = Convert.ToInt32(dr["Amount"]);
                    payment.Balance = Convert.ToInt32(dr["Credit"]);
                    if (dr["Date"] != DBNull.Value)
                    {
                        payment.Date = Convert.ToDateTime(dr["Date"]);
                    }
                    payment.CreditAmount = Convert.ToInt32(dr["PaidAmount"]);
                    payment.PaidBy = dr["PaidBy"].ToString();
                    payment.ReceiptNo = dr["PaymentID"].ToString();
                    payment.ReceivedBy = dr["ReceivedBy"].ToString();
                    payment.Remarks = dr["Remarks"].ToString();
                    payment.ReceiptNo = dr["VoucherNo"].ToString();
                    payments.Add(payment);
                }
                return payments;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
