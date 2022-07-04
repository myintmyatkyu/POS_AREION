using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SaleReturnHeader
    {
        public SaleReturnHeader()
        {
            this.SaleReturnDetail = new List<SaleReturnDetail>();
            this.TransportCharges = 0;
            this.LabourCharges = 0;
        }

        public string SaleReturnNo { get; set; }
        public string VoucherNo { get; set; }

        public Customer Customer
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public int LabourCharges { get; set; }

        public int TransportCharges { get; set; }

        public List<SaleReturnDetail> SaleReturnDetail
        {
            get;
            set;
        }

        public int NetAmount { get; set; }

    }

    public interface ISaleReturnHeader
    {
        void OnSaleReturnChanged(object key);
    }
}
