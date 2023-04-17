using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
