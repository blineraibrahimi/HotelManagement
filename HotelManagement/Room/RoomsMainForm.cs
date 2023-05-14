using HotelManagement.BLL;
using HotelManagement.BO;
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
using System.Threading;
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
            roomBindingSource.DataSource = RoomsBLL.LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerRoomForm = new RegisterRoom())
            {
                registerRoomForm.ShowDialog();
            }
            roomBindingSource.DataSource = RoomsBLL.LoadData();
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
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            selectedRows.Clear();
            roomBindingSource.DataSource = RoomsBLL.LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = RoomsBLL.DeleteRoom(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                roomBindingSource.DataSource = RoomsBLL.LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();

            roomBindingSource.DataSource = RoomsBLL.LoadData();
        }
    }
}
