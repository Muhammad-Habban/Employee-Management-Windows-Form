using Microsoft.Extensions.DependencyInjection;
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
    public partial class Form1 : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public Form1()
        {
            employeeBLL = Program.serviceProvider.GetRequiredService<EmployeeManagementBLL.IEmployeeManagementBLL>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAllEmployees viewAllEmployees = new ViewAllEmployees(employeeBLL);
            viewAllEmployees.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllDepartments viewAllDepartments = new ViewAllDepartments(employeeBLL);
            viewAllDepartments.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEmployeesWithDept viewEmployeesWithDept = new ViewEmployeesWithDept(employeeBLL);
            viewEmployeesWithDept.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateEmployee createEmployee = new CreateEmployee();
            createEmployee.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(employeeBLL);
            updateEmployee.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new DeleteEmployee(employeeBLL);
            deleteEmployee.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DeleteDepartment deleteDepartment = new DeleteDepartment(employeeBLL);
            deleteDepartment.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            UpdateDepartment updateDepartment = new UpdateDepartment(employeeBLL);
            updateDepartment.ShowDialog();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            CreateDepartment createDepartment = new CreateDepartment();
            createDepartment.ShowDialog();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ViewDepartmentWithDetails viewDepartmentWithDetails = new ViewDepartmentWithDetails(employeeBLL);
            viewDepartmentWithDetails.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
