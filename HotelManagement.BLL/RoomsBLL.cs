using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BLL
{
    public static class RoomsBLL
    {
        public static object LoadData()
        {
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            return rooms;
        }

        public static bool RegisterRoom(string roomName, string roomNo, string roomCapacity, string roomRate, string roomStatus, string description)
        {
            if (string.IsNullOrEmpty(roomName) || string.IsNullOrEmpty(roomNo) || string.IsNullOrEmpty(roomCapacity) || string.IsNullOrEmpty(roomRate) || string.IsNullOrEmpty(roomStatus) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DARooms.SaveRoom(roomName, Convert.ToInt32(roomNo), Convert.ToInt32(roomCapacity), Convert.ToDecimal(roomRate), roomStatus, description);
            return true;
        }

        public static bool UpdateRoom(int id, string roomName, string roomNo, string roomCapacity, string roomRate, string roomStatus, string description)
        {
            if (id == 0 || string.IsNullOrEmpty(roomName) || string.IsNullOrEmpty(roomNo) || string.IsNullOrEmpty(roomCapacity) || string.IsNullOrEmpty(roomRate) || string.IsNullOrEmpty(roomStatus) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DARooms.UpdateRoom(id, roomName, Convert.ToInt32(roomNo), Convert.ToInt32(roomCapacity), Convert.ToDecimal(roomRate), roomStatus, description);
            return true;
        }

        public static bool DeleteRoom(int id)
        {
            if (id != 0)
            {
                DARooms.DeleteRoom(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
