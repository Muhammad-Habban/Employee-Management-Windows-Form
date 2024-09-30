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
    public partial class UpdateDepartment : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public UpdateDepartment(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deptID = deptIdTextBox.Text;
            var budget = budgetTextBox.Text;
            try
            {
                int iDeptID = int.Parse(deptID);
                int iBudget = int.Parse(budget);
                Department dept = employeeBLL.GetDepartmentById(iDeptID);
                if(dept == null)
                {
                    MessageBox.Show("Department Does not exist.");
                }else
                {
                    Department upDept = new Department
                    {
                        DepartmentId = iDeptID,
                        DepartmentName = dept.DepartmentName,
                        Budget = iBudget
                    };
                    if(employeeBLL.UpdateDepartment(upDept) == true)
                    {
                        MessageBox.Show("Department Updated Successfully");
                    }else
                    {
                        MessageBox.Show("Could not Update Department");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
