using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;

namespace POSBusinessLogic
{
    public class HouseService
    {
        public static House GetHouse(string houseID)
        {
            return new House();
        }

        public static string GetNewID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
