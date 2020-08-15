namespace IteratorPattern.BasicDemo
{
    class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int index = 0;
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
            
        }

        public int Current()
        {
            if (index == 0)
                return _concreteAggregate.numberx;
            else if (index == 1)
                return _concreteAggregate.numbery;
            else if (index == 2)
                return _concreteAggregate.number1;
            else if (index == 3)
                return _concreteAggregate.number2;
            else
                return -1;

        }

        public bool HasNext()
        {
            return index < 4;
        }

        public void Next()
        {
            index++;
        }
    }
}
