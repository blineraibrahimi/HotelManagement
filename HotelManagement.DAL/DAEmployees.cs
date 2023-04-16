using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotelManagement.BO;
using HotelManagement.DAL.Helpers;

namespace HotelManagement.DAL
{
    public static class DAEmployees
    {
        public static List<Employees> ToEmployeesList(this DataTable table)
        {
            var employees = new List<Employees>();

            foreach (DataRow row in table.Rows)
            {
                var employee = new Employees
                {
                    ID = Convert.ToInt32(row["EmployeeID"]),
                    EmployeeName = Convert.ToString(row["EmployeeName"]),
                    EmployeeLastname = Convert.ToString(row["EmployeeLastname"]),
                    Email = Convert.ToString(row["Email"]),
                    ContactNo = Convert.ToString(row["ContactNo"]),
                    LoginID = Convert.ToString(row["LoginID"]),
                    Password = Convert.ToString(row["Password"]),
                    EmployeeType = Convert.ToString(row["EmployeeType"]),
                    Description = Convert.ToString(row["Description"])
                };

                employees.Add(employee);
            }

            return employees;
        }
    }
}
