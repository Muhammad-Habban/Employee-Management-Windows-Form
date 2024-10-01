using EmployeeManagementBLL;
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
    public partial class SearchEmployee : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public SearchEmployee(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = empQuery.Text;
            List<Employee> employees = employeeBLL.GetEmployees();
            var searchedEmployees = employees.Where(emp => (emp.FirstName == query || emp.LastName == query || emp.DepartmentName == query)).ToList();
            dataGridView1.DataSource = searchedEmployees;
        }
    }
}
