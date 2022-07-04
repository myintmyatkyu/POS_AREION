using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class StoreService
    {
        public static Store GetStore(string storeID)
        {
            try
            {
                return new StoreDataUtility().GetStore(storeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Store> GetAllStores()
        {
            try
            {
                return new StoreDataUtility().GetAllStores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
