using System;

namespace BridgePattern.BasicDemo
{
    internal class ConcreteAbstractor : Abstractor
    {
        public ConcreteAbstractor(IImplementor implementor) : base(implementor)
        {

        }

        public override string Method1()
        {
            Console.WriteLine(_implementor.Get1());
            return $"{nameof(ConcreteAbstractor)}  {nameof(Method1)}";
        }

        public override void Method2()
        {
            
            Console.WriteLine($"{nameof(ConcreteAbstractor)}   {nameof(Method2)}");
            Console.WriteLine(_implementor.Get2());
        }
    }
}
