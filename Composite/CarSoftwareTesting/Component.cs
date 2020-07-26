using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Composite
{
    public class Component : SoftwareItem
    {
        public Component(string name, string version, SwType type) : base(name, version, type)
        {
        }

        public List<SoftwareItem> softwareItems { get; set; } = new List<SoftwareItem>();

        public override void GetTestingStatus()
        {
            foreach (var item in this.softwareItems)
            {
                item.GetTestingStatus();
                if (item.TestingStatus == "Started")
                {
                    this.TestingStatus = "Started";
                    break;
                }
                else if(item.TestingStatus == "Running")
                {
                    this.TestingStatus = "Running";
                    break;
                }
            }
            Console.WriteLine($"Testing status of {this.ToString()} -- {this.TestingStatus}");
        }

        public override void PushToIntegration()
        {
            Console.WriteLine($"Pushing software to Integation {this.ToString()}");
            foreach (var item in this.softwareItems)
            {
                item.PushToIntegration();
            }
        }

        public async override Task RunTestsAsync()
        {
            await Task.Factory.StartNew(async () =>
            {
                Thread.Sleep(1000);
                foreach (var item in this.softwareItems)
                {
                    await item.RunTestsAsync();
                }
            });
            Console.WriteLine($"Run test for software Unit {this.ToString()}");
        }


        public override void RunTests()
        {
            Thread.Sleep(1000);
            foreach (var item in this.softwareItems)
            {
                item.RunTests();
            }
            this.TestingStatus = this.softwareItems.OrderBy(OrderOnTestingStatus).First().TestingStatus;

            Console.WriteLine($"Run test for software Unit {this.ToString()}");
        }

        private static int OrderOnTestingStatus(SoftwareItem item)
        {
            if (item.TestingStatus == "Started")
            {
                return 0;
            }
            else if (item.TestingStatus == "Running")
            {
                return 1;
            }
            return 2;
            
        }
        public override SoftwareItem Search(string name)
        {
            if(this.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return this;
            foreach (var item in this.softwareItems)
            {
                var softwareItem =  item.Search(name);
                if (softwareItem != null)
                {
                    return softwareItem;
                }
            }

            return null;
        }

        public void Add(params SoftwareItem[] softwareItems)
        {
            this.softwareItems.AddRange(softwareItems);
        }
        
    }

}
