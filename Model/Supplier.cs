using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class Supplier
    {
        public string SupplierID{get;set;}
        public string Name{get;set;}
        public string ContactPerson{get;set;}
        public string Phone1{get;set;}
        public string Phone2{get;set;}
        public string Phone3{get;set;}
        public string Email{get;set;}
        public string Address{get; set; }
        public int CurrentCredit { get; set; }
        public int CurrentDebit { get; set; }

    }

    public interface ISupplier
    {
        void OnSupplierChanged(object key);
    }
}
