using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class PurchaseHeader
    {
        public PurchaseHeader()
        {
            this.PurchaseDetail = new List<PurchaseDetail>();
        }

        public List<PurchaseDetail> PurchaseDetail { get; set; }
 
        private string _voucherno;
        public string VoucherNo
        {
            get { return _voucherno; }
            set { _voucherno = value; }
        }

        private Supplier _supplier;
        public Supplier Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private int _totalAmount;
        public int Amount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        public int TotalDiscount { get; set; }

        public decimal Tax { get; set; }
        public decimal LabourCharges { get; set; }
        public decimal TransportCharges { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Credit { get; set; }
        public bool Status { get; set; }

        public int NetAmount { get; set; }

    }

    public interface IPurchaseHeader
    {
        void OnPurchaseChanged(object key);
    }
}
