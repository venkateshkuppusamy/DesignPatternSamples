using SimpleDemo;
using System;



namespace Decorator.SimpleDemo.Decorator
{
    class DecoratorA : IComponent
    {
        private IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }

        public void MethodA()
        {
            _component.MethodA();
            Console.WriteLine("Decorator A feature");
        }

        public string MethodB()
        {
            return _component.MethodB() + "Decortor A data";
        }
    }
}