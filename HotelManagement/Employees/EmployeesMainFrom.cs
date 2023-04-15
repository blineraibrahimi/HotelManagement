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

namespace HotelManagement.Employees
{
    public partial class EmployeesMainFrom : Form
    {
        public EmployeesMainFrom()
        {
            InitializeComponent();
        }

        private void EmployeesMainFrom_Load(object sender, EventArgs e)
        {
          LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerEmployeeForm = new RegisterEmployee())
            {
                registerEmployeeForm.ShowDialog();
            }
            LoadData();
        }


        //---------------------------------------------------------------------
        public void LoadData()
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employeesBindingSource.DataSource = employees;
        }
    }
}
