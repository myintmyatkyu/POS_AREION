using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using System.Data;
using System.Data.SqlClient;
namespace POSDataAccess
{
    public class HouseDataUtility
    {
        public List<House> GetAllHouses(string customerID)
        {
            try
            {
                DataTable dt = new DataUtilities().Select_Datatable(new SqlCommand("Select * from House where CustomerID='" + customerID + "'"));

                List<House> houses = new List<House>();
                foreach (DataRow dr in dt.Rows)
                {
                    House house = new House();
                    house.HouseID = dr["HouseID"].ToString();
                    house.HouseName = dr["HouseName"].ToString();
                    houses.Add(house);
                }
                return houses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(House house,Customer customer)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Insert into House(HouseID,CustomerID,HouseName) values(@HouseID,@CustomerID,@HouseName)";
                sqlcmd.Parameters.AddWithValue("@HouseID", house.HouseID);
                sqlcmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                sqlcmd.Parameters.AddWithValue("@HouseName", house.HouseName);

                return new DataUtilities().Insert(sqlcmd);
            }
            catch (Exception ex)
            {
                return 1;
                //throw ex;
            }
        }

        public House GetHouse(string houseID)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "Select * from House where HouseID=@HouseID";
                sqlcmd.Parameters.AddWithValue("@HouseID", houseID);
                DataTable dt = new DataUtilities().Select_Datatable(sqlcmd);
                DataRow dr = dt.Rows[0];
                House house = new House();
                house.HouseID = dr["HouseID"].ToString();
                house.HouseName = dr["HouseName"].ToString();
                return house;
            }
            catch(Exception ex)
            {
                return new House();
                throw ex;
            }
        }
    }
}
