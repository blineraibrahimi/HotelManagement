using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BLL
{
    public static class PaymentBLL
    {
        public static object LoadData()
        {
            var payments = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetPayments, null).ToPaymentList();
            return payments;
        }

        public static bool UpdatePayment(int id, int bookingID, decimal amount, string paymentType, string paymentDetails, DateTime paymentDate, string status, string description)
        {
            if (id == 0 || bookingID == 0 || string.IsNullOrEmpty(paymentType) || string.IsNullOrEmpty(paymentDetails) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(description))
            {
                return false;
            }

            DAPayment.UpdatePayment(id, bookingID, amount, paymentType, paymentDetails, paymentDate, status, description);
            return true;
        }

        public static bool DeletePayment(int id) 
        {
            if (id != 0)
            {
                DAPayment.DeletePayment(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
