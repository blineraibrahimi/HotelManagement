﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BLL;
using HotelManagement.Bookings;
using HotelManagement.Customers;
using HotelManagement.Employees;
using HotelManagement.Payment;
using HotelManagement.Room;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = BookingBLL.LoadData();
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
            using (var houseKeepingForm = new HouseKeepingMain())
            {
                houseKeepingForm.ShowDialog();
            }
        }

        private void bookARoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var bookARoomForm = new BookingsMainForm())
            {
                bookARoomForm.ShowDialog();
            }
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var paymentForm = new PaymentMainForm())
            {
                paymentForm.ShowDialog();
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            using (var bookroom = new RegisterBooking())
            {
                bookroom.ShowDialog();
            }
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
            dataGridView1.DataSource = BookingBLL.LoadData();
        }


    }
}
