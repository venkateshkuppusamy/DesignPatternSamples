namespace Composite
{
    public abstract class Employee
    {
        public string Name { get; set; }
        protected int AttendanceHours { get; set; }
        protected int LearningHours { get; set; }
        public string  Role { get; set; }

        public Employee(string name, int attendanceHours, int learninghours, string role)
        {
            this.Name = name;
            this.AttendanceHours = attendanceHours;
            this.LearningHours = learninghours;
            this.Role = role;
        }

        public Employee(string name, int attendanceHours,string role)
        {
            this.Name = name;
            this.AttendanceHours = attendanceHours;
        }
        public abstract int GetAttendanceHours();
        public abstract int GetLearningHours();
        
        public abstract void PrintMandatoryTrainings();

        public abstract Employee SearchEmployee(string employeeName);

        public abstract void PrintEmployeeDetails(int depth=1);

    }
}
