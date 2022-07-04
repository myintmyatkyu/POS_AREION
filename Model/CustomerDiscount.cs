using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class CustomerDiscount
    {
        public string DiscountID{get;set;}
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Remarks { get; set; }
    }
}
