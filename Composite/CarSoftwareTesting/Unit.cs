using System;
using System.Threading;
using System.Threading.Tasks;

namespace Composite
{
    public class Unit : SoftwareItem
    {
        public Unit(string name, string version, SwType type) : base(name, version, type)
        {
        }

        public override void GetTestingStatus()
        {
            Console.WriteLine($"Testing status of {this.ToString()} -- {this.TestingStatus}");
        }

        public override void PushToIntegration()
        {
            Console.WriteLine($"Pushing software to Integation {this.ToString()}");

            Task.Factory.StartNew(() => { Thread.Sleep(1000); });
        }

        public async override Task RunTestsAsync()
        {
            await Task.Factory.StartNew(() => {
            this.TestingStatus = "Started";
            Console.WriteLine($"Test started for software Unit {this.ToString()}");
            Thread.Sleep(1000);
            this.TestingStatus = "Running";
            Console.WriteLine($"Test Running for software Unit {this.ToString()}");
            Thread.Sleep(1000);
            this.TestingStatus = "Complete";
            Console.WriteLine($"Test Complete for software Unit {this.ToString()}");
            });
            return;
             
        }

        public  override void RunTests()
        {
            Console.WriteLine("");
            this.TestingStatus = "Started";
            Console.WriteLine($"Test started for software Unit {this.ToString()}");
            Thread.Sleep(1000);
            this.TestingStatus = "Running";
            Console.WriteLine($"Test Running for software Unit {this.ToString()}");
            Thread.Sleep(1000);
            this.TestingStatus = "Complete";
            Console.WriteLine($"Test Complete for software Unit {this.ToString()}");
            Console.WriteLine("########################################################");
            return;

        }


        public override SoftwareItem Search(string name)
        {
            return this.Name.Equals(name,StringComparison.OrdinalIgnoreCase) ? this : null; 
        }
    }

}
