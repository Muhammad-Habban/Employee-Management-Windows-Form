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
    public partial class DeleteDepartment : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public DeleteDepartment(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deptId = deptIdTextBox.Text;
            try
            {
                int iDeptId = int.Parse(deptId);
                if (employeeBLL.DeleteDepartment(iDeptId) == true)
                {
                    MessageBox.Show("Department Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("Could not Delete Department.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
