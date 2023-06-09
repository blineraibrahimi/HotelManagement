﻿using HotelManagement.DAL.Helpers;
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
using System.Threading;

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
            employeesBindingSource.DataSource = EmployeesBLL.LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerEmployeeForm = new RegisterEmployee())
            {
                registerEmployeeForm.ShowDialog();
            }
            employeesBindingSource.DataSource = EmployeesBLL.LoadData();
        }

        private int ID;
        List<BO.Employees> selectedRows = new List<BO.Employees>();
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedRows.Add((BO.Employees)row.DataBoundItem);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = EmployeesBLL.DeleteEmployee(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                employeesBindingSource.DataSource = EmployeesBLL.LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updateEmployeeForm = new UpdateEmployee())
            {
                if (selectedRows.Count != 0 ) 
                {
                    updateEmployeeForm.employeeData = selectedRows;
                    updateEmployeeForm.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            employeesBindingSource.DataSource = EmployeesBLL.LoadData();
            selectedRows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();

            employeesBindingSource.DataSource = EmployeesBLL.LoadData();
        }
    }
}
