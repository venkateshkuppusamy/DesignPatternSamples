using SimpleDemo;
using System;



namespace Decorator.SimpleDemo.Component
{
    class ComponentX : IComponent
    {
        public void MethodA()
        {
            Console.WriteLine("Component X method executed");
        }

        public string MethodB()
        {
            return "Data from MethodB for Component X";
        }

    }
}