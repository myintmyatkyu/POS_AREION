using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class Item
    {
        public string ItemID{get;set;}
        public string Code{get;set;}
        public string Name { get; set; }
        public string Description{get;set;}
        public int Price{get;set;}
        public string Remark { get; set; }
        public Category Category { get; set; }
        public decimal QtyInHand { get; set; }
        public List<ItemUOM> UOMs { get; set; }
        public List<Stock> Stocks { get; set; }

        public ItemUOM _currentUOM;
        public ItemUOM CurrentUOM
        {
            get 
            {
                this._currentUOM = this.UOMs.Find(i => i.isBaseUnit == true);
                return _currentUOM;
            }
        }

        public Item()
        {
            this.UOMs = new List<ItemUOM>();
            this.Stocks = new List<Stock>();
            this.Price = 0;

        }
    }

    

    public interface IItemSubscriber
    {
        void OnItemChanged(object key);
    }
}
