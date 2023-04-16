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
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                    new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = txtEmpName.Text },
                    new SqlParameter("@EmployeeLastName", SqlDbType.VarChar) { Value = txtEmpLastName.Text },
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = txtEmpEmail.Text },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = txtEmpContactNo.Text },
                    new SqlParameter("@LoginID", SqlDbType.VarChar) { Value = txtEmpLoginID.Text },
                    new SqlParameter("@Password", SqlDbType.VarChar) { Value = txtEmpPassword.Text },
                    new SqlParameter("@EmployeeType", SqlDbType.VarChar) { Value = txtEmpType.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtEmpDescription.Text },
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateEmployee, parameters);

                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            employeeData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
