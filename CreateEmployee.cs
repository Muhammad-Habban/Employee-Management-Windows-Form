using EmployeeManagementDTO;
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
    public partial class CreateEmployee : Form
    {
        private EmployeeManagementBLL.EmployeeManagementBLL employeeBLL;
        public CreateEmployee()
        {
            employeeBLL = new EmployeeManagementBLL.EmployeeManagementBLL();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fName = firstNameTextBox.Text;
            var lName = lastNameTextBox.Text;
            var pos = positionTextBox.Text;
            var deptName = departmentNameTextBox.Text;
            var sal = salaryTextBox.Text;
            int iSal = 0;
            try
            {
                iSal = int.Parse(sal);
                Employee emp = new Employee { FirstName = fName, DepartmentName = deptName, LastName = lName, Position = pos, Salary = iSal };
                if (employeeBLL.CreateEmployee(emp) == true)
                {
                    MessageBox.Show("Employee Created Successfully.");
                }
                else
                {
                    MessageBox.Show("Could Not Create an Employee.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
