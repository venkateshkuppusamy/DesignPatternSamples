using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Basic
{
    class Mediator : AbstractMediator {

        public Mediator(IEnumerable<AbstractCollegue> collegues)
        {
            this.collegues = new List<AbstractCollegue>();
            this.collegues = collegues.ToList();
            this.collegues.ForEach(e => e.SetMediator(this));
        }

        public override void SendMessage(string message, AbstractCollegue collegue)
        {
            Console.WriteLine("This message is sent via Mediator");
            this.collegues.Where(w => w != collegue).ToList().ForEach(e => e.ReceiveNotification($"Message from {collegue.Name} {message}"));
        }
    }

    class Mediator2 : AbstractMediator
    {
        public Mediator2(IEnumerable<AbstractCollegue> collegues)
        {
            this.collegues = new List<AbstractCollegue>();
            this.collegues = collegues.ToList();
            this.collegues.ForEach(e => e.SetMediator(this));
        }

    }
}
