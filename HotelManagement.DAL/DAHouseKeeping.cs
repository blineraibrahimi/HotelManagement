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
                    RoomName = Convert.ToString(row["RoomName"]),
                    EmployeeName = Convert.ToString(row["EmployeeName"]),
                    EmployeeLastName = Convert.ToString(row["EmployeeLastName"]),
                    //EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                    //RoomID = Convert.ToInt32(row["RoomID"]),
                    HousekeepingDate = Convert.ToDateTime(row["HouseKeepingDate"]),
                    HousekeepingStatus = Convert.ToString(row["HousekeppingStatus"]),
                    Description = Convert.ToString(row["Description"])
                };

                housekeepings.Add(housekeeping);
            }

            return housekeepings;
        }

        public static void SaveHousekeeping(int empID, int roomID, DateTime housekeepingDate, string housekeepingStatus, string desciption)
        {
            var parameters = new[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = empID},
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomID },
                    new SqlParameter("@HousekeepingDate", SqlDbType.DateTime) { Value = housekeepingDate },
                    new SqlParameter("@HousekeppingStatus", SqlDbType.VarChar) { Value = housekeepingStatus },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = desciption },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateHouseKeeping, parameters);
        }

        public static void UpdateHousekeeping(int id, int empID, int roomID, DateTime housekeepingDate, string housekeepingStatus, string desciption)
        {
            var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = id },
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = empID},
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomID },
                    new SqlParameter("@HousekeepingDate", SqlDbType.DateTime) { Value = housekeepingDate },
                    new SqlParameter("@HousekeppingStatus", SqlDbType.VarChar) { Value = housekeepingStatus },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = desciption },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateHouseKeeping, parameters);

        }

        public static void DeleteHouseKeeping(int id)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteHouseKeeping, parameters);
        }
    }
}
