using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Reload_Display_Decorator.Services;

namespace Decorator.Reload_Display_Decorator
{
    internal class Startup
    {
        public static void Run() {
            
            IEmployeeService employeeService = new EmployeeService();
            //var employees = employeeService.GetAllEmployees();

            IEmployeeService displayEmployeeService = new DisplayEmployeeService(employeeService);
            //displayEmployeeService.GetAllEmployees();

            IEmployeeService reloadEmployeeService = new ReloadEmployeeService(displayEmployeeService);
            reloadEmployeeService.GetAllEmployees();
        }
    }
}
