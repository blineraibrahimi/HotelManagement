using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BLL
{
    public static class CustomersBLL
    {
        public static object LoadData()
        {
            var customers = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetCustomers, null).ToCustomerList();
            return customers;
        }

        public static bool RegisterCustomer(string customerName, string customerLastName, string customerAddress, string customerContactNo, string customerIdNo, string description)
        {
            if(string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerLastName) || string.IsNullOrEmpty(customerAddress) || string.IsNullOrEmpty(customerContactNo) || string.IsNullOrEmpty(customerIdNo) || string.IsNullOrEmpty(description))
            {
                return false;
            }

           DACustomers.SaveCustomerToDB(customerName,customerLastName,customerAddress,customerContactNo,customerIdNo,description);

            return true;
        }

        public static bool UpdateCustomer(int id, string customerName, string customerLastName, string customerAddress, string customerContactNo, string customerIdNo, string description)
        {
            if (id == 0 || string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerLastName) || string.IsNullOrEmpty(customerAddress) || string.IsNullOrEmpty(customerContactNo) || string.IsNullOrEmpty(customerIdNo) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DACustomers.UpdateCustomer(id, customerName, customerLastName, customerAddress, customerContactNo, customerIdNo, description);

            return true;
        }

        public static bool DeleteCustomer(int id)
        {
            if (id != 0)
            {
                DACustomers.DeleteCustomer(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
