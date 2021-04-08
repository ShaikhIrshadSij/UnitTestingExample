using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingExample.Data.POCO;
using UnitTestingExample.Repository.Interfaces;
using Xunit;

namespace EmployeeTest
{
    public class EmployeeUnitTest
    {
        [Fact]
        public void GetEmployeeById()
        {
            //mock instance the repo
            var service = new Mock<IEmployeeRepository>();

            //create dummy data
            var dummyData = new List<Employee>() {
                new Employee()
                {
                     EmployeeName = "Test",
                     Department = "Testing",
                     EmployeeId = 1
                },
                new Employee()
                {
                     EmployeeName = "Test 2",
                     Department = "Testing 2",
                     EmployeeId = 2
                }
            };

            //setup the dummy data for particular function we want to check
            service.Setup(x => x.GetEmployeeById(2)).ReturnsAsync(dummyData.Where(x => x.EmployeeId == 2).ToList());

            //count the retured result
            var count = service.Object.GetEmployeeById(2).Result.Count();

            //check expected and actual
            Assert.Equal(1, count);
        }
    }
}
