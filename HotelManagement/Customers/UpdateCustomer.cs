using HotelManagement.BLL;
using HotelManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Customers
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public List<BO.Customers> customerData { get; set; }
        private int ID;

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            foreach (BO.Customers obj in customerData)
            {
                ID = obj.ID;
                txtCusName.Text = obj.CustomerName;
                txtCusLastName.Text = obj.CustomerLastname;
                txtCusAddress.Text = obj.Address;
                txtCusContactNo.Text = obj.ContactNo;
                txtCusIDNo.Text = obj.CustomerIDNo;
                txtCusDsscription.Text = obj.Description;
            }
        }

        private void empUpdatebtn_Click(object sender, EventArgs e)
        {
            var message = CustomersBLL.UpdateCustomer(ID, txtCusName.Text, txtCusLastName.Text, txtCusAddress.Text, txtCusContactNo.Text, txtCusIDNo.Text,txtCusDsscription.Text);
            if (message is true)
            {
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customerData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
