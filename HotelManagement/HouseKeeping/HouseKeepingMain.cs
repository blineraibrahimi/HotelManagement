using HotelManagement.BLL;
using HotelManagement.Bookings;
using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using HotelManagement.HouseKeeping;
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

namespace HotelManagement
{
    public partial class HouseKeepingMain : Form
    {
        public HouseKeepingMain()
        {
            InitializeComponent();
        }

        private int ID;
        List<BO.HouseKeeping> selectedRows = new List<BO.HouseKeeping>();
        private void HouseKeepingMain_Load(object sender, EventArgs e)
        {
            houseKeepingBindingSource.DataSource = HouseKeepingBLL.LoadData();
        }

        private void HouseKeepingDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(HouseKeepingDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            foreach (DataGridViewRow row in HouseKeepingDataGridView.SelectedRows)
            {
                selectedRows.Add((BO.HouseKeeping)row.DataBoundItem);
            }
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerHouseKeeping = new RegisterHouseKeeping())
            {
                registerHouseKeeping.ShowDialog();
            }
            houseKeepingBindingSource.DataSource = HouseKeepingBLL.LoadData();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updateHouseKeeping = new UpdateHouseKeeping())
            {
                if (selectedRows.Count != 0)
                {
                    updateHouseKeeping.houseKeepingData = selectedRows;
                    updateHouseKeeping.ShowDialog();
                    selectedRows.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            houseKeepingBindingSource.DataSource = HouseKeepingBLL.LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = HouseKeepingBLL.DeleteHouseKeeping(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                houseKeepingBindingSource.DataSource = HouseKeepingBLL.LoadData();
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

            houseKeepingBindingSource.DataSource = HouseKeepingBLL.LoadData();

        }
    }
}
