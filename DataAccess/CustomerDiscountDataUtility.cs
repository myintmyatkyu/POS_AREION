using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class CustomerDiscountDataUtility
    {
        public int Insert(CustomerDiscount customerDiscount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into CustomerDiscount(DiscountID,CustomerID,Date,Amount,Remarks) values(@DiscountID,@CustomerID,@Date,@Amount,@Remarks)";
                sqlcmd.Parameters.AddWithValue("@DiscountID", customerDiscount.DiscountID);
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerDiscount.Customer.CustomerID);
                sqlcmd.Parameters.AddWithValue("@Date", customerDiscount.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", customerDiscount.Amount);
                sqlcmd.Parameters.AddWithValue("@Remarks", customerDiscount.Remarks);

                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalDiscount(string customerID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select Sum(Amount) from CustomerDiscount where CustomerID=@CustomerID and Convert(date,[Date])>=Convert(date,@fromDate) and Convert(date,[Date])<=Convert(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                object result = new DataUtilities().SelectValue(sqlcmd);
                if (result == DBNull.Value)
                {
                    result = 0;
                }
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
