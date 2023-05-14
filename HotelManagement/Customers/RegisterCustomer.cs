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
using HotelManagement.BLL;

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
            var message = CustomersBLL.RegisterCustomer(txtCusName.Text, txtCusLastName.Text, txtCusAddress.Text, txtCusContactNo.Text, txtCusIDNo.Text, txtCusDsscription.Text);

            if (message is false)
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);    

            this.Close();
        }
    }
}
