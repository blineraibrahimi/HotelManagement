using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Room : BaseClass
    {
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal Rate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public Room() 
        {

        }
    }
}
