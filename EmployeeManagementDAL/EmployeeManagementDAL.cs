using Dapper;
using EmployeeManagementDTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDAL
{
    public class EmployeeManagementDAL : IEmployeeManagementDAL
    {
        private string connectionString;
        public EmployeeManagementDAL()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;";
        }

        // Employees functions
        public Employee GetEmployeeById(int EmployeeId)
        {
            Employee emp = new Employee();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Employee where EmployeeId = @EmployeeId";
                emp = connection.QueryFirstOrDefault<Employee>(query, new { EmployeeId = EmployeeId });
            }
            return emp;
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Employee";
                employees = connection.Query<Employee>(query).ToList();
            }
            return employees;
        }
        public void AddEmployee(Employee e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into Employee values(@FirstName, @LastName, @Position, @Salary, @DepartmentName)";
                connection.Execute(query, e);
            }
        }
        public void DeleteEmployee(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Delete From Employee where EmployeeId = @EmployeeId";
                connection.Execute(query, new { EmployeeId = EmployeeId });
            }
        }
        public void UpdateEmployee(Employee e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Update Employee set FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary, DepartmentName = @DepartmentName where EmployeeId = @EmployeeId";
                connection.Execute(query, e);
            }
        }

        // Department dunctions
        public Department GetDepartmentById(int DepartmentId)
        {
            Department dept = new Department();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Department where DepartmentId = @DepartmentId";
                dept = connection.QueryFirstOrDefault<Department>(query, new { DepartmentId = DepartmentId });
            }
            return dept;
        }
        public Department GetDepartmentByName(string DepartmentName)
        {
            Department dept = new Department();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Department where DepartmentName = @DepartmentName";
                dept = connection.QueryFirstOrDefault<Department>(query, new { DepartmentName = DepartmentName });
            }
            return dept;
        }
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Department";
                departments = connection.Query<Department>(query).ToList();
            }
            return departments;
        }
        public void AddDepartment(Department d)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into Department values(@DepartmentName ,@Budget )";
                connection.Execute(query, d);
            }
        }
        public void UpdateDepartment(Department d)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Update Department set DepartmentName = @DepartmentName ,Budget = @Budget  where DepartmentId = @DepartmentId";
                connection.Execute(query, d);
            }
        }
        public void DeleteDepartment(int DepartmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Delete From Department where DepartmentId = @DepartmentId";
                connection.Execute(query, new { DepartmentId = DepartmentId });
            }
        }

        // Helper functions
        public int GetDepartmentSalaryExpenditures(int DepartmentId)
        {
            int salary = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select sum(salary) from department inner join employee on employee.departmentName = department.departmentName where department.departmentId = @DepartmentId";
                salary = connection.ExecuteScalar<int>(query, new { DepartmentId = DepartmentId });
            }
            return salary;
        }

        public List<Tuple<Employee, Department>> GetEmployeesWithDepartmentDetails()
        {
            List<Tuple<Employee, Department>> details = new List<Tuple<Employee, Department>>();
            List<Employee> employees = GetAllEmployees();
            foreach (Employee emp in employees)
            {
                Department dept = GetDepartmentByName(emp.DepartmentName);
                Tuple<Employee, Department> tuple = new Tuple<Employee, Department>(emp, dept);
                details.Add(tuple);
            }
            return details;
        }
        public int GetEmployeeCount(int DepartmentId)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select count(*) from department inner join employee on employee.departmentName = department.departmentName where department.departmentId = @DepartmentId";
                count = connection.ExecuteScalar<int>(query, new { DepartmentId = DepartmentId });
            }
            return count;
        }

    }
}
