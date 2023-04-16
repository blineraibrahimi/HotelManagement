using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using HotelManagement.Employees;
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

namespace HotelManagement.Room
{
    public partial class RoomsMainForm : Form
    {
        public RoomsMainForm()
        {
            InitializeComponent();
        }

        private void RoomsMainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerRoomForm = new RegisterRoom())
            {
                registerRoomForm.ShowDialog();
            }
            LoadData();
        }

        private int ID;
        List<BO.Room> selectedRows = new List<BO.Room>();
        private void roomsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(roomsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            foreach (DataGridViewRow row in roomsDataGridView.SelectedRows)
            {
                selectedRows.Add((BO.Room)row.DataBoundItem);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updateRoomForm = new UpdateRoom())
            {
                if (selectedRows.Count != 0)
                {
                    updateRoomForm.roomData = selectedRows;
                    updateRoomForm.ShowDialog();
                    selectedRows.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteRoom, parameters);

                MessageBox.Show("Record Deleted Successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }

        //---------------------------------------------------------------------
        public void LoadData()
        {
            var rooms = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetRooms, null).ToRoomList();
            roomBindingSource.DataSource = rooms;
        }
    }
}
