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
    public static class DABookingCustomer
    {
        public static void SaveCustomerAndBookingToDB(int bookingId, int customerId)
        {
            var parameters = new[]
               {
                    new SqlParameter("@BookingID", SqlDbType.Int) { Value = bookingId},
                    new SqlParameter("@CustomerID", SqlDbType.Int) { Value = customerId },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.SaveCustomerBooking, parameters);
        }
    }
}
