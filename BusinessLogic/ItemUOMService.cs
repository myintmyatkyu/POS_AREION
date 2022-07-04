using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class ItemUOMService
    {
        public static List<ItemUOM> GetAllItemUoms()
        {
            try
            {
                return new ItemUOMDataUtility().GetAllItemUOM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
