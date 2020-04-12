using System;

namespace Composite
{
    public class Contractor : Employee
    {
        private ContractorTrainingService service;
        public string ContractorName { get; set; }
        public Contractor(string name, int attendanceHours, ContractorTrainingService service) : base(name, attendanceHours,"Contractor")
        {
            this.service = service;
        }

        public override int GetAttendanceHours()
        {
            return this.AttendanceHours;
        }

        public override int GetLearningHours()
        {
            return 0;
        }

        public override void PrintMandatoryTrainings()
        {
            string str = this.service.Get(this.ContractorName);
            Console.WriteLine($"Mandatory trainings for Contractor Company {this.ContractorName} Role:{this.Role} Contractor {this.Name} \n{str}");
        }
        public override Employee SearchEmployee(string employeeName)
        {
            if (this.Name == employeeName) return this;
            return null;
        }

        public override void PrintEmployeeDetails(int depth)
        {
            Console.WriteLine($"{new string('-', depth * 5)} Employee Details: {this.Name}, {this.Role}, {this.ContractorName}");
        }
    }

    public class ContractorTrainingService
    {
        public string Get(string contractorName)
        {
            return $"Training details from {contractorName}";
        }
    }
}
