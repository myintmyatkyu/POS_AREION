using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class SupplierDiscount
    {
        public string DiscountID { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Remarks { get; set; }
    }
}
