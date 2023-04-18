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
            LoadData();
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
            using(var registerHouseKeeping = new RegisterHouseKeeping())
            {
                registerHouseKeeping.ShowDialog();
            }
            LoadData();
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

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteHouseKeeping, parameters);

                MessageBox.Show("Record Deleted Successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }

        public void LoadData()
        {
            var HouseKeeping = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetHouseKeeping, null).ToHouseKeepingList();
            houseKeepingBindingSource.DataSource = HouseKeeping;
        }

    }
}
