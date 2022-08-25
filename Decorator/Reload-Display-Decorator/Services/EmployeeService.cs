using System.Collections.Generic;
using Decorator.Reload_Display_Decorator.Models;

namespace Decorator.Reload_Display_Decorator.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            return EmployeeData.GetEmployees();
        }
    }
}
