using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BO
{
    public class Employees : BaseClass
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string LoginID { get; set; }
        public string Password { get; set; }
        public string EmployeeType { get; set; }
        public string Description { get; set; }

        public Employees()
        {

        }
    }
}
