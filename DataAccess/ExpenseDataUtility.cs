using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data.SqlClient;
using System.Data;


namespace POSDataAccess
{
    public class ExpenseDataUtility
    {
        public int Insert(Expense expense)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into Expense(ExpenseID,Title,Date,Amount,Remarks) values(@ExpenseID,@Title,@Date,@Amount,@Remarks)";
                sqlcmd.Parameters.AddWithValue("@ExpenseID", expense.ExpenseID);
                sqlcmd.Parameters.AddWithValue("@Title", expense.Title);
                sqlcmd.Parameters.AddWithValue("@Date", expense.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", expense.Amount);
                sqlcmd.Parameters.AddWithValue("@Remarks", expense.Remarks);

                return new DataUtilities().Insert(sqlcmd);
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public List<Expense> GetAllExpenses()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText ="Select * from Expense order by Title asc";
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Expense> expenses = new List<Expense>();
                foreach (DataRow dr in dt.Rows)
                {
                    Expense expense = new Expense();
                    expense.ExpenseID = dr["ExpenseID"].ToString();
                    expense.Amount=Convert.ToInt32( dr["Amount"]);
                    expense.Date = Convert.ToDateTime(dr["Date"]);
                    expense.Remarks = dr["Remarks"].ToString();
                    expense.Title = dr["Title"].ToString();

                    expenses.Add(expense);
                }
                return expenses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Expense> GetExpenseSummary_forReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select Title,Sum(Amount) as Amount from Expense where CONVERT(date,[Date])>=Convert(date,@fromDate) and Convert(date,[Date])<=Convert(date,@toDate) group by Title order by Amount desc";
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                List<Expense> expenses = new List<Expense>();

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Expense expense = new Expense();
                        expense.Amount = Convert.ToInt32(dr["Amount"]);
                        expense.Title = dr["Title"].ToString();
                        expenses.Add(expense);
                    }
                }
                return expenses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Expense> GetExpenseSummary(DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select * from Expense where CONVERT(date,[Date])>=Convert(date,@fromDate) and Convert(date,[Date])<=Convert(date,@toDate) ";
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                List<Expense> expenses = new List<Expense>();

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Expense expense = new Expense();
                        expense.Date = Convert.ToDateTime(dr["Date"]);
                        expense.ExpenseID = dr["ExpenseID"].ToString();
                        expense.Remarks = dr["Remarks"].ToString();
                        expense.Amount = Convert.ToInt32(dr["Amount"]);
                        expense.Title = dr["Title"].ToString();
                        expenses.Add(expense);
                    }
                }
                return expenses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Expense> GetUniqueExpenses()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select Distinct(Title) from Expense order by Title asc";
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<Expense> expenses = new List<Expense>();
                foreach (DataRow dr in dt.Rows)
                {
                    Expense expense = new Expense();
                    //expense.ExpenseID = dr["ExpenseID"].ToString();
                    //expense.Amount = Convert.ToInt32(dr["Amount"]);
                    //expense.Date = Convert.ToDateTime(dr["Date"]);
                    //expense.Remarks = dr["Remarks"].ToString();
                    expense.Title = dr["Title"].ToString();

                    expenses.Add(expense);
                }
                return expenses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
