using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class SaleHeaderDataUtility
    {
        public int Insert(SaleHeader saleHeader)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into SaleHeader(VoucherNo,CustomerID,Date,Amount,TotalDiscount,Tax,LabourCharges,TransportCharges,NetAmount,PaidAmount,Refund,Credit,isCredit,Status)"
                    +"values (@VoucherNo,@CustomerID,@Date,@Amount,@TotalDiscount,@Tax,@LabourCharges,@TransportCharges,@NetAmount,@PaidAmount,@Refund,@Credit,@isCredit,@Status)";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", saleHeader.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@CustomerID", saleHeader.Customer.CustomerID);
                sqlcmd.Parameters.AddWithValue("@Date", saleHeader.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", saleHeader.Amount);
                sqlcmd.Parameters.AddWithValue("@TotalDiscount", saleHeader.TotalDiscount);
                sqlcmd.Parameters.AddWithValue("@Tax", saleHeader.Tax);
                sqlcmd.Parameters.AddWithValue("@LabourCharges", saleHeader.LabourCharges);
                sqlcmd.Parameters.AddWithValue("@TransportCharges", saleHeader.TransportCharges);
                sqlcmd.Parameters.AddWithValue("@NetAmount", saleHeader.NetAmount);
                sqlcmd.Parameters.AddWithValue("@PaidAmount", saleHeader.PaidAmount);
                sqlcmd.Parameters.AddWithValue("@Refund", saleHeader.Refund);
                sqlcmd.Parameters.AddWithValue("@Credit", saleHeader.Credit);
                sqlcmd.Parameters.AddWithValue("@isCredit", saleHeader.isCredit);
                sqlcmd.Parameters.AddWithValue("@Status", saleHeader.Status);
              
                return new DataUtilities().Insert(sqlcmd);
 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Update(SaleHeader saleHeader)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update SaleHeader set Amount=@Amount,TotalDiscount=@TotalDiscount,LabourCharges=@LabourCharges,TransportCharges=@TransportCharges,NetAmount=@NetAmount, PaidAmount=@PaidAmount,Credit=@Credit,Status=@Status where MainVoucherNo=@MainVoucherNo";
                sqlcmd.Parameters.AddWithValue("@MainVoucherNo", saleHeader.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@OpeningDate", saleHeader.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", saleHeader.Amount);
                sqlcmd.Parameters.AddWithValue("@TotalDiscount", saleHeader.TotalDiscount);
                //sqlcmd.Parameters.AddWithValue("@LabourCharges", saleHeader.LabourCharges);
                //sqlcmd.Parameters.AddWithValue("@TransportCharges", saleHeader.TransportCharges);
                sqlcmd.Parameters.AddWithValue("@NetAmount", saleHeader.NetAmount);
                sqlcmd.Parameters.AddWithValue("@PaidAmount", saleHeader.PaidAmount);
                sqlcmd.Parameters.AddWithValue("@Credit", saleHeader.Refund);
                //sqlcmd.Parameters.AddWithValue("@Status", saleHeader.Status);
                foreach (SaleDetail sd in saleHeader.SaleDetail)
                {
                    new SaleDetailDataUtility().Insert(sd);
                }
                return new DataUtilities().Update(sqlcmd);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleHeader> GetSaleHeaders(string customerID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from SaleHeader where CustomerID=@CustomerID";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);
                DataTable dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<SaleHeader> headers = new List<SaleHeader>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleHeader header = new SaleHeader();
                    header.Amount = Convert.ToInt32(dr["Amount"]);
                    header.Credit = Convert.ToInt32(dr["Credit"]);
                    header.Customer = new CustomerDataUtility().GetCustomer(dr["CustomerID"].ToString());
                    //header.House = new HouseDataUtility().GetHouse(dr["HouseID"].ToString());
                    header.VoucherNo = dr["VoucherNo"].ToString();
                    header.Date = Convert.ToDateTime(dr["Date"]);
                    header.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                    //header.LabourCharges = Convert.ToInt32(dr["LabourCharges"] == DBNull.Value ? 0 : dr["LabourCharges"]);
                    //header.TransportCharges = Convert.ToInt32(dr["TransportCharges"] == DBNull.Value ? 0 : dr["TransportCharges"]);
                    header.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"] == DBNull.Value ? 0 : dr["TotalDiscount"]);
                    header.PaidAmount = Convert.ToInt32(dr["PaidAmount"]);
                    header.SaleDetail = new SaleDetailDataUtility().GetSaleDetails(header.VoucherNo);
                    //header.Status = Convert.ToBoolean( dr["Status"]);
                    //header.Title = dr["Title"].ToString();

                    headers.Add(header);
                }
                return headers;


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleHeader> GetSaleHeaders(DateTime date)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from SaleHeader where Convert(date, Date) = Convert(date,@Date)";
                sqlcmd.Parameters.AddWithValue("@Date", date);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<SaleHeader> headers = new List<SaleHeader>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleHeader header = new SaleHeader();
                    header.Amount = Convert.ToInt32(dr["Amount"]);
                    header.Credit = Convert.ToInt32(dr["Credit"]);
                    header.Customer = new CustomerDataUtility().GetCustomer(dr["CustomerID"].ToString());
                    //header.House = new HouseDataUtility().GetHouse(dr["HouseID"].ToString());
                    header.VoucherNo = dr["VoucherNo"].ToString();
                    header.Date = Convert.ToDateTime(dr["Date"]);
                    header.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                    //header.LabourCharges = Convert.ToInt32(dr["LabourCharges"] == DBNull.Value ? 0 : dr["LabourCharges"]);
                    //header.TransportCharges = Convert.ToInt32(dr["TransportCharges"] == DBNull.Value ? 0 : dr["TransportCharges"]);
                    header.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"] == DBNull.Value ? 0 : dr["TotalDiscount"]);
                    header.PaidAmount = Convert.ToInt32(dr["PaidAmount"]);
                    header.SaleDetail = new SaleDetailDataUtility().GetSaleDetails(header.VoucherNo);
                    //header.Status = Convert.ToBoolean( dr["Status"]);
                    //header.Title = dr["Title"].ToString();

                    headers.Add(header);
                }
                return headers;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleHeader> GetAllSaleHeaders()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from SaleHeader";
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<SaleHeader> headers = new List<SaleHeader>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleHeader header = new SaleHeader();
                    header.Amount = Convert.ToInt32(dr["Amount"]);
                    header.Refund = Convert.ToInt32(dr["Credit"]);
                    header.Customer = new CustomerDataUtility().GetCustomer(dr["CustomerID"].ToString());
                    //header.House = new HouseDataUtility().GetHouse(dr["HouseID"].ToString());
                    header.VoucherNo = dr["MainVoucherNo"].ToString();
                    header.Date = Convert.ToDateTime(dr["OpeningDate"]);
                    header.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                    //header.LabourCharges = Convert.ToInt32(dr["LabourCharges"] == DBNull.Value ? 0 : dr["LabourCharges"]);
                    //header.TransportCharges = Convert.ToInt32(dr["TransportCharges"] == DBNull.Value ? 0 : dr["TransportCharges"]);
                    header.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"] == DBNull.Value ? 0 : dr["TotalDiscount"]);
                    header.PaidAmount = Convert.ToInt32(dr["PaidAmount"]);
                    header.SaleDetail = new SaleDetailDataUtility().GetSaleDetails(header.VoucherNo);
                    //header.Status = Convert.ToBoolean(dr["Status"]);
                    //header.Title = dr["Title"].ToString();

                    headers.Add(header);
                }
                return headers;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetLastInvoiceNo(int leftCount)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select Top 1 Right(VoucherNo,4) from SaleHeader where SubString(VoucherNo,0,7)=RIGHT('0' + RTRIM(Year(GETDATE())), 2)+RIGHT('0' + RTRIM(MONTH(GETDATE())), 2)+RIGHT('0' + RTRIM(Day(GETDATE())), 2) order by RIGHT(VoucherNo,6) desc";

                object obj=new DataUtilities().SelectValue(sqlcmd);
                if (obj == DBNull.Value)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SaleHeader GetSaleHeader(string mainVoucherNo)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from SaleHeader where VoucherNo=@VoucherNo";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", mainVoucherNo);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                if (dt.Rows.Count < 1)
                {
                    throw new Exception("Invalid Voucher No");
                }
                DataRow dr = dt.Rows[0];
                SaleHeader header = new SaleHeader();
                header.Amount = Convert.ToInt32(dr["Amount"]);
                header.Refund = Convert.ToInt32(dr["Credit"]);
                header.Customer = new CustomerDataUtility().GetCustomer(dr["CustomerID"].ToString());
                header.VoucherNo = dr["VoucherNo"].ToString();
                header.Date = Convert.ToDateTime(dr["Date"]);
                header.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                header.LabourCharges = Convert.ToInt32(dr["LabourCharges"] == DBNull.Value ? 0 : dr["LabourCharges"]);
                header.TransportCharges = Convert.ToInt32(dr["TransportCharges"] == DBNull.Value ? 0 : dr["TransportCharges"]);
                header.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"] == DBNull.Value ? 0 : dr["TotalDiscount"]);
                header.PaidAmount = Convert.ToInt32(dr["PaidAmount"]);
                header.Credit = Convert.ToInt32(dr["Credit"]);
                header.Tax = Convert.ToInt32(dr["Tax"]);
                header.SaleDetail = new SaleDetailDataUtility().GetSaleDetails(header.VoucherNo);
                header.Status = Convert.ToBoolean(dr["Status"]);
                return header;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalDiscount(string customerID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select Sum(TotalDiscount) from SaleHeader where CustomerID=@CustomerID and Convert(date,[OpeningDate])>=Convert(date,@fromDate) and Convert(date,[OpeningDate])<=Convert(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@CustomerID", customerID);
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                object result = new DataUtilities().SelectValue(sqlcmd);

                if (result == DBNull.Value)
                {
                    result = 0;
                }
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateTotalAmount(string mainVoucherNo, int paidAmount,bool VoucherStatus)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update SaleHeader set PaidAmount =PaidAmount+ @PaidAmount , Credit = Credit-@PaidAmount , Status=@Status where MainVoucherNo=@MainVoucherNo";
                sqlcmd.Parameters.AddWithValue("@PaidAmount", paidAmount);
                sqlcmd.Parameters.AddWithValue("@MainVoucherNo",mainVoucherNo);
                sqlcmd.Parameters.AddWithValue("@Status", VoucherStatus);

               return new DataUtilities().Update(sqlcmd);
            }
            catch(Exception  ex)
            {
                throw ex;
            }
        }
    }
}
