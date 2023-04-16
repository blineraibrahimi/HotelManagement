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
            if (ID != 0)
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                    new SqlParameter("@CustomerName", SqlDbType.VarChar) { Value = txtCusName.Text },
                    new SqlParameter("@CustomerLastname", SqlDbType.VarChar) { Value = txtCusLastName.Text },
                    new SqlParameter("@Address", SqlDbType.VarChar) { Value = txtCusAddress.Text },
                    new SqlParameter("@ContactNo", SqlDbType.VarChar) { Value = txtCusContactNo.Text },
                    new SqlParameter("@CustomerIDNo", SqlDbType.VarChar) { Value = txtCusIDNo.Text },
                    new SqlParameter("@Description", SqlDbType.VarChar) { Value = txtCusDsscription.Text },
                };

                var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateCustomer, parameters);

                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            customerData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
