using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SupplierPayment
    {
        public string PaymentNo { get; set; }
        public Supplier Supplier { get; set; }
        public int CreditAmount { get; set; }
        public int PaidAmount { get; set; }
        public int Balance { get; set; }
        public string Remarks { get; set; }
        public string ReceivedBy { get; set; }
        public string PaidBy { get; set; }
        public DateTime Date { get; set; }
    }
    public interface IPaymentSupplier
    {
        void OnPaymentSupplierChanged(object key);
    }
}
