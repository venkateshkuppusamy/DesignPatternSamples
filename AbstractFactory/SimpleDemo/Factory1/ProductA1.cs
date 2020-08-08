using AbstractFactory.SimpleDemo.Interfaces;
using System;

namespace AbstractFactory.SimpleDemo.Factory1
{
    internal class ProductA1 : IProductA
    {
        public void MethodX()
        {
            Console.WriteLine($"{nameof(ProductA1)} Method X is executed");
        }

        public void MethodY()
        {
            Console.WriteLine($"{nameof(ProductA1)} Method Y is executed");
        }
    }
}
