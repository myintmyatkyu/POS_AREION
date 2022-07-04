using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class PurchaseDetail
    {
        private string _voucherno;
        public string VoucherNo
        {
            get { return _voucherno; }
            set { _voucherno = value; }
        }

        private Item _item;
        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public UOM UOM { get; set; }

        public decimal PriceBaseUnit { get; set; }
        public decimal QtyBaseUnit { get; set; }

        private int _BuyingPrice;
        public int Price
        {
            get { return _BuyingPrice; }
            set { _BuyingPrice = value; }
        }


        private int _Amount;
        public int SubTotal
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        private int _Qty;
        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public string DiscountType { get; set; }

        public int DiscountValue { get; set; }

        public int DiscountAmount { get; set; }

        public int NetAmount { get; set; }
    }
}
