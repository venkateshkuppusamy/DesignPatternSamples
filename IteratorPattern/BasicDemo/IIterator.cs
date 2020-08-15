namespace IteratorPattern.BasicDemo
{
    interface IIterator {
        bool HasNext();
        void Next();
        int Current();

    }
}
