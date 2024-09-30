using EmployeeManagementDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBLL
{
    public interface IEmployeeManagementBLL
    {
        List<Employee> GetEmployees();
        List<Department> GetDepartment();
        List<Tuple<Employee, Department>> GetEmployeeWithDetails();
        List<Tuple<Department, Tuple<int, int>>> GetDepartmentsWithCountAndSal();
        bool CreateEmployee(Employee e);
        bool UpdateEmployee(Employee e);
        bool DeleteEmployee(int EmployeeId);
        bool CreateDepartment(Department d);
        bool UpdateDepartment(Department d);
        bool DeleteDepartment(int DepartmentId);
        Department GetDepartmentById(int id);
    }
}
