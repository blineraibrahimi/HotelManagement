using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class HouseKeeping : BaseClass
    {
        public int  EmployeeID { get; set; }
        public Employees Employee { get; set; }
        public int RoomID { get; set; }

        public Room Room { get; set; }
        public DateTime HousekeepingDate { get; set; }
        public string HousekeepingStatus { get; set; }
        public string Description { get; set; }

        public HouseKeeping()
        {
            //EmployeeID = new Employees();
            //RoomID = new Room();
        }


    }
}
