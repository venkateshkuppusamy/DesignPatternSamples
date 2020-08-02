using SimpleDemo;
using System;



namespace Decorator.SimpleDemo.Component
{
    class ComponentY : IComponent
    {
        public void MethodA()
        {
            Console.WriteLine("Component Y method executed");
        }

        public string MethodB()
        {
            return "Data from MethodB for Component Y";
        }
    }
}