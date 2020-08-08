﻿using AbstractFactory.SimpleDemo.Interfaces;
using System;

namespace AbstractFactory.SimpleDemo.Factory1
{
    internal class ProductB1 : IProductB
    {
        public void Method1()
        {
            Console.WriteLine($"{nameof(ProductB1)} Method 1 is executed");
        }

        public void Method2()
        {
            Console.WriteLine($"{nameof(ProductB1)} Method 2 is executed");
        }
    }
}
