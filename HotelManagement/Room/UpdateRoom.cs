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

namespace HotelManagement.Room
{
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
        }

        public List<BO.Room> roomData { get; set; }
        private int ID;
        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            foreach (BO.Room obj in roomData)
            {
                ID = obj.ID;
                txtRoomName.Text = obj.RoomName;
                txtRoomNo.Text = Convert.ToString(obj.RoomNumber);
                txtRoomCapacity.Text = Convert.ToString(obj.Capacity);
                txtRoomRate.Text = Convert.ToString(obj.Rate);
                txtRoomStatus.Text = obj.Status;
                txtRoomDescription.Text = obj.Description;
            }
        }

        private void roomUpdatebtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                    new SqlParameter("@RoomName", SqlDbType.VarChar) { Value = txtRoomName.Text },
                    new SqlParameter("@RoomNumber", SqlDbType.Int) { Value = Convert.ToInt32(txtRoomNo.Text)},
                    new SqlParameter("@Capacity", SqlDbType.Int) { Value = Convert.ToInt32(txtRoomCapacity.Text) },
                    new SqlParameter("@Rate", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtRoomRate.Text)},
                    new SqlParameter("@Status", SqlDbType.VarChar) { Value = txtRoomStatus.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtRoomDescription.Text },
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateRoom, parameters);

                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            roomData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
