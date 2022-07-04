using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using POSModel;
using System.Data;


namespace POSDataAccess
{
    public class PurchaseHeaderDataUtility
    {
        public int Insert(PurchaseHeader purchase)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into PurchaseHeader(VoucherNo,SupplierID,Date,Amount,TotalDiscount,Tax,LabourCharges,TransportCharges,NetAmount,PaidAmount,Credit,Status)" +
                                     "values(@VoucherNo,@SupplierID,@Date,@Amount,@TotalDiscount,@Tax,@LabourCharges,@TransportCharges,@NetAmount,@PaidAmount,@Credit,@Status)";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", purchase.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@SupplierID", purchase.Supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Date", purchase.Date);
                sqlcmd.Parameters.AddWithValue("@Amount", purchase.Amount);
                sqlcmd.Parameters.AddWithValue("@TotalDiscount", purchase.TotalDiscount);
                sqlcmd.Parameters.AddWithValue("@Tax", purchase.Tax);
                sqlcmd.Parameters.AddWithValue("@LabourCharges", purchase.LabourCharges);
                sqlcmd.Parameters.AddWithValue("@TransportCharges", purchase.TransportCharges);
                sqlcmd.Parameters.AddWithValue("@PaidAmount", purchase.PaidAmount);
                sqlcmd.Parameters.AddWithValue("@Credit", purchase.Credit);
                sqlcmd.Parameters.AddWithValue("@Status", purchase.Status);
                sqlcmd.Parameters.AddWithValue("@NetAmount", purchase.NetAmount);
               
                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(PurchaseHeader purchase)
        {

            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update PurchaseHeader set VoucherNo=@VoucherNo,SupplierID=@SupplierID,Date=@Date,Amount=@Amount where VoucherNo=@VoucherNo";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", purchase.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@SupplierID", purchase.Supplier.SupplierID);
                sqlcmd.Parameters.AddWithValue("@Date",purchase.Date);
                sqlcmd.Parameters.AddWithValue("@Amount",purchase.Amount);
               
                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PurchaseHeader> GetPurchaseHeaders(string supplierID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from PurchaseHeader where SupplierID=@SupplierID";
                sqlcmd.Parameters.AddWithValue("@SupplierID",supplierID);

                DataTable dt = new DataTable();
                dt= new DataUtilities().Select_Datatable(sqlcmd);
                List<PurchaseHeader> purchases = new List<PurchaseHeader>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseHeader ph = new PurchaseHeader();
                        ph.VoucherNo = dr["VoucherNo"].ToString();
                        ph.Supplier = new SupplierDataUtility().GetSupplier(dr["SupplierID"].ToString());
                        ph.Date = Convert.ToDateTime(dr["Date"]);
                        ph.Amount = Convert.ToInt32(dr["Amount"]==DBNull.Value?0:dr["Amount"]);
                        ph.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"]==DBNull.Value?0:dr["TotalDiscount"]);
                        ph.Tax = Convert.ToInt32(dr["Tax"] == DBNull.Value ? 0 : dr["Tax"]);
                        ph.LabourCharges = Convert.ToInt32(dr["LabourCharges"] == DBNull.Value ? 0 : dr["LabourCharges"]);
                        ph.TransportCharges = Convert.ToInt32(dr["TransportCharges"] == DBNull.Value ? 0 : dr["TransportCharges"]);
                        ph.NetAmount = Convert.ToInt32(dr["NetAmount"]==DBNull.Value?0:dr["NetAmount"]);
                        ph.PaidAmount = Convert.ToInt32(dr["PaidAmount"] == DBNull.Value ? 0 : dr["PaidAmount"]);
                        ph.Credit = Convert.ToInt32(dr["Credit"] == DBNull.Value ? 0 : dr["Credit"]);
                        ph.PurchaseDetail = new PurchaseDetailDataUtility().GetPurchaseDetails(dr["VoucherNo"].ToString());
                        purchases.Add(ph);
                    }
                }

                return purchases;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PurchaseHeader GetPurchaseHeader(string voucherNo)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from PurchaseHeader where VoucherNo=@VoucherNo";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", voucherNo);

                DataTable dt = new DataTable();
                dt=new DataUtilities().Select_Datatable(sqlcmd);
                PurchaseHeader ph = new PurchaseHeader();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    ph.Amount = Convert.ToInt32(dr["Amount"] == DBNull.Value ? 0 : dr["Amount"]);
                    ph.TotalDiscount = Convert.ToInt32(dr["TotalDiscount"] == DBNull.Value ? 0 : dr["TotalDiscount"]);
                    ph.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                    ph.Date = Convert.ToDateTime(dr["Date"]);
                    ph.Supplier = new SupplierDataUtility().GetSupplier(dr["SupplierID"].ToString());
                    ph.PurchaseDetail = new PurchaseDetailDataUtility().GetPurchaseDetails(dr["VoucherNo"].ToString());
                    ph.VoucherNo = dr["VoucherNo"].ToString();

                }
                return ph;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalDiscount(string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText="Select Sum(TotalDiscount) from PurchaseHeader where SupplierID=@SupplierID and Convert(date,[Date])>=Convert(date,@fromDate) and Convert(date,[Date])<=Convert(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@SupplierID",supplierID);
                sqlcmd.Parameters.AddWithValue("@fromDate",fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate",toDate);

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

    }
}
