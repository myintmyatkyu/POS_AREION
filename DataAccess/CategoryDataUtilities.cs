using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class CategoryDataUtility
    {
        public List<Category> GetAllCategories()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Category";
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Category> cats = new List<Category>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cats.Add(BuildObject(dr));
                    }
                }
                return cats;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category GetCategory(string categoryID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Category where CategoryID=@CategoryID";
                sqlcmd.Parameters.AddWithValue("@CategoryID", categoryID);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                Category cat = new Category();
                if (dt.Rows.Count > 0)
                {
                    cat = BuildObject(dt.Rows[0]);
                }
                return cat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Category category)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Category set  Name=@Name, Description=@Description where CategoryID=@ID";
                sqlcmd.Parameters.AddWithValue("@ID", category.CategoryID);
                sqlcmd.Parameters.AddWithValue("@Name", category.Name);
                sqlcmd.Parameters.AddWithValue("@Description", category.Description);

                new DataUtilities().Update(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Category category)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Category(CategoryID,Name,Description) Values(@ID,@Name,@Description)";
                sqlcmd.Parameters.AddWithValue("@ID", System.Guid.NewGuid().ToString());
                sqlcmd.Parameters.AddWithValue("@Name", category.Name);
                sqlcmd.Parameters.AddWithValue("@Description", category.Description);

                new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category BuildObject(DataRow dr)
        {
            try
            {
                Category category = new Category();
                category.CategoryID = dr["CategoryID"].ToString();
                category.Description = dr["Description"].ToString();
                category.Name = dr["Name"].ToString();
                return category;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
