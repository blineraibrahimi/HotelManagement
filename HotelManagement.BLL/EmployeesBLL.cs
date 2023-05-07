using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAL.Helpers;
using HotelManagement.BO;
using HotelManagement.DAL;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagement.BLL
{
    public static class EmployeesBLL
    {
        public static object LoadData()
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            return employees;
        }

        public static bool RegisterEmployee(string empName, string empLastname, string empEmail, string empContatctNo, 
            string empLoginID, string empPassword, string empType, string empDescription)
        {
            if (string.IsNullOrEmpty(empName) || string.IsNullOrEmpty(empLastname) || string.IsNullOrEmpty(empEmail) || string.IsNullOrEmpty(empContatctNo) || string.IsNullOrEmpty(empLoginID) ||
                string.IsNullOrEmpty(empPassword) || string.IsNullOrEmpty(empType) || string.IsNullOrEmpty(empDescription))
            {
                var message = false;
                return message;
            }

            DAEmployees.SaveEmployeeToDB(empName, empLastname, empEmail, empContatctNo, empLoginID, empPassword, empType, empDescription);
            return true;
        }

        public static bool UpdateEmployee(int id, string empName, string empLastname, string empEmail, string empContatctNo,
              string empLoginID, string empPassword, string empType, string empDescription)
        {
            if (id == 0 || string.IsNullOrEmpty(empName) || string.IsNullOrEmpty(empLastname) || string.IsNullOrEmpty(empEmail) || string.IsNullOrEmpty(empContatctNo) || string.IsNullOrEmpty(empLoginID) ||
                string.IsNullOrEmpty(empPassword) || string.IsNullOrEmpty(empType) || string.IsNullOrEmpty(empDescription))
            {
                return false;
            }

            DAEmployees.UpdateEmployee(id, empName, empLastname, empEmail, empContatctNo, empLoginID, empPassword, empType, empDescription);
            return true;
        }

        public static bool DeleteEmployee(int id)
        {
            if (id != 0)
            {
                DAEmployees.DeleteEmployee(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
