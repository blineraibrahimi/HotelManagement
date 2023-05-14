using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BLL
{
    public static class HouseKeepingBLL
    {
        public static object LoadData()
        {
            var HouseKeeping = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetHouseKeeping, null).ToHouseKeepingList();
            return HouseKeeping;
        }
   
        public static object LoadRooms() 
        {
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            rooms.Insert(0, new BO.Room { ID = 0, RoomName = "Select a room" });
            return rooms;
        }

        public static object LoadEmployee()
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employees.Insert(0, new BO.Employees { ID = 0, EmployeeName = "Select an employee" });
            return employees;
        }

        public static bool RegisterHouseKeeping(int empID, int roomID, DateTime housekeepingDate, string housekeepingStatus, string desciption) 
        {
            if (empID == 0 || roomID == 0 || string.IsNullOrEmpty(desciption) || string.IsNullOrEmpty(housekeepingStatus))
            {
                return false;
            }

            DAHouseKeeping.SaveHousekeeping(empID, roomID, housekeepingDate, housekeepingStatus, desciption);
            return true;

        }

        public static bool UpdateHouseKeeping(int id, int empID, int roomID, DateTime housekeepingDate, string housekeepingStatus, string desciption)
        {
            if (id == 0 || empID == 0 || roomID == 0 || string.IsNullOrEmpty(desciption) || string.IsNullOrEmpty(housekeepingStatus))
            {
                return false;
            }

            DAHouseKeeping.UpdateHousekeeping(id, empID, roomID, housekeepingDate, housekeepingStatus, desciption);
            return true;

        }

        public static bool DeleteHouseKeeping(int id)
        {
            if (id != 0)
            {
                DAHouseKeeping.DeleteHouseKeeping(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

