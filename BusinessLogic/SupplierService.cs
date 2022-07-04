using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class SupplierService
    {
        public static Supplier GetSupplier(string supplierID)
        {
            try
            {
                return new SupplierDataUtility().GetSupplier(supplierID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Supplier> GetAllSuppliers()
        {
            try
            {
                return new SupplierDataUtility().GetAllSuppliers();
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
        public static bool Save(Supplier supplier)
        {
            try
            {
                int result = new SupplierDataUtility().Insert(supplier);
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
        public static bool Update(Supplier supplier)
        {
            try
            {
                int result = new SupplierDataUtility().Update(supplier);

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
        public static void Delete(string supplierID)
        {
            try
            {
                new SupplierDataUtility().Delete(supplierID);
            }
            catch (Exception ex)
            {
                throw ex;    
            }
            
        }
    }
}
