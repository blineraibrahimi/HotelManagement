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
    }
}
