using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Create
        public async Task<string> Create(EmployeeInfo employee)
        {
            _context.Employees.Add(employee);

            await _context.SaveChangesAsync();

            return "Save Succsessfull";
        }

        //Read - get all employee
        public List<EmployeeInfo> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        //Read - get employee by id
        public async Task<EmployeeInfo> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        //Update
        public async Task<string> UpdateEmployee(EmployeeInfo employee)
        {
            _context.Employees.Update(employee);

            await _context.SaveChangesAsync();

            return "Update Successfull";
        }

        //Delete
        public async Task<string> DeleteEmployee(EmployeeInfo employee)
        {
            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync();

            return "Delete Succsessfull";
        }
    }
}
