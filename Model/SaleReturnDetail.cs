using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SaleReturnDetail
    {
        public string SaleReturnNo { get; set; }
        public string VoucherNo { get; set; }
        public Item Item
        {
            get;
            set;
        }
        public UOM UOM { get; set; }
        public int Qty{get;set;}
        public decimal QtyBaseUnit { get; set; }
        public decimal Price { get; set; }
        public decimal PriceBaseUnit { get; set; }
        public decimal SubTotal { get; set; }
    }
}
