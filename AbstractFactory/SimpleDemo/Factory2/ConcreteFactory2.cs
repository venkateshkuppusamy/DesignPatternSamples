using AbstractFactory.SimpleDemo.Interfaces;

namespace AbstractFactory.SimpleDemo.Factory2
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA GetProductA()
        {
            return new ProductA2();
        }

        public IProductB GetProductB()
        {
            return new ProductB2();
        }
    }
}
