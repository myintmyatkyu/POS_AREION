using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class CustomerDataUtility
    {
        public int Insert(Customer customer)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Customer(CustomerID,Name,ContactPerson,Address,Phone1,Phone2,Phone3,Email,TransferPerson,NRCNo,BankAccount,Bank,CurrentCredit)"+
                                     "values(@CustomerID,@Name,@ContactPerson,@Address,@Phone1,@Phone2,@Phone3,@Email,@TransferPerson,@NRCNo,@BankAccount,@Bank,@CurrentCredit)";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                sqlcmd.Parameters.AddWithValue("@Name", customer.Name);
                sqlcmd.Parameters.AddWithValue("@ContactPerson", customer.ContactPerson);
                sqlcmd.Parameters.AddWithValue("@Address", customer.Address);
                sqlcmd.Parameters.AddWithValue("@Phone1", customer.Phone1);
                sqlcmd.Parameters.AddWithValue("@Phone2", customer.Phone2);
                sqlcmd.Parameters.AddWithValue("@Phone3", customer.Phone3);
                sqlcmd.Parameters.AddWithValue("@Email", customer.Email);
                sqlcmd.Parameters.AddWithValue("@TransferPerson", customer.TransferPerson);
                sqlcmd.Parameters.AddWithValue("@NRCNo", customer.NRCNO);
                sqlcmd.Parameters.AddWithValue("@BankAccount", customer.BankAccount);
                sqlcmd.Parameters.AddWithValue("@Bank", customer.Bank);
                sqlcmd.Parameters.AddWithValue("@CurrentCredit", customer.CurrentCredit);

                //CustomerAccount ca =new CustomerAccount();
                //ca.CustomerID = customer.CustomerID;
                //ca.CurrentCredit = 0;
                //ca.CurrentDebit = 0;

                //OpenCustomerAccount(ca);



                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(Customer customer)
        {

            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Customer set CustomerID=@CustomerID,Name=@Name,ContactPerson=@ContactPerson,Address=@Address,Phone1=@Phone1,Phone2=@Phone2,Phone3=@Phone3,Email=@Email,TransferPerson=@TransferPerson,NRCNo=@NRCNo,BankAccount=@BankAccount,Bank=@Bank,CurrentCredit=@CurrentCredit where CustomerID=@CustomerID";                   
                sqlcmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                sqlcmd.Parameters.AddWithValue("@Name", customer.Name);
                sqlcmd.Parameters.AddWithValue("@ContactPerson", customer.ContactPerson);
                sqlcmd.Parameters.AddWithValue("@Address", customer.Address);
                sqlcmd.Parameters.AddWithValue("@Phone1", customer.Phone1);
                sqlcmd.Parameters.AddWithValue("@Phone2", customer.Phone2);
                sqlcmd.Parameters.AddWithValue("@Phone3", customer.Phone3);
                sqlcmd.Parameters.AddWithValue("@Email", customer.Email);
                sqlcmd.Parameters.AddWithValue("@TransferPerson", customer.TransferPerson);
                sqlcmd.Parameters.AddWithValue("@NRCNo", customer.NRCNO);
                sqlcmd.Parameters.AddWithValue("@BankAccount", customer.BankAccount);
                sqlcmd.Parameters.AddWithValue("@Bank", customer.Bank);
                sqlcmd.Parameters.AddWithValue("@CurrentCredit", customer.CurrentCredit);


                return new DataUtilities().Update(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Customer";
                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<Customer> customers = new List<Customer>();
                foreach(DataRow dr in dt.Rows)
                {
                    Customer customer = new Customer();
                    customer.Address=dr["Address"].ToString();
                    customer.Bank=dr["Bank"].ToString();
                    customer.BankAccount=dr["BankAccount"].ToString();
                    customer.ContactPerson=dr["ContactPerson"].ToString();
                    customer.CustomerID=dr["CustomerID"].ToString();
                    customer.Email=dr["Email"].ToString();
                    customer.Name=dr["Name"].ToString();
                    customer.NRCNO=dr["NRCNo"].ToString();
                    customer.Phone1=dr["Phone1"].ToString();
                    customer.Phone2=dr["Phone2"].ToString();
                    customer.Phone3=dr["Phone3"].ToString();
                    customer.TransferPerson=dr["TransferPerson"].ToString();
                    customer.CurrentCredit =dr["CurrentCredit"]==DBNull.Value?0:Convert.ToDecimal(dr["CurrentCredit"]);
                    customers.Add(customer);
                }
                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public Customer GetCustomer(string customerID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Customer where CustomerID =@CustomerID";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                DataRow dr = dt.Rows[0];
                Customer customer = new Customer();
                customer.Address = dr["Address"].ToString();
                customer.Bank = dr["Bank"].ToString();
                customer.BankAccount = dr["BankAccount"].ToString();
                customer.ContactPerson = dr["ContactPerson"].ToString();
                customer.CustomerID = dr["CustomerID"].ToString();
                customer.Email = dr["Email"].ToString();
                customer.Name = dr["Name"].ToString();
                customer.NRCNO = dr["NRCNo"].ToString();
                customer.Phone1 = dr["Phone1"].ToString();
                customer.Phone2 = dr["Phone2"].ToString();
                customer.Phone3 = dr["Phone3"].ToString();
                customer.TransferPerson = dr["TransferPerson"].ToString();
                customer.CurrentCredit = Convert.ToDecimal(dr["CurrentCredit"]==DBNull.Value?"0":dr["CurrentCredit"].ToString());
                return customer;
                
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public List<Customer> FindByName(string name)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Customer where Name like '%"+name+"%'";
               // sqlcmd.Parameters.AddWithValue("@Name", name);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Customer> customers = new List<Customer>();
                foreach (DataRow dr in dt.Rows)
                {
                    Customer customer = new Customer();
                    customer.Address = dr["Address"].ToString();
                    customer.Bank = dr["Bank"].ToString();
                    customer.BankAccount = dr["BankAccount"].ToString();
                    customer.ContactPerson = dr["ContactPerson"].ToString();
                    customer.CustomerID = dr["CustomerID"].ToString();
                    customer.Email = dr["Email"].ToString();
                    customer.Name = dr["Name"].ToString();
                    customer.NRCNO = dr["NRCNo"].ToString();
                    customer.Phone1 = dr["Phone1"].ToString();
                    customer.Phone2 = dr["Phone2"].ToString();
                    customer.Phone3 = dr["Phone3"].ToString();
                    customer.TransferPerson = dr["TransferPerson"].ToString();
                    customer.CurrentCredit = Convert.ToDecimal(dr["CurrentCredit"] == DBNull.Value ? "0" : dr["CurrentCredit"].ToString());
                    customers.Add(customer);
                }
                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCustomerBalance(Customer customerAccount, decimal addedAmount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Customer set CurrentCredit = CurrentCredit+@addedAmount where CustomerID=@CustomerID";
                sqlcmd.Parameters.AddWithValue("@addedAmount", addedAmount);
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerAccount.CustomerID);

                if (new DataUtilities().Update(sqlcmd) < 1)
                {
                    throw new Exception("Updating Customer Balance Fail.");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCustomerBalance_Deduct(Customer customerAccount, int paidAmount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Customer set CurrentCredit = CurrentCredit-@paidAmount where CustomerID=@CustomerID";
                sqlcmd.Parameters.AddWithValue("@paidAmount", paidAmount);
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerAccount.CustomerID);

                if (new DataUtilities().Update(sqlcmd) < 1)
                {
                    throw new Exception("Updating Customer Balance Fail.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerAccount GetCustomerAccount(string customerID)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "Select * from Customer inner join CustomerAccount on Customer.CustomerID=CustomerAccount.CustomerID where Customer.CustomerID=@CustomerID";
            sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);

            DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);

            DataRow dr = dt.Rows[0];

            CustomerAccount customer = new CustomerAccount();
            customer.Address = dr["Address"].ToString();
            customer.Bank = dr["Bank"].ToString();
            customer.BankAccount = dr["BankAccount"].ToString();
            customer.ContactPerson = dr["ContactPerson"].ToString();
            customer.CustomerID = dr["CustomerID"].ToString();
            customer.Email = dr["Email"].ToString();
            customer.Name = dr["Name"].ToString();
            customer.NRCNO = dr["NRCNo"].ToString();
            customer.Phone1 = dr["Phone1"].ToString();
            customer.Phone2 = dr["Phone2"].ToString();
            customer.Phone3 = dr["Phone3"].ToString();
            customer.TransferPerson = dr["TransferPerson"].ToString();

            customer.CurrentDebit = Convert.ToInt32(dr["CurrentDebit"]);
            customer.CurrentCredit = Convert.ToInt32(dr["CurrentCredit"]);
            return customer;

        }

        private static void OpenCustomerAccount(CustomerAccount ca)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into CustomerAccount(CustomerID,CurrentCredit,CurrentDebit) values(@CustomerID,@CurrentCredit,@CurrentDebit)";
                sqlcmd.Parameters.AddWithValue("@CustomerID",ca.CustomerID);
                sqlcmd.Parameters.AddWithValue("@CurrentCredit", ca.CurrentCredit);
                sqlcmd.Parameters.AddWithValue("@CurrentDebit", ca.CurrentDebit);

                if (new DataUtilities().Insert(sqlcmd) < 1)
                {
                    throw new Exception("Opening Customer Account Fail.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
