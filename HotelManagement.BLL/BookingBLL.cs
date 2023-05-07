using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelManagement.BLL
{
    public static class BookingBLL
    {
        public static object LoadData()
        {
            var bookings = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetBookings, null).ToBookingList();
            return bookings;
        }

        public static object LoadEmployeeCMB() 
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employees.Insert(0, new BO.Employees { ID = 0, EmployeeName = "Select an employee" });

            return employees;
        }

        public static object LoadRoomCMB()
        {
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            rooms.Insert(0, new BO.Room { ID = 0, RoomName = "Select a room" });

            return rooms;
        }

        //public static object Test()
        //{
        //    BO.Employees selectedRoom = cmbEmployee.SelectedItem as BO.Employees;
        //    if (selectedRoom != null)
        //    {
        //        var empId = selectedRoom.ID;
        //        roomName = selectedRoom.EmployeeName;
        //        var roomPrice = selectedRoom.EmployeeLastname;
        //        // do something with roomId, roomName, and roomPrice
        //    }
        //}

        public static bool RegisterBooking(int empId, int roomId, DateTime bookingDate, DateTime checkIn, DateTime checkout, int rangeOfDays, decimal totalCost, string status, string description)
        {
            if (empId == 0 || roomId == 0 || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DABookings.RegisterBooking(empId, roomId, bookingDate, checkIn, checkout, rangeOfDays, totalCost, status, description);
            return true;
        }

        public static bool UpdateBooking(int id, int empId, int roomId, DateTime bookingDate, DateTime checkIn, DateTime checkout, int rangeOfDays, decimal totalCost, string status, string description)
        {
            if (id == 0 || empId == 0 || roomId == 0 || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DABookings.UpdateBooking(id, empId, roomId, bookingDate, checkIn, checkout, rangeOfDays, totalCost, status, description);
            return true;
        }

        public static bool DeleteEmployee(int id)
        {
            if (id != 0)
            {
                DABookings.DeleteBooking(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
