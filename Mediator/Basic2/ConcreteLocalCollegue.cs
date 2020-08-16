using System;

namespace Mediator.Basic2
{
    class ConcreteLocalCollegue : ILocalCollegue
    {
        private AbstractMediator _mediator;


        public ConcreteLocalCollegue()
        {
        }

        public void Operation1()
        {
            Console.WriteLine("Operation1");
            _mediator.MessageRemoteCollegeue(Console.ReadLine());
        }

        public void Operation2(string msg)
        {
            Console.WriteLine($"Operation2: {msg}");
        }

        public void SetMediator(AbstractMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
