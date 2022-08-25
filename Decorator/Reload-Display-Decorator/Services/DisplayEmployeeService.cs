using System;
using System.Collections.Generic;
using Decorator.Reload_Display_Decorator.Models;

namespace Decorator.Reload_Display_Decorator.Services
{
    internal class DisplayEmployeeService : IEmployeeService
    {
        private readonly IEmployeeService employeeService;

        public DisplayEmployeeService(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = employeeService.GetAllEmployees();
            employees.ForEach(e => Console.WriteLine($"Id: {e.Id}, Name: {e.Name}"));
            return employees;
        }
    }
}
