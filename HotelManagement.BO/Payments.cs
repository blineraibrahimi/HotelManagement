using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Payments : BaseClass
    {
        public int BookingID { get; set; }
        public Bookings Booking { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string PaymentDetails { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
