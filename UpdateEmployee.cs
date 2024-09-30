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
    public partial class UpdateEmployee : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public UpdateEmployee(EmployeeManagementBLL.IEmployeeManagementBLL _employeeBLL)
        {
            InitializeComponent();
            employeeBLL = _employeeBLL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fName = firstNameTextBox.Text;
            var empId = employeeIdTextBox.Text;
            var lName = lastNameTextBox.Text;
            var pos = positionTextBox.Text;
            var deptName = departmentNameTextBox.Text;
            var sal = salaryTextBox.Text;
            int iSal;
            int iEmpId;
            try
            {
                iSal = int.Parse(sal);
                iEmpId = int.Parse(empId);
                Employee emp = new Employee { EmployeeId = iEmpId, FirstName = fName, DepartmentName = deptName, LastName = lName, Position = pos, Salary = iSal };
                if (employeeBLL.UpdateEmployee(emp) == true)
                {
                    MessageBox.Show("Employee Updated Successfully.");
                }
                else
                {
                    MessageBox.Show("Could Not Update the Employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
