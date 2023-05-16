using HotelManagement.BLL;
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
    public partial class UpdatePayment : Form
    {
        public UpdatePayment()
        {
            InitializeComponent();
            txtBookingId.Enabled = false;
            txtAmount.Enabled = false;

        }

        public List<BO.Payments> paymentData { get; set; }
        private int ID;

        private void UpdatePayment_Load(object sender, EventArgs e)
        {
            foreach (BO.Payments obj in paymentData)
            {
                ID = obj.ID;
                txtBookingId.Text = Convert.ToString(obj.BookingID);
                txtAmount.Text = Convert.ToString(obj.Amount);
                cmbPaymentType.Text = obj.PaymentType;
                txtPaymentDetails.Text = obj.PaymentDetails;
                paymentDatePicker.Value = DateTime.Now;
                cmbPaymentStatus.Text = obj.Status;
                txtDescription.Text = obj.Description;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var message = PaymentBLL.UpdatePayment(ID, Convert.ToInt32(txtBookingId.Text), Convert.ToDecimal(txtAmount.Text), cmbPaymentType.SelectedItem.ToString(), txtPaymentDetails.Text, paymentDatePicker.Value, cmbPaymentStatus.SelectedItem.ToString(), txtDescription.Text);


            if (message is true)
            {
                MessageBox.Show("Record Updated Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            paymentData.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
