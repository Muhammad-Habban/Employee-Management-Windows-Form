using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApplication
{
    public partial class DeleteEmployee : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public DeleteEmployee(EmployeeManagementBLL.IEmployeeManagementBLL _employeeBLL)
        {
            InitializeComponent();
            employeeBLL = _employeeBLL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empId = employeeIdTextBox.Text;
            try
            {
                int iEmpId = int.Parse(empId);
                if(employeeBLL.DeleteEmployee(iEmpId) == true)
                {
                    MessageBox.Show("Employee Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("Could not Delete Employee.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
