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
    public partial class RegisterHouseKeeping : Form
    {
        public RegisterHouseKeeping()
        {
            InitializeComponent();
        }

        private void hsRegisterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpName.Text) || string.IsNullOrWhiteSpace(txtRoomID.Text) ||
               string.IsNullOrWhiteSpace(txtRoomStatus.Text) || string.IsNullOrWhiteSpace(txt_dateID.Text) ||
               string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new[]
                {
                    new SqlParameter("@CustomerName", SqlDbType.VarChar) { Value = txtEmpName.Text },
                    new SqlParameter("@CustomerLastname", SqlDbType.VarChar) { Value = txtRoomID.Text },
                    new SqlParameter("@Address", SqlDbType.VarChar) { Value = txt_dateID.Text },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = txtRoomStatus.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtDescription.Text },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateCustomer, parameters);

            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
