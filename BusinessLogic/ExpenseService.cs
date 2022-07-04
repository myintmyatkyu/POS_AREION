using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSDataAccess;
using POSModel;

namespace POSBusinessLogic
{
    public class ExpenseService
    {
        public static bool Save(Expense expense)
        {
            try
            {
                if (new ExpenseDataUtility().Insert(expense) > 0)
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

        public static List<Expense> GetAllExpenses()
        {
            try
            {
                return new ExpenseDataUtility().GetAllExpenses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Expense> GetExpenseSummary_ForReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new ExpenseDataUtility().GetExpenseSummary_forReport(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Expense> GetExpenseSummary(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new ExpenseDataUtility().GetExpenseSummary(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Expense> GetUniqueExpenses()
        {
            try
            {
                return new ExpenseDataUtility().GetUniqueExpenses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
