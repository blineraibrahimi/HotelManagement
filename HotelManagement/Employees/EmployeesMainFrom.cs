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
        int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteEmployee, parameters);

                MessageBox.Show("Record Deleted Successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        //---------------------------------------------------------------------
        public void LoadData()
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetEmployees, null).ToEmployeesList();
            employeesBindingSource.DataSource = employees;
        }

    }
}
