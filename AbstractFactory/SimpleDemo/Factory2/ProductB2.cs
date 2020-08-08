using AbstractFactory.SimpleDemo.Interfaces;
using System;

namespace AbstractFactory.SimpleDemo.Factory2
{
    internal class ProductB2 : IProductB
    {
        public void Method1()
        {
            Console.WriteLine($"{nameof(ProductB2)} Method 1 is executed");
        }

        public void Method2()
        {
            Console.WriteLine($"{nameof(ProductB2)} Method 1 is executed");
        }
    }
}
