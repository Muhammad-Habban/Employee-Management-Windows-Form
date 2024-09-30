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
    public partial class CreateDepartment : Form
    {
        private EmployeeManagementBLL.EmployeeManagementBLL employeeBLL;
        public CreateDepartment()
        {
            employeeBLL = new EmployeeManagementBLL.EmployeeManagementBLL();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deptName = deptNameTextBox.Text;
            var budget = budgetTextBox.Text;
            int iBudget = 0;
            try
            {
                iBudget = int.Parse(budget);
                Department dept = new Department {DepartmentName = deptName, Budget = iBudget };
                if (employeeBLL.CreateDepartment(dept) == true)
                {
                    MessageBox.Show("Department Created Successfully.");
                }
                else
                {
                    MessageBox.Show("Could Not Create an Department.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
