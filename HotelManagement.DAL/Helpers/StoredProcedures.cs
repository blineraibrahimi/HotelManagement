using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelManagement.DAL.Helpers
{
    public static class StoredProcedures
    {
        public const string GetEmployees = "GetEmployees";
        public const string CreateEmployee = "CreateEmployee";
        public const string UpdateEmployee = "UpdateEmployee";
        public const string DeleteEmployee = "DeleteEmployee";

        public const string GetCustomers = "GetCustomers";
        public const string CreateCustomer = "CreateCustomer";
        public const string UpdateCustomer = "UpdateCustomer";
        public const string DeleteCustomer = "DeleteCustomer";

        public const string GetRooms = "GetRooms";
        public const string CreateRoom = "CreateRoom";
        public const string UpdateRoom = "UpdateRoom";
        public const string DeleteRoom = "DeleteRoom";

        public const string GetHouseKeeping = "GetHouseKeeping";
        public const string CreateHouseKeeping = "CreateHouseKeeping";
        public const string UpdateHouseKeeping = "UpdateHouseKeeping";
        public const string DeleteHouseKeeping = "DeleteHouseKeeping";

        public const string GetBookings = "GetBookings";
        public const string CreateBooking = "CreateBooking";
        public const string UpdateBooking = "UpdateBooking";
        public const string DeleteBooking = "DeleteBooking";
        public const string CreateVisitor = "CreateVisitor";

        public const string SaveCustomerBooking = "SaveCustomerBooking";
        public const string ChangeRoomStatus = "ChangeRoomStatus";
        public const string GetAvailableRooms = "GetAvailableRooms";
        public const string UpdateRoomAvailability = "UpdateRoomAvailability";
        public const string CreatePaymentWhenBooking = "CreatePaymentWhenBooking";
        public const string GetBookingsBasedOnRoomID = "GetBookingsBasedOnRoom";

        public const string GetPayments = "GetPayments";
        public const string DeletePayment = "DeletePayment";
        public const string UpdatePayment = "UpdatePayment";

    }
}
