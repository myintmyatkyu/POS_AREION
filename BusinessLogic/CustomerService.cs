using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Data;

namespace POSBusinessLogic
{
    public  class CustomerService
    {
        public static bool Save(Customer customer)
        {
            try
            {
               int result=new CustomerDataUtility().Insert(customer);
               if (result > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(Customer customer)
        {
            
            try
            {
                int result = new CustomerDataUtility().Update(customer);
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

        public static string GetNewID()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<Customer> GetAllCustomers()
        {
            return new CustomerDataUtility().GetAllCustomers();
        }


        public static List<Customer> FindByName(string name)
        {
            try
            {
                return new CustomerDataUtility().FindByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Customer GetCustomer(string customerID)
        {
            return new CustomerDataUtility().GetCustomer(customerID);
        }

        public static CustomerAccount GetCustomerAccount(string customerID)
        {
            return new CustomerDataUtility().GetCustomerAccount(customerID);
        }
        public static void UpdateCustomerBalance_Add(Customer customerAccount, int addedAmount)
        {
            new CustomerDataUtility().UpdateCustomerBalance(customerAccount, addedAmount);
        }

        public static void UpdateCustomerBalance_Deduct(Customer customerAccount, int paidAmount)
        {
            try
            {
                new CustomerDataUtility().UpdateCustomerBalance_Deduct(customerAccount, paidAmount);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
