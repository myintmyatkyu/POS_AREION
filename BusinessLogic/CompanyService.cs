using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;

namespace POSBusinessLogic
{
    public class CompanyService
    {
        public static void Save(Company company)
        {
            if (new CompanyDataUtility().isExist())
            {
                new CompanyDataUtility().Update(company);
            }
            else
            {
                new CompanyDataUtility().Insert(company);
            }
        }

        public static bool isExist()
        {
            try
            {
                return new CompanyDataUtility().isExist();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Company GetCompanyTopOne()
        {
            try
            {
                return new CompanyDataUtility().GetCompany_TopOne();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
