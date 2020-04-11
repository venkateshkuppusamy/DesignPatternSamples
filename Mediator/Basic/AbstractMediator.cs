using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Basic
{
    public abstract class AbstractMediator
    {
        protected List<AbstractCollegue> collegues;

        public virtual void SendMessage(string message, AbstractCollegue collegue)
        {
            Console.WriteLine("This message is sent via AbstractMediator");
            this.collegues.Where(w => w != collegue).ToList().ForEach(e => e.ReceiveNotification($"Message from {collegue.Name} {message}"));
        }

    }
}
