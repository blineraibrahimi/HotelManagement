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
            var message = EmployeesBLL.RegisterEmployee(txtEmpName.Text, txtEmpLastName.Text, txtEmpEmail.Text, txtEmpContactNo.Text, txtEmpLoginID.Text, txtEmpPassword.Text, txtEmpType.Text, txtEmpDescription.Text);

            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Employee Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
