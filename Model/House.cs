using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class House
    {
        private string _houseID;
        public string HouseID
        {
            get { return _houseID; }
            set { _houseID = value; }
        }

        private string _houseName;
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }

        //public string CustomerID { get; set; }
    }
}
