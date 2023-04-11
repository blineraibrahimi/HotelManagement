using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Customers : BaseClass
    {
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string CustomerIDNo { get; set; }
        public string Description { get; set; }

        public Customers()
        {

        }
    }
}
