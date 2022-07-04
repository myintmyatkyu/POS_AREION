using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSDataAccess;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
namespace POSBusinessLogic
{
    public class SaleHeaderService
    {
        public static bool Save(SaleHeader sh)
        {
            try
            {
                if (!SaleHeaderService.isAlreadyExist(sh.VoucherNo))
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        //1. Sale Header Insert
                        //2. Sale Detail Insert (Looping)
                        //3. Insert Sale Transaction to Transaction Table
                        //4. Credit or Debit Customer Account

                        new SaleHeaderDataUtility().Insert(sh);
                        foreach (SaleDetail sd in sh.SaleDetail)
                        {
                            new SaleDetailDataUtility().Insert(sd);
                            new ItemDataUtility().UpdateStockBalance_Sale(sd.Item, Convert.ToInt32(sd.QtyBaseUnit),new Store(){ID="2"});
                        }
                        UpdateCustomerBalance(sh.Customer, sh.Credit);
                        ts.Complete();
                    }
                }
                else
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        new SaleHeaderDataUtility().Update(sh);
                        UpdateCustomerBalance(sh.Customer, sh.Credit);
                        ts.Complete();
                    }
                }

                return true;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        private static void UpdateCustomerBalance(Customer customerAccount, decimal addedAmount)
        {
            try
            {
                new CustomerDataUtility().UpdateCustomerBalance(customerAccount, addedAmount);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<SaleHeader> GetSaleHeaders(string customerID)
        {
            try
            {
                return new SaleHeaderDataUtility().GetSaleHeaders(customerID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<SaleHeader> GetAllSaleHeaders()
        {
            try
            {
                return new SaleHeaderDataUtility().GetAllSaleHeaders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<SaleHeader> GetSaleHeaders(DateTime date)
        {
            try
            {
                return new SaleHeaderDataUtility().GetSaleHeaders(date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SaleHeader GetSaleHeader(string mainVoucherNo)
        {
            try
            {
                return new SaleHeaderDataUtility().GetSaleHeader(mainVoucherNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetLastSaleInvoice(int leftCount)
        {
            return new SaleHeaderDataUtility().GetLastInvoiceNo(leftCount);
        }

        public static void UpdateTotalAmount(string mainVoucherNo, int paidAmount, bool status)
        {
            try
            {
                new SaleHeaderDataUtility().UpdateTotalAmount(mainVoucherNo, paidAmount,status);
            }
            catch(Exception ex)
            {
                throw ex;                
            }
        }

        public static bool isAlreadyExist(string mainVoucherNo)
        {
            try
            {
                SaleHeader sh = new SaleHeaderDataUtility().GetSaleHeader(mainVoucherNo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(SaleHeader saleHeader,int addedCredit)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    new SaleHeaderDataUtility().Update(saleHeader);
                    UpdateCustomerBalance(saleHeader.Customer, addedCredit);
                    ts.Complete();
                }
                return true;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

   
    }
}
