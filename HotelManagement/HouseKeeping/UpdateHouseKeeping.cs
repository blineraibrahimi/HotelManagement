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
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            rooms.Insert(0, new BO.Room { ID = 0, RoomName = "Select a room" });
            cmbRoom.DataSource = rooms;

            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employees.Insert(0, new BO.Employees { ID = 0, EmployeeName = "Select an employee" });
            cmbEmployee.DataSource = employees;

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
            if (ID != 0)
            {
                var selectedRoom = (BO.Room)cmbRoom.SelectedItem;
                var selectedEmployee = (BO.Employees)cmbEmployee.SelectedItem;

                var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = ID },
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = selectedEmployee.ID },
                    new SqlParameter("@RoomID", SqlDbType.Int) { Value = selectedRoom.ID },
                    new SqlParameter("@HousekeepingDate", SqlDbType.DateTime) { Value = houseKeepingDatePicker.Value },
                    new SqlParameter("@HousekeppingStatus", SqlDbType.VarChar) { Value = txtRoomStatus.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtDescription.Text },
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateHouseKeeping, parameters);

                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            houseKeepingData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
