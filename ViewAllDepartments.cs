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
    public partial class ViewAllDepartments : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public ViewAllDepartments(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void ViewAllDepartments_Load(object sender, EventArgs e)
        {
            List<Department> depts = employeeBLL.GetDepartment();
            dataGridViewAllDepts.DataSource = depts;
        }
    }
}
