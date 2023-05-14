using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BO;
using HotelManagement.DAL;
using System.Data.SqlClient;
using System.Xml.Linq;
using HotelManagement.BLL;

namespace HotelManagement.Employees
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public List<BO.Employees> employeeData { get; set; }
        private int ID;
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            foreach (BO.Employees obj in employeeData)
            {
                ID = obj.ID;
                txtEmpName.Text = obj.EmployeeName;
                txtEmpLastName.Text = obj.EmployeeLastname;
                txtEmpEmail.Text = obj.Email;
                txtEmpContactNo.Text = obj.ContactNo;
                txtEmpLoginID.Text = obj.LoginID;
                txtEmpPassword.Text = obj.Password;
                txtEmpType.Text = obj.EmployeeType;
                txtEmpDescription.Text = obj.Description;
            }
        }

        private void empUpdatebtn_Click(object sender, EventArgs e)
        {
            var message = EmployeesBLL.UpdateEmployee(ID, txtEmpName.Text, txtEmpLastName.Text, txtEmpEmail.Text, txtEmpContactNo.Text, txtEmpLoginID.Text, txtEmpPassword.Text, txtEmpType.Text, txtEmpDescription.Text);

            if (message is true)
            {
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            employeeData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
