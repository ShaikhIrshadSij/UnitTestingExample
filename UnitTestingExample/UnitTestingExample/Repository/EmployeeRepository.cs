using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingExample.Data;
using UnitTestingExample.Data.POCO;
using UnitTestingExample.Repository.Interfaces;

namespace UnitTestingExample.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Employee>> GetEmployeeById(int employeeId) => await _context.Employees.Where(x => x.EmployeeId == employeeId).ToListAsync();
    }
}
