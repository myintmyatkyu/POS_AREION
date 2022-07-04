using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace POSDataAccess
{
    public class DataUtilities
    {
        static string DataSource = @".\SQLV101";
        static string attachDBFileName = @"|DataDirectory|\POSLight.mdf";
        static string IntegratedSecurity = "True";
        
        public string connectionstring;
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;

        public DataUtilities()
        {
            sqlcon = new SqlConnection();
            //connectionstring = String.Format(@"Data Source={0};AttachDbFilename={1};Integrated Security={2};User Instance=True", DataSource, attachDBFileName, IntegratedSecurity);
            //connectionstring = @"Data Source=.;Initial Catalog=POS;Integrated Security=True;";
            connectionstring = ConfigurationManager.ConnectionStrings["POSConstring"].ToString();
        }

        public int Insert(SqlCommand sqlcmd)
        {
                sqlcon = new SqlConnection(connectionstring);
                sqlcmd.Connection = sqlcon;   
                sqlcon.Open();

                try
                {
                    return sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlcon.Close();
                    sqlcon.Dispose();
                    sqlcmd.Dispose();
                }

        }

        public int Update(SqlCommand sqlcmd)
        {
            sqlcon = new SqlConnection(connectionstring);
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();

            try
            {
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
                sqlcmd.Dispose();
            }

        }

        public int Delete(SqlCommand sqlcmd)
        {
            sqlcon = new SqlConnection(connectionstring);
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();

            try
            {
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
                sqlcmd.Dispose();
            }
        }

        public DataTable Select_Datatable(SqlCommand sqlcmd)
        {
            sqlcon = new SqlConnection(connectionstring);
            sqlcmd.Connection = sqlcon;
            sqlda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            try
            {
                sqlda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
                sqlcmd.Dispose();
                sqlda.Dispose();
            }
        }

        public SqlDataReader Select_DataReader(SqlCommand sqlcmd)
        {
            sqlcon = new SqlConnection(connectionstring);
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            try
            {
                return sqlcmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
        }

        public object SelectValue(SqlCommand sqlcmd)
        {
            sqlcon = new SqlConnection(connectionstring);
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            try
            {
                return sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
                sqlcmd.Dispose();
            }
        }

    }
}
