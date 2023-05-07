using HotelManagement.BLL;
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
    public partial class RegisterBooking : Form
    {
        public RegisterBooking()
        {
            InitializeComponent();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "ID";

            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "ID";

            txtRangeOfDays.Enabled = false;
            txtTotalCost.Enabled = false;
        }

        int roomId;
        string roomName;
        decimal roomPrice;
        private void bookRegisterbtn_Click(object sender, EventArgs e)
        {
            //var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
            var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

            var message = BookingBLL.RegisterBooking(selectedEmployee.ID, roomId, bookingDatePicker.Value,
                checkInDatePicker.Value, checkOutDatePicker.Value, Convert.ToInt32(txtRangeOfDays.Text), Convert.ToDecimal(txtTotalCost.Text),
                txtStatus.Text, txtDescription.Text);

            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Room is booked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void RegisterBooking_Load(object sender, EventArgs e)
        {
            cmbRoom.DataSource = BookingBLL.LoadRoomCMB();
            cmbEmployee.DataSource = BookingBLL.LoadEmployeeCMB();
        }

        private void checkOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            int numberOfDays = (int)(checkOutDatePicker.Value - checkInDatePicker.Value).TotalDays;
            txtRangeOfDays.Text = Convert.ToString(numberOfDays);
            
            txtTotalCost.Text = Convert.ToString(numberOfDays * roomPrice);
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            BO.Room selectedRoom = cmbRoom.SelectedItem as BO.Room;
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
