using AbstractFactory.SimpleDemo.Interfaces;
using System;

namespace AbstractFactory.SimpleDemo.Factory2
{
    internal class ProductA2 : IProductA
    {
        public void MethodX()
        {
            Console.WriteLine($"{nameof(ProductA2)} Method X is executed");
        }

        public void MethodY()
        {
            Console.WriteLine($"{nameof(ProductA2)} Method X is executed");
        }
    }
}
