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
using HotelManagement.DAL;

namespace HotelManagement.Customers
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void cusRegisterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCusName.Text) || string.IsNullOrWhiteSpace(txtCusLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCusAddress.Text) || string.IsNullOrWhiteSpace(txtCusContactNo.Text) || string.IsNullOrWhiteSpace(txtCusIDNo.Text) ||
                string.IsNullOrWhiteSpace(txtCusDsscription.Text))
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //convert to bll
            DACustomers.SaveCustomerToDB(txtCusName.Text, txtCusLastName.Text, txtCusAddress.Text, txtCusContactNo.Text, txtCusIDNo.Text, txtCusDsscription.Text);


            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);    

            this.Close();
        }
    }
}
