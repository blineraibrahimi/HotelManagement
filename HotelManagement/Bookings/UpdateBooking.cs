using HotelManagement.BLL;
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
            cmbRoom.DataSource = BookingBLL.LoadRoomCMB();
            cmbEmployee.DataSource = BookingBLL.LoadEmployeeCMB();

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
                cmbStatus.Text = obj.Status;
                txtDescription.Text = obj.Description;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
            var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

            var message = BookingBLL.UpdateBooking(ID, selectedEmployee.ID, selectedRoom.ID, bookingDatePicker.Value, 
                checkInDatePicker.Value, checkOutDatePicker.Value, Convert.ToInt32(txtRangeOfDays.Text), Convert.ToDecimal(txtTotalCost.Text),
                cmbStatus.SelectedItem.ToString(), txtDescription.Text);

            if (message is true)
            {
                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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