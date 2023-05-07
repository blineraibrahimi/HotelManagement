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

        public static void SaveEmployeeToDB(string empName, string empLastname, string empEmail, string empContatctNo,
            string empLoginID, string empPassword, string empType, string empDescription)
        {
            var parameters = new[]
                {
                    new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = empName },
                    new SqlParameter("@EmployeeLastName", SqlDbType.VarChar) { Value = empLastname},
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = empEmail },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = empContatctNo },
                    new SqlParameter("@LoginID", SqlDbType.VarChar) { Value = empLoginID },
                    new SqlParameter("@Password", SqlDbType.VarChar) { Value = empPassword },
                    new SqlParameter("@EmployeeType", SqlDbType.VarChar) { Value = empType },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = empDescription },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateEmployee, parameters);
        }

        public static void UpdateEmployee(int id,string empName, string empLastname, string empEmail, string empContatctNo,
              string empLoginID, string empPassword, string empType, string empDescription) 
        {
            var parameters = new[]
               {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = empName },
                    new SqlParameter("@EmployeeLastName", SqlDbType.VarChar) { Value = empLastname},
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = empEmail },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = empContatctNo },
                    new SqlParameter("@LoginID", SqlDbType.VarChar) { Value = empLoginID },
                    new SqlParameter("@Password", SqlDbType.VarChar) { Value = empPassword },
                    new SqlParameter("@EmployeeType", SqlDbType.VarChar) { Value = empType },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = empDescription },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateEmployee, parameters);

        }

        public static void DeleteEmployee(int id)
        {
            var parameters = new[]
            { 
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteEmployee, parameters);
        }
    }
}
