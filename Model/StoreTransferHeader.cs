using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class StoreTransferHeader
    {
        public string STN { get; set; }
        public DateTime Date { get; set; }
        public Store FromStore { get; set; }
        public Store ToStore { get; set; }
        public string IssuedBy { get; set; }
        public List<StoreTransferDetail> Details { get; set; }

        public StoreTransferHeader()
        {
            this.Details = new List<StoreTransferDetail>();
        }
    }
}
