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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.HouseKeeping
{
    public partial class RegisterHouseKeeping : Form
    {
        public RegisterHouseKeeping()
        {
            InitializeComponent();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "ID";

            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "ID";
        }

        private void hsRegisterbtn_Click(object sender, EventArgs e)
        {
            var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
            var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

            var message = HouseKeepingBLL.RegisterHouseKeeping(selectedEmployee.ID, selectedRoom.ID, houseKeepingDatePicker.Value, cmbHouseKeepingStatus.SelectedItem.ToString(), txtDescription.Text);
            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Housekeeping Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void RegisterHouseKeeping_Load(object sender, EventArgs e)
        {
            cmbRoom.DataSource = HouseKeepingBLL.LoadRooms();
            cmbEmployee.DataSource = HouseKeepingBLL.LoadEmployee();
        }
    }
}
