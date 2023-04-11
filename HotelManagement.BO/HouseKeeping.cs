using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class HouseKeeping : BaseClass
    {
        public Employees EmployeeID { get; set; }
        public Room RoomID { get; set; }
        public DateTime HousekeepingDate { get; set; }
        public string HousekeepingStatus { get; set; }
        public string Description { get; set; }

        public HouseKeeping()
        {
            EmployeeID = new Employees();
            RoomID = new Room();
        }
    }
}
