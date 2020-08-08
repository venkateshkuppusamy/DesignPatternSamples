namespace AbstractFactory.SimpleDemo.Interfaces
{
    internal interface IAbstractFactory
    {
        IProductA GetProductA();
        IProductB GetProductB();
    }
}
