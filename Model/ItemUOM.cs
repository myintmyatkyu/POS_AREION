using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class ItemUOM
    {
        public string ItemID { get; set; }
        public UOM UOM { get; set; }
        public bool isBaseUnit { get; set; }
        public bool isDefault { get; set; }
        public decimal QtyInBaseUnit { get; set; }
        public decimal PricePerBaseUnit { get; set; }
        public decimal PricePerCurrentUnit { get; set; }
    }
}
