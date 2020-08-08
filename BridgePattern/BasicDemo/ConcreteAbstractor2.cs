using System;

namespace BridgePattern.BasicDemo
{
    internal class ConcreteAbstractor2 : Abstractor
    {
        public ConcreteAbstractor2(IImplementor implementor) : base(implementor)
        {
        }

        public override string Method1()
        {
            return $"{nameof(ConcreteAbstractor2)}  {nameof(Method1)} {_implementor.Get1()}";
        }

        public override void Method2()
        {
            Console.WriteLine($"{nameof(ConcreteAbstractor2)}   {nameof(Method2)}");
            Console.WriteLine(_implementor.Get2());
        }
    }
}
