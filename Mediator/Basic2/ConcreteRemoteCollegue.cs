using System;

namespace Mediator.Basic2
{
    public class ConcreteRemoteCollegue : IRemoteCollegue
    {
        private AbstractMediator _mediator;
        public ConcreteRemoteCollegue()
        {
            
        }

       
        public void Method1(string msg)
        {
            Console.WriteLine($"Method1: Received message {msg}");

           
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
            _mediator.MessageLocalCollegue(Console.ReadLine());
        }

        public void SetMediator(AbstractMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
