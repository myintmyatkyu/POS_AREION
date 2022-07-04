using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class StoreTransferDetail
    {
        public string STN{get;set;}
        public Item Item{get;set;}
        public UOM UOM{get;set;}
        public decimal Qty{get;set;}
        public decimal QtyBaseUnit{get;set;}
		
    }
}
