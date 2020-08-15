using IteratorPattern.BasicDemo;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractAggregate aggregate = new ConcreteAggregate(4, 5, 10, 2);

            var iterator = aggregate.GetIterator();
            while (iterator.HasNext())
            {
               Console.WriteLine(iterator.Current());
                iterator.Next();
            }
            Console.ReadLine();
        }
    }
}
