using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class SupplierDataUtility
    {
        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select * From Supplier");
                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<Supplier> suppliers = new List<Supplier>();
                foreach (DataRow dr in dt.Rows)
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierID = dr["SupplierID"].ToString();
                    supplier.Name = dr["Name"].ToString();
                    supplier.Address = dr["Address"].ToString();
                    supplier.Email = dr["Email"].ToString();
                    supplier.Phone1 = dr["Phone1"].ToString();
                    supplier.Phone2 = dr["Phone2"].ToString();
                    supplier.Phone3 = dr["Phone3"].ToString();
                    supplier.ContactPerson = dr["ContactPerson"].ToString();
                    supplier.CurrentCredit = Convert.ToInt32(dr["CurrentCredit"] == DBNull.Value ? 0 : dr["CurrentCredit"]);
                    supplier.CurrentDebit = Convert.ToInt32(dr["CurrentDebit"] == DBNull.Value ? 0 : dr["CurrentDebit"]);
                    suppliers.Add(supplier);
                
                }
                return suppliers;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string supplierID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Delete from Supplier where SupplierID=@SupplierID";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
                new DataUtilities().Delete(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Supplier GetSupplier(string supplierID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select * From Supplier where SupplierID=@SupplierID");
                if (supplierID == "")
                {
                    sqlcmd.Parameters.AddWithValue("@SupplierID", DBNull.Value);
                }
                else
                {
                    sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
                }
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                Supplier supplier = new Supplier();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    supplier.SupplierID = dr["SupplierID"].ToString();
                    supplier.Name = dr["Name"].ToString();
                    supplier.Address = dr["Address"].ToString();
                    supplier.Email = dr["Email"].ToString();
                    supplier.Phone1 = dr["Phone1"].ToString();
                    supplier.Phone2 = dr["Phone2"].ToString();
                    supplier.Phone3 = dr["Phone3"].ToString();
                    supplier.ContactPerson = dr["ContactPerson"].ToString();
                    supplier.CurrentCredit =Convert.ToInt32( dr["CurrentCredit"]==DBNull.Value?0:dr["CurrentCredit"]);
                    supplier.CurrentDebit = Convert.ToInt32(dr["CurrentDebit"]==DBNull.Value?0:dr["CurrentDebit"]);

                }
                return supplier;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Supplier supplier)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Supplier(SupplierID,Name,ContactPerson,Address,Phone1,Phone2,Phone3,Email,CurrentCredit)" +
                                     "values(@SupplierID,@Name,@ContactPerson,@Address,@Phone1,@Phone2,@Phone3,@Email,@CurrentCredit)";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Name", supplier.Name);
                sqlcmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson);
                sqlcmd.Parameters.AddWithValue("@Address", supplier.Address);
                sqlcmd.Parameters.AddWithValue("@Phone1", supplier.Phone1);
                sqlcmd.Parameters.AddWithValue("@Phone2", supplier.Phone2);
                sqlcmd.Parameters.AddWithValue("@Phone3", supplier.Phone3);
                sqlcmd.Parameters.AddWithValue("@Email", supplier.Email);
                sqlcmd.Parameters.AddWithValue("@CurrentCredit", supplier.CurrentCredit);

                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(Supplier supplier)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Supplier set SupplierID=@SupplierID,Name=@Name,ContactPerson=@ContactPerson,Address=@Address,Phone1=@Phone1,Phone2=@Phone2,Phone3=@Phone3,Email=@Email,CurrentCredit=@CurrentCredit where SupplierID=@SupplierID";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Name", supplier.Name);
                sqlcmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson);
                sqlcmd.Parameters.AddWithValue("@Address", supplier.Address);
                sqlcmd.Parameters.AddWithValue("@Phone1", supplier.Phone1);
                sqlcmd.Parameters.AddWithValue("@Phone2", supplier.Phone2);
                sqlcmd.Parameters.AddWithValue("@Phone3", supplier.Phone3);
                sqlcmd.Parameters.AddWithValue("@Email", supplier.Email);
                sqlcmd.Parameters.AddWithValue("@CurrentCredit", supplier.CurrentCredit);

                return new DataUtilities().Update(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSupplierAccount(Supplier supplier, decimal creditAmount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Supplier Set CurrentCredit=CurrentCredit+@Credit where SupplierID=@SupplierID";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Credit", creditAmount);

                new DataUtilities().Update(new SqlCommand() { CommandText = "Update Supplier Set CurrentCredit=0 where CurrentCredit is null" });
                int result= new DataUtilities().Update(sqlcmd);
                if (result == 0)
                {
                    throw new Exception("Error in updating Supplier Account Balance");
                }
            }
            catch (Exception ex)
            { 
                
            }
        }

        public void UpdateSupplierAccount_Payment(Supplier supplier, decimal creditAmount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Supplier Set CurrentCredit=CurrentCredit-@Credit where SupplierID=@SupplierID";
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Credit", creditAmount);

                new DataUtilities().Update(new SqlCommand() { CommandText = "Update Supplier Set CurrentCredit=0 where CurrentCredit is null" });
                int result = new DataUtilities().Update(sqlcmd);
                if (result == 0)
                {
                    throw new Exception("Error in updating Supplier Account Balance");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
