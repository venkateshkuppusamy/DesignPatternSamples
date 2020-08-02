using Decorator.SimpleDemo.Data;
using SimpleDemo;
using System;



namespace Decorator.SimpleDemo.Decorator
{
    class DecoratorB : IComponent
    {
        private IComponent _component;
        private IDataService _dataService;
        private int _id;

        public DecoratorB(IComponent component, IDataService dataService, int id)
        {
            _component = component;
            _dataService = dataService;
            _id = id;
        }

        public void MethodA()
        {
            _component.MethodA();
            Console.WriteLine("Decorator B feature");
        }

        public string MethodB()
        {
            return _component.MethodB() + "  " + _dataService.Get(_id);
        }
    }
}