using AbstractFactory.SimpleDemo.Factory1;
using AbstractFactory.SimpleDemo.Factory2;
using AbstractFactory.SimpleDemo.Interfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Use Products from Factory 1");
            IAbstractFactory factory = new ConcreteFactory1();
            IProductA productA1 = factory.GetProductA();
            IProductB productB1 = factory.GetProductB();

            productA1.MethodX(); productA1.MethodY();
            productB1.Method1(); productB1.Method2();

            Console.WriteLine("Use Products from Factory 2");
            factory = new ConcreteFactory2();
            IProductA productA2 = factory.GetProductA();
            IProductB productB2 = factory.GetProductB();

            productA2.MethodX(); productA2.MethodY();
            productB2.Method1(); productB2.Method2();

            Console.ReadLine();
        }
    }
}
