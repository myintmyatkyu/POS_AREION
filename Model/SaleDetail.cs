using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SaleDetail
    {

        public decimal QtyBaseUnit { get; set; }
        public decimal QtyInHand { get; set; }
        private string _mainVoucherNo;
        public string MainVoucherNo
        {
            get { return _mainVoucherNo; }
            set { _mainVoucherNo = value; }
        }

        public UOM UOM { get; set; }
        public decimal PriceBaseUnit { get; set; }

        private Item _item;
        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _qty;
        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private int _subTotal;
        public int SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        private string _discountType;
        public string DiscountType
        {
            get { return _discountType; }
            set { _discountType = value; }
        }

        private int _discountValue;
        public int DiscountValue
        {
            get { return _discountValue; }
            set { _discountValue = value; }
        }


        private int _discountAmount;
        public int DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        private int _netAmount;
        public int NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }


    }
}
