﻿using HotelManagement.BLL;
using HotelManagement.DAL;
using HotelManagement.DAL.Helpers;
using HotelManagement.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Customers
{
    public partial class CustomersMainForm : Form
    {
        public CustomersMainForm()
        {
            InitializeComponent();
        }

        private void CustomersMainForm_Load(object sender, EventArgs e)
        {
            customersBindingSource.DataSource = CustomersBLL.LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerCustomer = new RegisterCustomer())
            {
                registerCustomer.ShowDialog();
            }
            customersBindingSource.DataSource = CustomersBLL.LoadData();
        }

        private int ID;
        List<BO.Customers> selectedRows = new List<BO.Customers>();
        private void customerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            foreach (DataGridViewRow row in customerDataGridView.SelectedRows)
            {
                selectedRows.Add((BO.Customers)row.DataBoundItem);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updateCustomerForm = new UpdateCustomer())
            {
                if (selectedRows.Count != 0)
                {
                    updateCustomerForm.customerData = selectedRows;
                    updateCustomerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            customersBindingSource.DataSource = CustomersBLL.LoadData();
            selectedRows.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = CustomersBLL.DeleteCustomer(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                customersBindingSource.DataSource = CustomersBLL.LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
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

            customersBindingSource.DataSource = CustomersBLL.LoadData();
        }
    }
}
