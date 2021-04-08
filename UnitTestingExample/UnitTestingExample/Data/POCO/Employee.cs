using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestingExample.Data.POCO
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName {get;set;}
        public string Department { get; set; }
    }
}
