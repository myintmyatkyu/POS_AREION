using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;


namespace POSDataAccess
{
    public class SupplierDiscountDataUtility
    {
        public int Insert(SupplierDiscount supplierDiscount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into SupplierDiscount(DiscountID,Supplier,Date,Amount,Remarks) values(@DiscountID,@SupplierID,@Date,@Amount,@Remarks)";
                sqlcmd.Parameters.AddWithValue("@DiscountID", supplierDiscount.DiscountID);
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierDiscount.Supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Date", supplierDiscount.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", supplierDiscount.Amount);
                sqlcmd.Parameters.AddWithValue("@Remarks", supplierDiscount.Remarks);

                return   new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalDiscount(string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select Sum(Amount) from SupplierDiscount where Supplier=@SupplierID and Convert(date,[Date])>=Convert(date,@fromDate) and Convert(date,[Date])<=Convert(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
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
