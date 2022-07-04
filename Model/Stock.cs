using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class Stock
    {
        public string ItemID { get; set; }
        public Store Store { get; set; }
        public double Balance { get; set; }
    }
}
