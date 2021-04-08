using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingExample.Data.POCO;

namespace UnitTestingExample.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeeById(int employeeId);
    }
}
