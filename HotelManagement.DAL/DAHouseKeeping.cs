using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BO;
using HotelManagement.DAL.Helpers;

namespace HotelManagement.DAL
{
    public static class DAHouseKeeping
    {
        public static List<HouseKeeping> ToHouseKeepingList(this DataTable table)
        {
            var housekeepings = new List<HouseKeeping>();

            foreach (DataRow row in table.Rows)
            {
                var housekeeping = new HouseKeeping
                {
                    ID = Convert.ToInt32(row["HouseKeepingID"]),
                    EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                    RoomID = Convert.ToInt32(row["RoomID"]),
                    HousekeepingDate = Convert.ToDateTime(row["HouseKeepingDate"]),
                    HousekeepingStatus = Convert.ToString(row["HouseKeepingStatus"]),
                    Description = Convert.ToString(row["Description"])
                };

                housekeepings.Add(housekeeping);
            }

            return housekeepings;
        }
    }
}
