using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using POSModel;
using System.Data;

namespace POSDataAccess
{
    public class PurchaseDetailDataUtility
    {
        public int Insert(PurchaseDetail purchase)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into PurchaseDetail(VoucherNo,ItemID,UOMID,Qty,QtyBaseUnit,Price,PriceBaseUnit,SubTotal,DiscountType,DiscountValue,DiscountAmount,NetAmount)" +
                                     " values(@VoucherNo,@ItemID,@UOMID,@Qty,@QtyBaseUnit,@Price,@PriceBaseUnit,@SubTotal,@DiscountType,@DiscountValue,@DiscountAmount,@NetAmount)";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", purchase.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@ItemID", purchase.Item.ItemID);
                sqlcmd.Parameters.AddWithValue("@UOMID",purchase.UOM.UOMID);
                sqlcmd.Parameters.AddWithValue("@Qty", purchase.Qty);
                sqlcmd.Parameters.AddWithValue("@QtyBaseUnit", purchase.QtyBaseUnit);
                sqlcmd.Parameters.AddWithValue("@Price", purchase.Price);
                sqlcmd.Parameters.AddWithValue("@PriceBaseUnit", purchase.PriceBaseUnit);
                sqlcmd.Parameters.AddWithValue("@SubTotal", purchase.SubTotal);
                sqlcmd.Parameters.AddWithValue("@DiscountType", purchase.DiscountType);
                sqlcmd.Parameters.AddWithValue("@DiscountValue", purchase.DiscountValue);
                sqlcmd.Parameters.AddWithValue("@DiscountAmount", purchase.DiscountAmount);
                sqlcmd.Parameters.AddWithValue("@NetAmount", purchase.NetAmount);

                return new DataUtilities().Insert(sqlcmd);
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
                sqlcmd.CommandText = "Delete From PurchaseDetail where ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                new DataUtilities().Delete(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(PurchaseDetail purchase)
        {

            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Update PurchaseDetail set VoucherNo=@VoucherNo,ItemID=@ItemID,UOM=@UOM,BuyingPrice=@BuyingPrice,Qty=@Qty,Amount=@Amount where VoucherNo=@VoucherNo";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", purchase.VoucherNo);
                sqlcmd.Parameters.AddWithValue("@ItemID", purchase.Item.ItemID);
                sqlcmd.Parameters.AddWithValue("@BuyingPrice", purchase.Price);
                sqlcmd.Parameters.AddWithValue("@Qty", purchase.Qty);
                sqlcmd.Parameters.AddWithValue("@Amount", purchase.SubTotal);

                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PurchaseDetail> GetPurchaseDetails(string voucherNo)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from PurchaseDetail where VoucherNo=@VoucherNo";
                sqlcmd.Parameters.AddWithValue("@VoucherNo", voucherNo);           

                List<PurchaseDetail> purchaseDetails = new List<PurchaseDetail>();


                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseDetail purchaseDetail = new PurchaseDetail();
                        purchaseDetail.VoucherNo = dr["VoucherNo"].ToString();
                        purchaseDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                        purchaseDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                        purchaseDetail.Qty = Convert.ToInt32(dr["Qty"]);
                        purchaseDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                        purchaseDetail.Price = Convert.ToInt32(dr["Price"]);
                        purchaseDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                        purchaseDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                        purchaseDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                        purchaseDetail.DiscountType = dr["DiscountType"].ToString();
                        purchaseDetail.DiscountValue = Convert.ToInt32( dr["DiscountValue"]==DBNull.Value?0:dr["DiscountValue"]);
                        purchaseDetail.NetAmount = Convert.ToInt32(dr["NetAmount"]==DBNull.Value?0:dr["NetAmount"]);                     
                        purchaseDetails.Add(purchaseDetail);
                    }

                }
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PurchaseDetail> GetPurchaseDetails(DateTime fromDate, DateTime toDate, string itemID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select PD.* from PurchaseDetail PD Inner Join PurchaseHeader PH on PH.VoucherNo=PD.VoucherNo "+
                     " where Convert(date,Date) >=Convert(date,@fromDate) and Convert(date,Date) <=Convert(date,@toDate) and PD.ItemID=@ItemID";
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<PurchaseDetail> purchaseDetails = new List<PurchaseDetail>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseDetail purchaseDetail = new PurchaseDetail();
                        purchaseDetail.VoucherNo = dr["VoucherNo"].ToString();
                        purchaseDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                        purchaseDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                        purchaseDetail.Qty = Convert.ToInt32(dr["Qty"]);
                        purchaseDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                        purchaseDetail.Price = Convert.ToInt32(dr["Price"]);
                        purchaseDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                        purchaseDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                        purchaseDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                        purchaseDetail.DiscountType = dr["DiscountType"].ToString();
                        purchaseDetail.DiscountValue = Convert.ToInt32(dr["DiscountValue"] == DBNull.Value ? 0 : dr["DiscountValue"]);
                        purchaseDetail.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                        purchaseDetails.Add(purchaseDetail);

                    }

                }
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PurchaseDetail> GetPurchaseDetails(DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select PD.* from PurchaseDetail PD Inner Join PurchaseHeader PH on PH.VoucherNo=PD.VoucherNo " +
                     " where Convert(date,Date) >=Convert(date,@fromDate) and Convert(date,Date) <=Convert(date,@toDate) ";
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                List<PurchaseDetail> purchaseDetails = new List<PurchaseDetail>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseDetail purchaseDetail = new PurchaseDetail();
                        purchaseDetail.VoucherNo = dr["VoucherNo"].ToString();
                        purchaseDetail.Item = new ItemDataUtility().GetItem(dr["ItemID"].ToString());
                        purchaseDetail.UOM = new UOMDataUtility().GetUOM(dr["UOMID"].ToString());
                        purchaseDetail.Qty = Convert.ToInt32(dr["Qty"]);
                        purchaseDetail.QtyBaseUnit = Convert.ToInt32(dr["QtyBaseUnit"]);
                        purchaseDetail.Price = Convert.ToInt32(dr["Price"]);
                        purchaseDetail.PriceBaseUnit = Convert.ToInt32(dr["PriceBaseUnit"]);
                        purchaseDetail.SubTotal = Convert.ToInt32(dr["SubTotal"]);
                        purchaseDetail.DiscountAmount = Convert.ToInt32(dr["DiscountAmount"]);
                        purchaseDetail.DiscountType = dr["DiscountType"].ToString();
                        purchaseDetail.DiscountValue = Convert.ToInt32(dr["DiscountValue"] == DBNull.Value ? 0 : dr["DiscountValue"]);
                        purchaseDetail.NetAmount = Convert.ToInt32(dr["NetAmount"] == DBNull.Value ? 0 : dr["NetAmount"]);
                        purchaseDetails.Add(purchaseDetail);

                    }

                }
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetItemPurchasePrice(string itemID, string supplierID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "select Top 1 (PurchaseDetail.BuyingPrice) from PurchaseDetail inner join Item on Item.ItemID =PurchaseDetail.ItemID inner join PurchaseHeader on PurchaseHeader.VoucherNo=PurchaseDetail.VoucherNo where PurchaseDetail.ItemID=@ItemID and Item.SupplierID=@SupplierID and" +
                                                     " CONVERT(date,PurchaseHeader.Date)>=CONVERT(date,@fromDate) and CONVERT(date,PurchaseHeader.Date)<=CONVERT(date,@toDate) order by PurchaseHeader.Date   desc";
                sqlcmd.Parameters.AddWithValue("@ItemID", itemID);
                sqlcmd.Parameters.AddWithValue("@SupplierID", supplierID);
                sqlcmd.Parameters.AddWithValue("@fromDate", fromDate);
                sqlcmd.Parameters.AddWithValue("@toDate", toDate);

                object result = new DataUtilities().SelectValue(sqlcmd);
                if (result == DBNull.Value)
                {
                    SqlCommand sqlcmd2 = new SqlCommand();
                    sqlcmd2.CommandText = "select Top 1 (PurchaseDetail.BuyingPrice) from PurchaseDetail inner join Item on Item.ItemID =PurchaseDetail.ItemID inner join PurchaseHeader on PurchaseHeader.VoucherNo=PurchaseDetail.VoucherNo where PurchaseDetail.ItemID=@ItemID and Item.SupplierID=@SupplierID and" +
                                                      " CONVERT(date,PurchaseHeader.Date)<=CONVERT(date,@fromDate) order by PurchaseHeader.Date   desc";
                    sqlcmd2.Parameters.AddWithValue("@ItemID", itemID);
                    sqlcmd2.Parameters.AddWithValue("@SupplierID", supplierID);
                    sqlcmd2.Parameters.AddWithValue("@DateBefore", fromDate);
                    result = new DataUtilities().SelectValue(sqlcmd2);
                    if (result == DBNull.Value)
                    {
                        result = 0;
                    }
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
