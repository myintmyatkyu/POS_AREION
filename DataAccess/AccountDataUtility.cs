using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class COADataUtility
    {
        public void CreateNewCOA(COA coa)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into COA(AccountCode,Name,Balance) values(@AccountCode,@Name,@Balance)";
                sqlcmd.Parameters.AddWithValue("@AccountCode", coa.AccountCode);
                sqlcmd.Parameters.AddWithValue("@Name", coa.Name);
                sqlcmd.Parameters.AddWithValue("@Balance", coa.Balance);

                new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
