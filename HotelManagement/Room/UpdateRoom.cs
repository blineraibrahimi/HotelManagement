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
            var message = RoomsBLL.UpdateRoom(ID, txtRoomName.Text, txtRoomNo.Text, txtRoomCapacity.Text, txtRoomRate.Text ,txtRoomStatus.Text, txtRoomDescription.Text);
            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Room Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            roomData.Clear();
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
