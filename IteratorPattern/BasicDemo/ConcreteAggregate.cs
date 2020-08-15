using System;

namespace IteratorPattern.BasicDemo
{
    class ConcreteAggregate : AbstractAggregate
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int numberx { get; set; }
        public int numbery { get; set; }

        public ConcreteAggregate(int number1, int number2, int numberx, int numbery)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.numberx = numberx;
            this.numbery = numbery;
        }

        public override IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
        public void Operation2()
        {
            Console.WriteLine("Executed Operation 2");
        }
    }
}
