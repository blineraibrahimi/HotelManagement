using HotelManagement.BLL;
using HotelManagement.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Payment
{
    public partial class PaymentMainForm : Form
    {
        public PaymentMainForm()
        {
            InitializeComponent();
        }

        private void PaymentMainForm_Load(object sender, EventArgs e)
        {
            paymentsBindingSource.DataSource = PaymentBLL.LoadData();
        }

        private int ID;
        List<BO.Payments> selectedRows = new List<BO.Payments>();
        private void paymentDVG_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(paymentDVG.Rows[e.RowIndex].Cells[0].Value.ToString());


            foreach (DataGridViewRow row in paymentDVG.SelectedRows)
            {
                selectedRows.Add((BO.Payments)row.DataBoundItem);
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (var updatePaymentForm = new UpdatePayment())
            {
                if (selectedRows.Count != 0)
                {
                    updatePaymentForm.paymentData = selectedRows;
                    updatePaymentForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            paymentsBindingSource.DataSource = PaymentBLL.LoadData();
            selectedRows.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var message = PaymentBLL.DeletePayment(ID);

            if (message is true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                paymentsBindingSource.DataSource = PaymentBLL.LoadData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            selectedRows.Clear();

        }
    }
}
