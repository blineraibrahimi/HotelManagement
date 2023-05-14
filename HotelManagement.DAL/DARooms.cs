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
    public static class DARooms
    {
        public static List<Room> ToRoomList(this DataTable table)
        {
            var rooms = new List<Room>();

            foreach (DataRow row in table.Rows)
            {
                var room = new Room
                {
                    ID = Convert.ToInt32(row["RoomID"]),
                    RoomName = Convert.ToString(row["RoomName"]),
                    RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                    Capacity = Convert.ToInt32(row["Capacity"]),
                    Rate = Convert.ToDecimal(row["Rate"]),
                    Status = Convert.ToString(row["Status"]),
                    Description = Convert.ToString(row["Description"])
                };

                rooms.Add(room);
            }

            return rooms;
        }

        public static void SaveRoom(string roomName, int roomNo, int roomCapacity, decimal roomRate, string roomStatus, string description)
        {
            var parameters = new[]
            {
                new SqlParameter("@RoomName", SqlDbType.VarChar) { Value = roomName },
                new SqlParameter("@RoomNumber", SqlDbType.Int) { Value = roomNo},
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = roomCapacity},
                new SqlParameter("@Rate", SqlDbType.Decimal) { Value = roomRate},
                new SqlParameter("@Status", SqlDbType.VarChar) { Value = roomStatus},
                new SqlParameter("@Description", SqlDbType.VarChar) { Value = description},
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateRoom, parameters);
        }

        public static void UpdateRoom(int id, string roomName, int roomNo, int roomCapacity, decimal roomRate, string roomStatus, string description)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@RoomName", SqlDbType.VarChar) { Value = roomName },
                new SqlParameter("@RoomNumber", SqlDbType.Int) { Value = roomNo},
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = roomCapacity},
                new SqlParameter("@Rate", SqlDbType.Decimal) { Value = roomRate},
                new SqlParameter("@Status", SqlDbType.VarChar) { Value = roomStatus},
                new SqlParameter("@Description", SqlDbType.VarChar) { Value = description},
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateRoom, parameters);

        }

        public static void DeleteRoom(int id)
        {
            var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteRoom, parameters);
        }
    }
}
