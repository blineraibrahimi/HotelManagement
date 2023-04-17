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

namespace HotelManagement.Customers
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void cusRegisterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCusName.Text) || string.IsNullOrWhiteSpace(txtCusLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCusAddress.Text) || string.IsNullOrWhiteSpace(txtCusContactNo.Text) || string.IsNullOrWhiteSpace(txtCusIDNo.Text) ||
                string.IsNullOrWhiteSpace(txtCusDsscription.Text))
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new[]
                {
                    new SqlParameter("@CustomerName", SqlDbType.VarChar) { Value = txtCusName.Text },
                    new SqlParameter("@CustomerLastname", SqlDbType.VarChar) { Value = txtCusLastName.Text },
                    new SqlParameter("@Address", SqlDbType.VarChar) { Value = txtCusAddress.Text },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = txtCusContactNo.Text },
                    new SqlParameter("@CustomerIDNo", SqlDbType.VarChar) { Value = txtCusIDNo.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtCusDsscription.Text },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateCustomer, parameters);

            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
