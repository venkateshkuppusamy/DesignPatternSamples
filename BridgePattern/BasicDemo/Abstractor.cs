using System.Collections.Generic;
using System.Text;

namespace BridgePattern.BasicDemo
{
    abstract class Abstractor
    {
        protected IImplementor _implementor { get; set; }
        public Abstractor(IImplementor implementor)
        {
            _implementor = implementor;
        }
        public abstract string Method1();
        public abstract void Method2();
    }

    internal interface IImplementor
    {
        string Get1();
        string Get2();

    }
}
