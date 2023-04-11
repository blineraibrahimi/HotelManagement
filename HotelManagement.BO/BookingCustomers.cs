using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class BookingCustomers
    { 
        public Customers CustomerID { get; set; }
        public Bookings BookingID { get; set; }
        public string Description { get; set; }

        public BookingCustomers() 
        {
            CustomerID = new Customers();
            BookingID = new Bookings();
        }
    }
}
