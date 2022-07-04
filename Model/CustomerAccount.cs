using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class CustomerAccount:Customer
    {
        public int CurrentCredit { get; set; }
        public int CurrentDebit { get; set; }
    }
}
