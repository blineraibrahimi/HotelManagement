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

namespace HotelManagement.Employees
{
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void empRegisterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpName.Text) || string.IsNullOrWhiteSpace(txtEmpLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmpEmail.Text) || string.IsNullOrWhiteSpace(txtEmpContactNo.Text) || string.IsNullOrWhiteSpace(txtEmpLoginID.Text) ||
                string.IsNullOrWhiteSpace(txtEmpPassword.Text) || string.IsNullOrWhiteSpace(txtEmpType.Text) || string.IsNullOrWhiteSpace(txtEmpDescription.Text))
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new[]
                {
                    new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = txtEmpName.Text },
                    new SqlParameter("@EmployeeLastName", SqlDbType.VarChar) { Value = txtEmpLastName.Text },
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = txtEmpEmail.Text },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = txtEmpContactNo.Text },
                    new SqlParameter("@LoginID", SqlDbType.VarChar) { Value = txtEmpLoginID.Text },
                    new SqlParameter("@Password", SqlDbType.VarChar) { Value = txtEmpPassword.Text },
                    new SqlParameter("@EmployeeType", SqlDbType.VarChar) { Value = txtEmpType.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtEmpDescription.Text },
                };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateEmployee, parameters);

            MessageBox.Show("Employee Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
