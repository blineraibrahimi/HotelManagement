using HotelManagement.BLL;
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
            var message = RoomsBLL.RegisterRoom(txtRoomName.Text,txtRoomNo.Text, txtRoomCapacity.Text, txtRoomRate.Text, txtRoomStatus.Text, txtRoomDescription.Text);

            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Room Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
