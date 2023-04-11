using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Bookings : BaseClass
    {
        public Room RoomID { get; set; }
        public Customers CustomerID { get; set; }
        public Employees EmployeeID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RangeOfDays { get; set; }
        public decimal TotalCost { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Bookings() 
        {
            RoomID = new Room();
            CustomerID = new Customers();
            EmployeeID = new Employees();
        }
    }
}
