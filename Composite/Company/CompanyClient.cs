using System;

namespace Composite.Company
{
    class CompanyClient
    {
        public static void Run()
        {
            var ceo = BuildCompany();
            ceo.PrintEmployeeDetails();

            while (true)
            {
                Console.WriteLine("Select the required Operation");
                Console.WriteLine("1. Get Attendace Hours");
                Console.WriteLine("2. Get Learnining Hours");
                Console.WriteLine("3. Print Mandatory Trainings");

                int operationID = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Enter Employee name");
                    string str = Console.ReadLine();
                    var employee = ceo.SearchEmployee(str);
                    if(employee == null)
                    { Console.WriteLine("Enter a valid employee"); }
                    switch (operationID)
                    {
                        case 1:
                            Console.WriteLine($"Attendance Hours: {employee.GetAttendanceHours()}");
                            break;
                        case 2:
                            Console.WriteLine($"Learning Hours: {employee.GetLearningHours()}");
                            break;
                        case 3:
                            employee.PrintMandatoryTrainings();
                            break;
                        default:
                            Console.WriteLine("Enter a valid operation");
                            break;
                    }
                }
            }
        }

        private static Manager BuildCompany()
        {
            Manager ceo = new Manager("KP", 300, 10, "CEO");//total 3407
            IndividualContriubtor chiefArchitect = new IndividualContriubtor("AnanadRaj", 200, 20, "Chief Architect");
            Manager groupManager1 = new Manager("Sadish", 200, 10, "Group Manager");
            Manager groupManager2 = new Manager("Sashi", 210, 5, "Group Manager");
            Manager groupManager3 = new Manager("Ansari", 200, 15, "Group Manager");
            ceo.AddReportee(chiefArchitect, groupManager1, groupManager2, groupManager3);

            IndividualContriubtor principalArchitect1 = new IndividualContriubtor("Sravanthi", 220, 15, "Principal Architect");
            IndividualContriubtor businessAnalyst1 = new IndividualContriubtor("Ravi Singaram", 240, 2, "Business Analyst");
            IndividualContriubtor scrumMaster1 = new IndividualContriubtor("Archana", 170, 10, "Scrum Master");
            Manager techManager1 = new Manager("Naveen", 190, 12, "Tech Manager");

            groupManager1.AddReportee(principalArchitect1, businessAnalyst1, scrumMaster1, techManager1);

            IndividualContriubtor principalArchitect2 = new IndividualContriubtor("Venki", 221, 15, "Principal Architect");
            IndividualContriubtor businessAnalyst2 = new IndividualContriubtor("Shree pradha", 221, 13, "Business Analyst");
            IndividualContriubtor scrumMaster2 = new IndividualContriubtor("Asha", 179, 6, "Scrum Master");
            Manager techManager2 = new Manager("AnandRamana", 190, 12, "Tech Manager");

            groupManager2.AddReportee(principalArchitect2, businessAnalyst2, scrumMaster2, techManager2);

            IndividualContriubtor principalArchitect3 = new IndividualContriubtor("Raju", 220, 15, "Principal Architect");
            IndividualContriubtor businessAnalyst3 = new IndividualContriubtor("Arun", 240, 2, "Business Analyst");
            IndividualContriubtor scrumMaster3 = new IndividualContriubtor("Pravitha", 170, 10, "Scrum Master");
            Manager techManager3 = new Manager("Karthik Nag", 190, 12, "Tech Manager");

            groupManager3.AddReportee(principalArchitect3, businessAnalyst3, scrumMaster3, techManager3);

            IndividualContriubtor developer1 = new IndividualContriubtor("Priya", 150, 30, "Developer");
            IndividualContriubtor developer2 = new IndividualContriubtor("Tarunam", 152, 30, "Developer");
            IndividualContriubtor tester1 = new IndividualContriubtor("Arun dontula", 140, 30, "Tester");
            Contractor contractor1 = new Contractor("contractor 1", 190, new ContractorTrainingService()) { ContractorName = "HCL" };

            techManager1.AddReportee(developer1, developer2, tester1);

            IndividualContriubtor developer3 = new IndividualContriubtor("Boobalan", 150, 30, "Developer");
            IndividualContriubtor developer4 = new IndividualContriubtor("Muthu", 152, 30, "Developer");
            IndividualContriubtor tester2 = new IndividualContriubtor("Mahi", 140, 30, "Tester");
            Contractor contractor2 = new Contractor("contractor 2", 190, new ContractorTrainingService()) { ContractorName = "Sasken" };

            techManager2.AddReportee(developer3, developer4, tester2);

            IndividualContriubtor developer5 = new IndividualContriubtor("Micheal", 150, 30, "Developer");
            IndividualContriubtor developer6 = new IndividualContriubtor("Jayapal", 152, 30, "Developer");
            IndividualContriubtor tester3 = new IndividualContriubtor("Vinoth", 140, 30, "Tester");
            Contractor contractor3 = new Contractor("contractor 3", 190, new ContractorTrainingService()) { ContractorName = "ARI" };

            techManager3.AddReportee(developer5, developer6, tester3);


            //Console.WriteLine($"Attendance hours {ceo.GetAttendanceHours()}");
            //Console.WriteLine($"Learning hours {ceo.GetLearningHours()}");

            techManager1.AddReportee(contractor1);
            techManager2.AddReportee(contractor2);
            techManager3.AddReportee(contractor3);
            return ceo;
        }
    }
}
