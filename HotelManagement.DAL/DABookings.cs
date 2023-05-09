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

        public static int RegisterBooking(int empId, int roomId, DateTime bookingDate, DateTime checkIn, DateTime checkOut, int rangeOfDays, decimal totalCost, string status, string description)
        {
            var parameters = new[]
               {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = empId },
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId },
                    new SqlParameter("@BookingDate", SqlDbType.DateTime) { Value = bookingDate },
                    new SqlParameter("@CheckIn", SqlDbType.DateTime) { Value = checkIn },
                    new SqlParameter("@CheckOut", SqlDbType.DateTime) { Value = checkOut },
                    new SqlParameter("@RangeOfDays", SqlDbType.Int) { Value = rangeOfDays },
                    new SqlParameter("@TotalCost", SqlDbType.Decimal) { Value = totalCost },
                    new SqlParameter("@Status", SqlDbType.VarChar) { Value = status },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = description },
                    new SqlParameter("@BookingId", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateBooking, parameters);

            int bookingId = Convert.ToInt32(parameters[parameters.Length - 1].Value);

            return bookingId;
        }

        public static void UpdateBooking(int id, int empId, int roomId, DateTime bookingDate, DateTime checkIn, DateTime checkOut, int rangeOfDays, decimal totalCost, string status, string description)
        {
            var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = id },
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = empId },
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId },
                    new SqlParameter("@BookingDate", SqlDbType.DateTime) { Value = bookingDate },
                    new SqlParameter("@CheckIn", SqlDbType.DateTime) { Value = checkIn },
                    new SqlParameter("@CheckOut", SqlDbType.DateTime) { Value = checkOut},
                    new SqlParameter("@RangeOfDays", SqlDbType.Int) { Value = rangeOfDays },
                    new SqlParameter("@TotalCost", SqlDbType.Decimal) { Value = totalCost },
                    new SqlParameter("@Status", SqlDbType.VarChar) { Value = status },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = description }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateBooking, parameters);
        }

        public static void DeleteBooking(int id)
        {
            var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteBooking, parameters);

        }
    }
}
