using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;

namespace POSDataAccess
{
    public class SaleDetailDataUtility
    {
        public void Insert(SaleDetail saleDetail)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into SaleDetail(VoucherNo,ItemID,UOMID,Qty,QtyBaseUnit,Price,PriceBaseUnit,Subtotal,DiscountType,DiscountValue,DiscountAmount,NetAmount)" +
                                                " values(@VoucherNo,@ItemID,@UOMID,@Qty,@QtyBaseUnit,@Price,@PriceBaseUnit,@SubTotal,@DiscountType,@DiscountValue,@DiscountAmount,@NetAmount)";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", saleDetail.MainVoucherNo);
                sqlcmd.Parameters.AddWithValue("@ItemID", saleDetail.Item.ItemID);
                sqlcmd.Parameters.AddWithValue("@UOMID", saleDetail.UOM.UOMID);
                sqlcmd.Parameters.AddWithValue("@Price", saleDetail.Price);
                sqlcmd.Parameters.AddWithValue("@PriceBaseUnit", saleDetail.PriceBaseUnit);
                sqlcmd.Parameters.AddWithValue("@Qty", saleDetail.Qty);
                sqlcmd.Parameters.AddWithValue("@QtyBaseUnit", saleDetail.QtyBaseUnit);
                sqlcmd.Parameters.AddWithValue("@SubTotal", saleDetail.SubTotal);
                sqlcmd.Parameters.AddWithValue("@DiscountType", saleDetail.DiscountType);
                sqlcmd.Parameters.AddWithValue("@DiscountValue", saleDetail.DiscountValue);
                sqlcmd.Parameters.AddWithValue("@DiscountAmount", saleDetail.DiscountAmount);
                sqlcmd.Parameters.AddWithValue("@NetAmount", saleDetail.NetAmount);

                new DataUtilities().Insert(sqlcmd);
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        public List<SaleDetail> GetSaleDetails(string mainVoucherNo)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select * from SaleDetail where VoucherNo=@VoucherNo");
                sqlcmd.Parameters.AddWithValue("@VoucherNo", mainVoucherNo);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);

                List<SaleDetail> saleDetails = new List<SaleDetail>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleDetail saleDetail = new SaleDetail();
                    saleDetail.MainVoucherNo = dr["VoucherNo"].ToString();
                    saleDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                    saleDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                    saleDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                    saleDetail.Price = Convert.ToInt32(dr["Price"]);
                    saleDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                    saleDetail.Qty = Convert.ToInt32(dr["Qty"]);
                    saleDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                    saleDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                    saleDetail.DiscountType = dr["DiscountType"].ToString();
                    saleDetail.DiscountValue = Convert.ToInt32(dr["DiscountValue"]);
                    saleDetail.NetAmount = Convert.ToInt32(dr["NetAmount"]);
                    saleDetails.Add(saleDetail);
                }

                return saleDetails;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Delete From SaleDetail where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                new DataUtilities().Delete(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleDetail> GetSaleDetails(DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select SaleDetail.*,SaleHeader.Date from SaleDetail  inner join SaleHeader on SaleHeader.VoucherNo=SaleDetail.VoucherNo where Convert(date,SaleHeader.Date)>=Convert(date,@fromDate) and Convert(date,SaleHeader.Date)<=Convert(date,@toDate) order by SaleHeader.VoucherNo");
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);

                List<SaleDetail> saleDetails = new List<SaleDetail>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleDetail saleDetail = new SaleDetail();
                    saleDetail.MainVoucherNo = dr["VoucherNo"].ToString();
                    saleDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                    saleDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                    saleDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                    saleDetail.Price = Convert.ToInt32(dr["Price"]);
                    saleDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                    saleDetail.Qty = Convert.ToInt32(dr["Qty"]);
                    saleDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                    saleDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                    saleDetail.DiscountType = dr["DiscountType"].ToString();
                    saleDetail.DiscountValue = Convert.ToInt32(dr["DiscountValue"]);
                    saleDetail.NetAmount = Convert.ToInt32(dr["NetAmount"]);

                    if (saleDetail.Item != null)
                    {
                        saleDetails.Add(saleDetail);
                    }
                }

                return saleDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleDetail> GetSaleDetails(DateTime fromDate, DateTime toDate,string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Select SaleDetail.*,SaleHeader.Date from SaleDetail  inner join SaleHeader on SaleHeader.VoucherNo=SaleDetail.VoucherNo where Convert(date,SaleHeader.Date)>=Convert(date,@fromDate) and Convert(date,SaleHeader.Date)<=Convert(date,@toDate) and ItemID=@ItemID order by SaleHeader.VoucherNo");
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);

                List<SaleDetail> saleDetails = new List<SaleDetail>();
                foreach (DataRow dr in dt.Rows)
                {
                    SaleDetail saleDetail = new SaleDetail();
                    saleDetail.MainVoucherNo = dr["VoucherNo"].ToString();
                    saleDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                    saleDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                    saleDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                    saleDetail.Price = Convert.ToInt32(dr["Price"]);
                    saleDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                    saleDetail.Qty = Convert.ToInt32(dr["Qty"]);
                    saleDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                    saleDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                    saleDetail.DiscountType = dr["DiscountType"].ToString();
                    saleDetail.DiscountValue = Convert.ToInt32(dr["DiscountValue"]);
                    saleDetail.NetAmount = Convert.ToInt32(dr["NetAmount"]);

                    if (saleDetail.Item != null)
                    {
                        saleDetails.Add(saleDetail);
                    }
                }

                return saleDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetItemSaleQty(string itemID,string supplierID,DateTime fromDate,DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select SUM(Qty) from SaleDetail inner join Item on Item.ItemID =SaleDetail.ItemID where SaleDetail.ItemID=@ItemID and Item.SupplierID=@SupplierID and"+
                                                    " CONVERT(date,[Date])>=CONVERT(date,@fromDate) and CONVERT(date,[Date])<=CONVERT(date,@toDate)";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
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

        public int GetItemSalePrice(string itemID,string supplierID,DateTime fromDate,DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select Top 1 (SaleDetail.Price) from SaleDetail inner join Item on Item.ItemID =SaleDetail.ItemID where SaleDetail.ItemID=@ItemID and Item.SupplierID=@SupplierID and" +
                                                     " CONVERT(date,[Date])>=CONVERT(date,@fromDate) and CONVERT(date,[Date])<=CONVERT(date,@toDate) order by SaleDetail.Date   desc";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                object result = new DataUtilities().SelectValue(sqlcmd);
                if (result == DBNull.Value)
                {
                    //SqlCommand sqlcmd2 = new SqlCommand();
                    //sqlcmd2.CommandText = "select Top 1 (Price) from SaleDetail inner join Item on Item.ItemID =SaleDetail.ItemID where SaleDetail.ItemID=@ItemID and Item.SupplierID=@SupplierID and" +
                    //                                  " CONVERT(date,[Date])<=CONVERT(date,@fromDate) order by SaleDetail.Date   desc";
                    //sqlcmd2.Parameters.AddWithValue("@ItemID", itemID);
                    //sqlcmd2.Parameters.AddWithValue("@SupplierID", supplierID);
                    //sqlcmd2.Parameters.AddWithValue("@DateBefore", fromDate);
                    //result = new DataUtilities().SelectValue(sqlcmd2);
                    //if (result == DBNull.Value)
                    //{
                    //    result = 0;
                    //}
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
