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
    public static class DACustomers
    {
        public static List<Customers> ToCustomerList(this DataTable table)
        {
            var customers = new List<Customers>();

            foreach (DataRow row in table.Rows)
            {
                var customer = new Customers
                {
                    ID = Convert.ToInt32(row["CustomerID"]),
                    CustomerName = Convert.ToString(row["CustomerName"]),
                    CustomerLastname = Convert.ToString(row["CustomerLastname"]),
                    Address = Convert.ToString(row["Address"]),
                    ContactNo = Convert.ToString(row["ContactNo"]),
                    CustomerIDNo = Convert.ToString(row["CustomerIDNo"]),
                    Description = Convert.ToString(row["Description"])
                };

                customers.Add(customer);
            }

            return customers;
        }
    }
}
