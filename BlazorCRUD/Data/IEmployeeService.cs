using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public interface IEmployeeService
    {
        Task<string> Create(EmployeeInfo employee);
        Task<string> DeleteEmployee(EmployeeInfo employee);
        Task<EmployeeInfo> GetEmployeeById(int id);
        List<EmployeeInfo> GetEmployees();
        Task<string> UpdateEmployee(EmployeeInfo employee);
    }
}