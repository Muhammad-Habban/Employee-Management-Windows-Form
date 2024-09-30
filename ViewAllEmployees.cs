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
    public partial class ViewAllEmployees : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public ViewAllEmployees(EmployeeManagementBLL.IEmployeeManagementBLL _employeeBLL)
        {
            employeeBLL = _employeeBLL;
            InitializeComponent();
        }

        private void ViewAllEmployees_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeBLL.GetEmployees();
            dataGridViewAllEmps.DataSource = employees;
        }
    }
}
