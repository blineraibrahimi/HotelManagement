using HotelManagement.BO;
using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Bookings
{
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
        {
            InitializeComponent();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "ID";

            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "ID";

            txtRangeOfDays.Enabled = false;
            txtTotalCost.Enabled = false;
        }

        public List<BO.Bookings> bookingData { get; set; }
        private int ID;
        public BO.Room selectedRoom;
        int roomId;
        string roomName;
        decimal roomPrice;
        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            rooms.Insert(0, new BO.Room { ID = 0, RoomName = "Select a room"});
            cmbRoom.DataSource = rooms;

            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employees.Insert(0, new BO.Employees { ID = 0, EmployeeName = "Select an employee" });
            cmbEmployee.DataSource = employees;

            foreach (BO.Bookings obj in bookingData)
            {
                ID = obj.ID;
                cmbEmployee.SelectedValue = obj.EmployeeID;
                cmbRoom.SelectedValue =obj.RoomID;
                bookingDatePicker.Value = obj.BookingDate;
                checkInDatePicker.Value = obj.CheckIn;
                checkOutDatePicker.Value = obj.CheckOut;
                txtRangeOfDays.Text = Convert.ToString(obj.RangeOfDays);
                txtTotalCost.Text = Convert.ToString(obj.TotalCost);
                txtStatus.Text = obj.Status;
                txtDescription.Text = obj.Description;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
                var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

                var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = ID },
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = selectedEmployee.ID },
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId },
                    new SqlParameter("@BookingDate", SqlDbType.DateTime) { Value = bookingDatePicker.Value },
                    new SqlParameter("@CheckIn", SqlDbType.DateTime) { Value = checkInDatePicker.Value },
                    new SqlParameter("@CheckOut", SqlDbType.DateTime) { Value = checkOutDatePicker.Value },
                    new SqlParameter("@RangeOfDays", SqlDbType.VarChar) { Value = txtRangeOfDays.Text },
                    new SqlParameter("@TotalCost", SqlDbType.VarChar) { Value = txtTotalCost.Text },
                    new SqlParameter("@Status", SqlDbType.VarChar) { Value = txtStatus.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtDescription.Text }
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateBooking, parameters);

                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            bookingData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            int numberOfDays = (int)(checkOutDatePicker.Value - checkInDatePicker.Value).TotalDays;
            txtRangeOfDays.Text = Convert.ToString(numberOfDays);

            txtTotalCost.Text = Convert.ToString(numberOfDays * roomPrice);
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = cmbRoom.SelectedItem as BO.Room;
            if (selectedRoom != null)
            {
                roomId = selectedRoom.ID;
                roomName = selectedRoom.RoomName;
                roomPrice = selectedRoom.Rate;
                // do something with roomId, roomName, and roomPrice
            }
        }
    }
}