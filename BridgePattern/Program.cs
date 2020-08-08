using BridgePattern.BasicDemo;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************Use combination 1**********************************");
            Abstractor abstractor11 = new ConcreteAbstractor(new Implementor1());

            Console.WriteLine(abstractor11.Method1());
            abstractor11.Method2();

            Console.WriteLine("***********************Use combination 2**********************************");

            Abstractor abstractor12 = new ConcreteAbstractor(new Implementor2());

            Console.WriteLine(abstractor12.Method1());
            abstractor12.Method2();

            Console.WriteLine("***********************Use combination 3**********************************");

            Abstractor abstractor21 = new ConcreteAbstractor2(new Implementor1());

            Console.WriteLine(abstractor21.Method1());
            abstractor21.Method2();

            Console.WriteLine("***********************Use combination 4**********************************");

            Abstractor abstractor22 = new ConcreteAbstractor2(new Implementor2());

            Console.WriteLine(abstractor22.Method1());
            abstractor22.Method2();

            Console.ReadLine();

        }
    }
}
