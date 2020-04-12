using Composite.Basic;
using Composite.Company;
using System;
using System.Linq;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Company();
        }

        public static void BasicComposite()
        {
            Client client = new Client();
            client.BasicComposite();
        }

        public static void Company()
        {
            CompanyClient.Run();
        }
        
    }
}
