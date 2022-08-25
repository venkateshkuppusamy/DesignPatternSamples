using Bogus;
using System.Collections.Generic;

namespace Decorator.Reload_Display_Decorator.Models
{
    internal class EmployeeData
    {
        public static List<Employee> GetEmployees()
        {
            var employeeGenerator = new Faker<Employee>()
             .RuleFor(o => o.Id, f => f.Random.Int(10000))
             .RuleFor(o => o.Name, f => f.Name.FullName());
            return employeeGenerator.Generate(1000);
        }
    }
}
