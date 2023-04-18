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
    public static class DABookings
    {
        public static List<Bookings> ToBookingList(this DataTable table)
        {
            var bookings = new List<Bookings>();

            foreach (DataRow row in table.Rows)
            {
                var booking = new Bookings
                {
                    ID = Convert.ToInt32(row["BookingID"]),
                    RoomID = Convert.ToInt32(row["RoomID"]),
                    EmployeeID= Convert.ToInt32(row["EmployeeID"]),
                    BookingDate = Convert.ToDateTime(row["BookingDate"]),
                    CheckIn = Convert.ToDateTime(row["CheckIn"]),
                    CheckOut = Convert.ToDateTime(row["CheckOut"]),
                    RangeOfDays = Convert.ToInt32(row["RangeOfDays"]),
                    TotalCost = Convert.ToDecimal(row["TotalCost"]),
                    Description = Convert.ToString(row["Description"]),
                    Status = Convert.ToString(row["Status"])
                };

                bookings.Add(booking);
            }

            return bookings;
        }
    }
}
