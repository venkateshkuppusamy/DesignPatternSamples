using AbstractFactory.SimpleDemo.Interfaces;

namespace AbstractFactory.SimpleDemo.Factory1
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA GetProductA()
        {
            return new ProductA1();
        }

        public IProductB GetProductB()
        {
            return new ProductB1();
        }
    }
}
