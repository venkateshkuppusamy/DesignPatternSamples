using Decorator.SimpleDemo.Component;
using Decorator.SimpleDemo.Data;
using Decorator.SimpleDemo.Decorator;
using SimpleDemo;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent componentX_WithNoDecorator = new ComponentX();
            componentX_WithNoDecorator.MethodA();

            IComponent componetX_WithDecoratorA = new DecoratorA(componentX_WithNoDecorator);
            componetX_WithDecoratorA.MethodA();

            IComponent componentX_WithDecoratorA_And_DecoratorB = new DecoratorB(componetX_WithDecoratorA, new DataService(), 4);

            Console.WriteLine(componentX_WithDecoratorA_And_DecoratorB.MethodB());
            Console.ReadLine();


        }
    }
}



