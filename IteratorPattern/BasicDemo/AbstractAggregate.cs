using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.BasicDemo
{
    abstract class AbstractAggregate
    {
        public abstract IIterator GetIterator();

        public void Operation1()
        {
            Console.WriteLine("Executed Operation1");
        }
    }
}
