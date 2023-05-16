using HotelManagement.BO;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL
{
    public static class DAPayment
    {
        public static List<Payments> ToPaymentList(this DataTable table)
        {
            var payments = new List<Payments>();

            foreach (DataRow row in table.Rows)
            {
                var payment = new Payments
                {
                    ID = Convert.ToInt32(row["PaymentID"]),
                    BookingID = Convert.ToInt32(row["BookingID"]),
                    Amount = Convert.ToDecimal(row["Amount"]),
                    PaymentDate = row["PaymentDate"] == DBNull.Value ? new DateTime(1, 1, 1) : Convert.ToDateTime(row["PaymentDate"]),
                    PaymentDetails = row["PaymentDetails"] == DBNull.Value ? null : Convert.ToString(row["PaymentDetails"]),
                    PaymentType = row["PaymentType"] == DBNull.Value ? null : Convert.ToString(row["PaymentType"]),
                    Description = row["Description"] == DBNull.Value ? null : Convert.ToString(row["Description"]),
                    Status = Convert.ToString(row["Status"])
                };

                payments.Add(payment);
            }

            return payments;
        }

        public static void UpdatePayment(int id, int bookingID, decimal amount, string paymentType, string paymentDetails, DateTime paymentDate, string status, string description)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@BookingID", SqlDbType.Int) { Value = bookingID },
                new SqlParameter("@Amount", SqlDbType.Decimal) { Value = amount},
                new SqlParameter("@PaymentType", SqlDbType.VarChar) { Value = paymentType},
                new SqlParameter("@PaymentDetails", SqlDbType.VarChar) { Value = paymentDetails},
                new SqlParameter("@PaymentDate", SqlDbType.DateTime) { Value = paymentDate},
                new SqlParameter("@Status", SqlDbType.VarChar) { Value = status},
                new SqlParameter("@Description", SqlDbType.VarChar) { Value = description},
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdatePayment, parameters);
        }

        public static void DeletePayment(int id)
        {
            var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeletePayment, parameters);
        }
    }
}
