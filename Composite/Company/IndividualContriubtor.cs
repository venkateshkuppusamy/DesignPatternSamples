using System;

namespace Composite
{
    public class IndividualContriubtor : Employee
    {
        public IndividualContriubtor(string name, int attendanceHours, int learninghours,string role) : base(name, attendanceHours, learninghours,role)
        {
        }

        public override int GetAttendanceHours()
        {
            return this.AttendanceHours;
        }

        public override int GetLearningHours()
        {
            return this.LearningHours;
        }

        public override void PrintEmployeeDetails(int depth)
        {
            Console.WriteLine($"{new string('-',depth*5)} Employee Details {this.Name}, {this.Role}");
        }

        public override void PrintMandatoryTrainings()
        {
            Console.WriteLine($"Mandatory trainings for individual contributor, Role:{this.Role} Name:{this.Name}");
        }

        public override Employee SearchEmployee(string employeeName)
        {
            if (this.Name == employeeName) return this;
            return null;
        }
    }
}
