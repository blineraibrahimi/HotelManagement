﻿using HotelManagement.Customers;
using HotelManagement.DAL;
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
using HotelManagement.BLL;

namespace HotelManagement.Bookings
{
    public partial class BookingsMainForm : Form
    {
        public BookingsMainForm()
        {
            InitializeComponent();
        }

        private void BookingsMainForm_Load(object sender, EventArgs e)
        {
            bookingsBindingSource.DataSource = BookingBLL.LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerBooking = new RegisterBooking())
            {
                registerBooking.ShowDialog();
            }
            bookingsBindingSource.DataSource = BookingBLL.LoadData();
        }

        private int ID;
        List<BO.Bookings> selectedRows = new List<BO.Bookings>();
        private void bookingDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(bookingDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            foreach (DataGridViewRow row in bookingDataGridView.SelectedRows)
            {
                selectedRows.Add((BO.Bookings)row.DataBoundItem);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updateBookingForm = new UpdateBooking())
            {
                if (selectedRows.Count != 0)
                {
                    updateBookingForm.bookingData = selectedRows;
                    updateBookingForm.ShowDialog();
                    selectedRows.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            bookingsBindingSource.DataSource = BookingBLL.LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = BookingBLL.DeleteEmployee(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                bookingsBindingSource.DataSource = BookingBLL.LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }
    }
}
