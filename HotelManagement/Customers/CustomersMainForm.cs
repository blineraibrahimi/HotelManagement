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
            LoadData();
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            using (var registerCustomer = new RegisterCustomer())
            {
                registerCustomer.ShowDialog();
            }
            LoadData();
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
                    selectedRows.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteCustomer, parameters);

                MessageBox.Show("Record Deleted Successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();
        }

        //-------------------------------------------
        public void LoadData()
        {
            var employees = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetCustomers, null).ToCustomerList();
            customersBindingSource.DataSource = employees;
        }

    }
}
