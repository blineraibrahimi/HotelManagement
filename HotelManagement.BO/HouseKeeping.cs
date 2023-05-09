using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class HouseKeeping : BaseClass
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public Room Room { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
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
