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

        public static int SaveCustomerToDB(string cusName, string cusLastname, string cusAddress, string cusContatctNo,
            string cusIdNo, string cusDescription)
        {
            var parameters = new[]
               {
                    new SqlParameter("@CustomerName", SqlDbType.VarChar) { Value = cusName},
                    new SqlParameter("@CustomerLastname", SqlDbType.VarChar) { Value = cusLastname },
                    new SqlParameter("@Address", SqlDbType.VarChar) { Value = cusAddress},
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = cusContatctNo },
                    new SqlParameter("@CustomerIDNo", SqlDbType.VarChar) { Value = cusIdNo },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = cusDescription },
                    new SqlParameter("@VisitorId", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateVisitor, parameters);

            int visitorId = Convert.ToInt32(parameters[parameters.Length - 1].Value);

            return visitorId;
        }

        public static void UpdateCustomer(int id, string cusName, string cusLastname, string cusAddress, string cusContatctNo,
            string cusIdNo, string cusDescription)
        {
            var parameters = new[]
               {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@CustomerName", SqlDbType.VarChar) { Value = cusName },
                    new SqlParameter("@CustomerLastname", SqlDbType.VarChar) { Value = cusLastname },
                    new SqlParameter("@Address", SqlDbType.VarChar) { Value = cusAddress },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = cusContatctNo},
                    new SqlParameter("@CustomerIDNo", SqlDbType.VarChar) { Value = cusContatctNo },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = cusDescription },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateCustomer, parameters);
        }

        public static void DeleteCustomer(int id)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteBooking, parameters);
        }
    }
}
