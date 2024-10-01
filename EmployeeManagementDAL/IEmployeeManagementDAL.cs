using EmployeeManagementDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDAL
{
    public interface IEmployeeManagementDAL
    {

        // Employees functions
        Employee GetEmployeeById(int EmployeeId);
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee e);
        void DeleteEmployee(int EmployeeId);
        void UpdateEmployee(Employee e);

        // Department dunctions
        Department GetDepartmentById(int DepartmentId);
        Department GetDepartmentByName(string DepartmentName);
        List<Department> GetAllDepartments();
        void AddDepartment(Department d);
        void UpdateDepartment(Department d);
        void DeleteDepartment(int DepartmentId);

        // Helper functions
        int GetDepartmentSalaryExpenditures(int DepartmentId);

        List<Tuple<Employee, Department>> GetEmployeesWithDepartmentDetails();
        int GetEmployeeCount(int DepartmentId);
    }
}
