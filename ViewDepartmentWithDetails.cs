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
    public partial class ViewDepartmentWithDetails : Form
    {
        private EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL;
        public ViewDepartmentWithDetails(EmployeeManagementBLL.IEmployeeManagementBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void ViewDepartmentWithDetails_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Department ID", 150);
            listView1.Columns.Add("Department Name", 150);
            listView1.Columns.Add("Budget", 150);
            listView1.Columns.Add("Total Employees", 150);
            listView1.Columns.Add("Total Expenditures", 150);

            List<Tuple<Department, Tuple<int, int>>> details = employeeBLL.GetDepartmentsWithCountAndSal();
            foreach(var item in details)
            {
                Department dept = item.Item1;
                var empCount = item.Item2.Item1;
                var salary = item.Item2.Item2;
                ListViewItem listItem = new ListViewItem(new[]
                {
                    dept.DepartmentId.ToString(),
                    dept.DepartmentName,
                    dept.Budget.ToString(),
                    empCount.ToString(),
                    salary.ToString()
                });
                listView1.Items.Add(listItem);
            }

        }
    }
}
