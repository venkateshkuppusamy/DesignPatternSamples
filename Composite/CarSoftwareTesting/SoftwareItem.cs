using System.Threading.Tasks;

namespace Composite
{
    public abstract class SoftwareItem
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public SwType Type { get; set; }
        public string TestingStatus { get; set; } = "Not Started";
        public string IntegrationStatus { get; set; }

        public SoftwareItem(string name, string version, SwType type)
        {
            this.Name = name;
            this.Version = version;
            this.Type = type;
        }

        protected SoftwareItem(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public abstract SoftwareItem Search(string name);
        public abstract Task RunTestsAsync();

        public abstract void RunTests();

        public abstract void GetTestingStatus();

        public abstract void PushToIntegration();

        public override string ToString()
        {
            return $"Name:{this.Name}, Version: {this.Version}, Type: {this.Type.ToString()}";
        }


    }

    public enum SwType
    { 
        Unit = 1, Section = 2, Domain = 3, Functional = 4, Complete = 5

    }

}
