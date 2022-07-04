using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;

namespace POSDataAccess
{
    public class CompanyDataUtility
    {
        public void Insert(Company company)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Company(CompanyID, CompanyName,Description,Address,PhoneNo,FaxNo,OpenDaily) " +
                                                "values(@CompanyID, @CompanyName,@Description,@Address,@PhoneNo,@FaxNo,@OpenDaily)";
                sqlcmd.Parameters.AddWithValue("@CompanyID", company.CompanyID);
                sqlcmd.Parameters.AddWithValue("@CompanyName", company.CompanyName);
                sqlcmd.Parameters.AddWithValue("@Description", company.Description);
                sqlcmd.Parameters.AddWithValue("@Address", company.Address);
                sqlcmd.Parameters.AddWithValue("@PhoneNo", company.PhoneNo);
                sqlcmd.Parameters.AddWithValue("@FaxNo", company.FaxNo);
                sqlcmd.Parameters.AddWithValue("@OpenDaily", company.OpenDaily);

                new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Company company)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update Company set CompanyID=@CompanyID, CompanyName=@CompanyName,Description=@Description, Address=@Address,PhoneNo=@PhoneNo,FaxNo=@FaxNo,OpenDaily=@OpenDaily";
                sqlcmd.Parameters.AddWithValue("@CompanyID", company.CompanyID);
                sqlcmd.Parameters.AddWithValue("@CompanyName", company.CompanyName);
                sqlcmd.Parameters.AddWithValue("@Description", company.Description);
                sqlcmd.Parameters.AddWithValue("@Address", company.Address);
                sqlcmd.Parameters.AddWithValue("@PhoneNo", company.PhoneNo);
                sqlcmd.Parameters.AddWithValue("@FaxNo", company.FaxNo);
                sqlcmd.Parameters.AddWithValue("@OpenDaily", company.OpenDaily);

                new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool isExist()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Company";

                DataTable dt = new DataTable();
                 dt= new DataUtilities().Select_Datatable(sqlcmd);
                 if (dt.Rows.Count > 0)
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

        public Company GetCompany(string companyID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from Company where CompanyID=@CompanyID";
                sqlcmd.Parameters.AddWithValue("@CompanyID", companyID);
                DataTable dt = new DataTable();
                dt= new DataUtilities().Select_Datatable(sqlcmd);
                Company company = new Company();
                if (dt.Rows.Count > 0)
                { 
                    DataRow dr = dt.Rows[0];
                    company.CompanyID = dr["CompanyID"].ToString();
                    company.Address = dr["Address"].ToString();
                    company.CompanyName = dr["CompanyName"].ToString();
                    company.Description = dr["Description"].ToString();
                    company.FaxNo = dr["FaxNo"].ToString();
                    company.OpenDaily = dr["OpenDaily"].ToString();
                    company.PhoneNo = dr["PhoneNo"].ToString();
                }
                return company;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Company GetCompany_TopOne()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select top 1 * from Company ";
                DataTable dt = new DataTable();
                dt = new DataUtilities().Select_Datatable(sqlcmd);
                Company company = new Company();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    company.CompanyID = dr["CompanyID"].ToString();
                    company.Address = dr["Address"].ToString();
                    company.CompanyName = dr["CompanyName"].ToString();
                    company.Description = dr["Description"].ToString();
                    company.FaxNo = dr["FaxNo"].ToString();
                    company.OpenDaily = dr["OpenDaily"].ToString();
                    company.PhoneNo = dr["PhoneNo"].ToString();
                }
                return company;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
