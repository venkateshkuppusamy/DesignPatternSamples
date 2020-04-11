using System;

namespace Mediator.Basic
{
    public class Collegue : AbstractCollegue
    {
        public Collegue(string name)
        {
            this.Name = name;
        }
        public override void ReceiveNotification(string message)
        {
            Console.WriteLine($"Notification to {this.Name}  {message}");
        }
    }
}
