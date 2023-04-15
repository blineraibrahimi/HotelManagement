using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Employees;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
