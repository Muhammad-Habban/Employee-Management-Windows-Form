using EmployeeManagementDAL;
using EmployeeManagementDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBLL
{
    public class EmployeeManagementBLL : IEmployeeManagementBLL
    {
        private readonly EmployeeManagementDAL.EmployeeManagementDAL employeeDAL;
        public EmployeeManagementBLL()
        {
            employeeDAL = new EmployeeManagementDAL.EmployeeManagementDAL();
        }
        public List<Employee> GetEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }
        public List<Department> GetDepartment()
        {
            return employeeDAL.GetAllDepartments();
        }
        public Department GetDepartmentById(int id)
        {
            return employeeDAL.GetDepartmentById(id);
        }
        public List<Tuple<Employee, Department>> GetEmployeeWithDetails()
        {
            return employeeDAL.GetEmployeesWithDepartmentDetails();
        }
        public List<Tuple<Department, Tuple<int, int>>> GetDepartmentsWithCountAndSal()
        {
            List<Tuple<Department, Tuple<int, int>>> details = new List<Tuple<Department, Tuple<int, int>>>();
            List<Department> departments = employeeDAL.GetAllDepartments();
            foreach (Department department in departments)
            {
                int count = employeeDAL.GetEmployeeCount(department.DepartmentId);
                int salary = employeeDAL.GetDepartmentSalaryExpenditures(department.DepartmentId);
                Tuple<int, int> firstTuple = new Tuple<int, int>(count, salary);
                Tuple<Department, Tuple<int, int>> secondTuple = new Tuple<Department, Tuple<int, int>>(department, firstTuple);
                details.Add(secondTuple);
            }
            return details;
        }
        public bool CreateEmployee(Employee e)
        {
            Department department = employeeDAL.GetDepartmentByName(e.DepartmentName);
            if (e.Salary < 0 || department == null)
            {
                return false;
            }
            int budget = department.Budget;
            int deptSalary = employeeDAL.GetDepartmentSalaryExpenditures(department.DepartmentId);
            deptSalary += e.Salary;
            if (deptSalary > budget)
            {
                return false;
            }
            employeeDAL.AddEmployee(e);
            return true;
        }
        public bool UpdateEmployee(Employee e)
        {
            if (e.Salary < 0)
            {
                return false;
            }
            if (employeeDAL.GetEmployeeById(e.EmployeeId) == null)
            {
                return false;
            }
            Department department = employeeDAL.GetDepartmentByName(e.DepartmentName);
            if (department == null)
            {
                return false;
            }
            Employee employee = employeeDAL.GetEmployeeById(e.EmployeeId);
            int budget = department.Budget;
            int deptSalary = employeeDAL.GetDepartmentSalaryExpenditures(department.DepartmentId);
            deptSalary += e.Salary;
            deptSalary -= employee.Salary;
            if (deptSalary > budget)
            {
                return false;
            }
            employeeDAL.UpdateEmployee(e);
            return true;
        }
        public bool DeleteEmployee(int EmployeeId)
        {
            if (employeeDAL.GetEmployeeById(EmployeeId) == null)
            {
                return false;
            }
            employeeDAL.DeleteEmployee(EmployeeId);
            return true;
        }
        public bool CreateDepartment(Department d)
        {
            if (d.Budget < 0 || employeeDAL.GetDepartmentByName(d.DepartmentName) != null)
            {
                return false;
            }
            employeeDAL.AddDepartment(d);
            return true;
        }
        public bool UpdateDepartment(Department d)
        {
            if (employeeDAL.GetDepartmentById(d.DepartmentId) == null)
            {
                return false;
            }
            employeeDAL.UpdateDepartment(d);
            return true;
        }
        public bool DeleteDepartment(int DepartmentId)
        {
            if (employeeDAL.GetDepartmentById(DepartmentId) == null)
            {
                return false;
            }
            employeeDAL.DeleteDepartment(DepartmentId);
            return true;
        }
    }
}
