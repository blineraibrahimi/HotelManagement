﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Customers;
using HotelManagement.Employees;
using HotelManagement.Room;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var employeeForm = new EmployeesMainFrom())
            {
                employeeForm.ShowDialog();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var customerForm = new CustomersMainForm())
            {
                customerForm.ShowDialog();
            }
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var roomForm = new RoomsMainForm())
            {
                roomForm.ShowDialog();
            }
        }

        private void houseKeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var HouseKeeping = new HouseKeepingMain())
            {
                HouseKeeping.ShowDialog();
            }
        }
    }
}
