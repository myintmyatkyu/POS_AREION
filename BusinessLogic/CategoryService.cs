using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class CategoryService
    {
        public static List<Category> GetAllCategories()
        {
            try
            {
                return new CategoryDataUtility().GetAllCategories();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Category GetCategory(string categoryID)
        {
            try
            {
                return new CategoryDataUtility().GetCategory(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Save(Category category)
        {
            if (CategoryService.GetCategory(category.CategoryID).CategoryID != null)
            {
                //Update
                new CategoryDataUtility().Update(category);
            }
            else
            { 
                //Insert
                new CategoryDataUtility().Insert(category);
            }
        }
        
    }
}
