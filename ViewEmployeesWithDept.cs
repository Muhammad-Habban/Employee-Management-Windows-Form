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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementApplication
{
    public partial class ViewEmployeesWithDept : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public ViewEmployeesWithDept(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void ViewEmployeesWithDept_Load(object sender, EventArgs e)
        {
            List<Tuple<Employee, Department>> datails = employeeBLL.GetEmployeeWithDetails();
            listView1.View = View.Details;
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("Position", 100);
            listView1.Columns.Add("Salary", 100);
            listView1.Columns.Add("Department Name", 150);
            listView1.Columns.Add("Department Budget", 150);

            foreach (var tuple in datails)
            {
                var employee = tuple.Item1;
                var department = tuple.Item2;

                ListViewItem item = new ListViewItem(new[]
                {
                    employee.FirstName,
                    employee.LastName,
                    employee.Position,
                    employee.Salary.ToString(),
                    department.DepartmentName,
                    department.Budget.ToString()
                });

                listView1.Items.Add(item);
            }

        }
    }
}
