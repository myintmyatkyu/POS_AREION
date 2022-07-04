using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class Expense
    {
        public string ExpenseID{get;set;}
        public string Title{get;set;}
        public DateTime Date{get;set;}
        public int Amount{get;set;}
        public string Remarks { get; set; }

    }
}
