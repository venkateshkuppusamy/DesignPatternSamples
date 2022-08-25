using Decorator.Reload_Display_Decorator.Models;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Reload_Display_Decorator.Services
{
    internal interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
    }
}
