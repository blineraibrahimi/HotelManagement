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
    public partial class RegisterRoom : Form
    {
        public RegisterRoom()
        {
            InitializeComponent();
        }

        private void roomRegisterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(txtRoomNo.Text) ||
                string.IsNullOrWhiteSpace(txtRoomCapacity.Text) || string.IsNullOrWhiteSpace(txtRoomRate.Text) || 
                string.IsNullOrWhiteSpace(txtRoomStatus.Text) || string.IsNullOrWhiteSpace(txtRoomDescription.Text))
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new[]
                {
                    new SqlParameter("@RoomName", SqlDbType.VarChar) { Value = txtRoomName.Text },
                    new SqlParameter("@RoomNumber", SqlDbType.Int) { Value = Convert.ToInt32(txtRoomNo.Text)},
                    new SqlParameter("@Capacity", SqlDbType.Int) { Value = Convert.ToInt32(txtRoomCapacity.Text) },
                    new SqlParameter("@Rate", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtRoomRate.Text)},
                    new SqlParameter("@Status", SqlDbType.VarChar) { Value = txtRoomStatus.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtRoomDescription.Text },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateRoom, parameters);

            MessageBox.Show("Room Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
