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

namespace HotelManagement.HouseKeeping
{
    public partial class UpdateHouseKeeping : Form
    {
        public UpdateHouseKeeping()
        {
            InitializeComponent();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "ID";

            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "ID";
        }

        public List<BO.HouseKeeping> houseKeepingData { get; set; }
        private int ID;

        private void UpdateHouseKeeping_Load(object sender, EventArgs e)
        {
            cmbRoom.DataSource = HouseKeepingBLL.LoadRooms();
            cmbEmployee.DataSource = HouseKeepingBLL.LoadEmployee();

            foreach (BO.HouseKeeping obj in houseKeepingData)
            {
                ID = obj.ID;
                cmbEmployee.SelectedValue = obj.EmployeeID;
                cmbRoom.SelectedValue = obj.RoomID;
                houseKeepingDatePicker.Value = obj.HousekeepingDate;
                txtRoomStatus.Text = obj.HousekeepingStatus;
                txtDescription.Text = obj.Description;
            }
        }

        private void empUpdatebtn_Click(object sender, EventArgs e)
        {
            var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
            var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

            var message = HouseKeepingBLL.UpdateHouseKeeping(ID, selectedEmployee.ID, selectedRoom.ID, houseKeepingDatePicker.Value, txtRoomStatus.Text, txtDescription.Text);
            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Record Updated Successfully!");
            this.Close();

            houseKeepingData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
