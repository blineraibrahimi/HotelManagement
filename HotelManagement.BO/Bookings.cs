using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Bookings : BaseClass
    {
        public int RoomID { get; set; }
        public Room Room { get; set; }
        public int EmployeeID { get; set; }
        public Employees Employee { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RangeOfDays { get; set; }
        public decimal TotalCost { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Bookings() 
        {
        }
    }
}
