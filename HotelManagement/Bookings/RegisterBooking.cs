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
        public DataTable visitorTable;
       
        private void RegisterBooking_Load(object sender, EventArgs e)
        {
            cmbRoom.DataSource = BookingBLL.LoadRoomCMB();
            cmbEmployee.DataSource = BookingBLL.LoadEmployeeCMB();
            visitorTable = BookingBLL.CreateTable(visitorTable);
            visitorDVG.DataSource = visitorTable;
        }

        private void bookRegisterbtn_Click(object sender, EventArgs e)
        {
            //var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
            var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

            var bookingID = BookingBLL.RegisterBooking(selectedEmployee.ID, roomId, bookingDatePicker.Value,
                checkInDatePicker.Value, checkOutDatePicker.Value, Convert.ToInt32(txtRangeOfDays.Text), Convert.ToDecimal(txtTotalCost.Text),
                cmbStatus.SelectedItem.ToString(), txtDescription.Text);

            foreach (DataGridViewRow row in visitorDVG.Rows)
            {
                if (row.IsNewRow) continue;
                string firstName = row.Cells["Firstname"].Value.ToString();
                string lastName = row.Cells["Lastame"].Value.ToString();
                string address = row.Cells["Address"].Value.ToString();
                string contactNo = row.Cells["Contact Number"].Value.ToString();
                string idNo = row.Cells["Identification Number"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();

                var visitorID = DACustomers.SaveCustomerToDB(firstName,lastName, address,contactNo,idNo,description);

                DABookingCustomer.SaveCustomerAndBookingToDB(bookingID, visitorID);
            }

            if (bookingID == 0)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Room is booked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            BO.Room selectedRoom = cmbRoom.SelectedItem as BO.Room;
            if (selectedRoom != null)
            {
                roomId = selectedRoom.ID;
                roomName = selectedRoom.RoomName;
                roomPrice = selectedRoom.Rate;
                // do something with roomId, roomName, and roomPrice
            }
        }

        private void createNewVisitorbtn_Click(object sender, EventArgs e)
        {
            using (var registerVisitor = new RegisterVisitor())
            {
                registerVisitor.ShowDialog();

            }
        }
    }
}
