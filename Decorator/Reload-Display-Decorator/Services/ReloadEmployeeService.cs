using System;
using System.Collections.Generic;
using Decorator.Reload_Display_Decorator.Models;

namespace Decorator.Reload_Display_Decorator.Services
{
    internal class ReloadEmployeeService : IEmployeeService
    {
        private readonly IEmployeeService employeeService;

        public ReloadEmployeeService(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public List<Employee> GetAllEmployees()
        {
            for (int i = 0; i < 10; i++)
            {
                employeeService.GetAllEmployees();
                Console.WriteLine("Enter any key to reload");
                Console.Read();
            }
            return new List<Employee>();

        }
    }
}
