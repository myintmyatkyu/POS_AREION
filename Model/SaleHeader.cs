using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SaleHeader
    {
        public SaleHeader()
        {
            this.SaleDetail = new List<SaleDetail>();
            this.TransportCharges = 0;
            this.LabourCharges = 0;
            this.Status = false;
        }

        private string _mainVoucherNo;
        public string VoucherNo
        {
            get { return _mainVoucherNo; }
            set { _mainVoucherNo = value; }
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private DateTime _openingDate;

        public DateTime Date
        {
            get { return _openingDate; }
            set { _openingDate = value; }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private int _paidAmount;
        public int PaidAmount
        {
            get { return _paidAmount; }
            set { _paidAmount = value; }
        }

        public int TotalDiscount { get; set; }

        public decimal Tax { get; set; }

        public int NetAmount { get; set; }

        public int LabourCharges { get; set; }
        public int TransportCharges { get; set; }

        public bool Status { get; set; }



        private int _refund;
        public int Refund
        {
            get { return _refund; }
            set { _refund = value; }
        }

        public decimal Credit { get; set; }

        public bool isCredit { get; set; }

        private List<SaleDetail> _saleDetail;
        public List<SaleDetail> SaleDetail
        {
            get { return _saleDetail; }
            set { _saleDetail = value; }
        }

    }

    public interface ISaleHeader
    {
        void OnSaleChanged(object key);
    }
}
