using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Manager : Employee
    {
        public Manager(string name, int attendanceHours, int learninghours,string role) : base(name, attendanceHours, learninghours,role)
        {
        }

        public List<Employee> reportees { get; set; } = new List<Employee>();

        public override int GetAttendanceHours()
        {
            int totalAttendanceHours = 0;

            foreach (var item in this.reportees)
            {
                totalAttendanceHours = totalAttendanceHours + item.GetAttendanceHours();
            }
            return totalAttendanceHours;
        }

        public override int GetLearningHours()
        {
            int totalLearningHours = 0;

            foreach (var item in this.reportees)
            {
                totalLearningHours = totalLearningHours + item.GetLearningHours();
            }
            return totalLearningHours;
        }

        public void AddReportee(Employee emp)
        {
            reportees.Add(emp);
        }
        public void AddReportee(params Employee[] emp)
        {
            reportees.AddRange(emp);
        }

        public override void PrintMandatoryTrainings()
        {
            Console.WriteLine($"Mandatory training for Manager, Role:{this.Role}, Name:{this.Name}");
            foreach (var item in reportees)
            {
                item.PrintMandatoryTrainings();
            }
        }

        public override Employee SearchEmployee(string employeeName)
        {
            Employee employee = null;
            if (this.Name == employeeName) return this;
            else
            {
                foreach (var item in reportees)
                {
                    employee = item.SearchEmployee(employeeName);
                    if (employee != null) break;
                }
            }
            return employee;
        }

        public override void PrintEmployeeDetails(int depth =1)
        {
            Console.WriteLine($"{new string('-', depth * 5)} Employee details: {this.Name} {this.Role}");
            depth++;
            foreach (var item in this.reportees)
            {
                item.PrintEmployeeDetails(depth);
            }
        }
    }
}
