using System;

namespace Mediator.Basic2
{
    public class ConcreteMediator : AbstractMediator
    {
        public ConcreteMediator(ILocalCollegue localCollegue, IRemoteCollegue remoteCollegue)
        {
            this.LocalCollegue = localCollegue;
            this.LocalCollegue.SetMediator(this);
            this.RemoteCollegue = remoteCollegue;
            this.RemoteCollegue.SetMediator(this);
        }

        public override void MessageLocalCollegue(string msg)
        {
            Console.WriteLine($"Sending message to local: {msg}");
            LocalCollegue.Operation2(msg);
        }

        public override void MessageRemoteCollegeue(string msg)
        {
            Console.WriteLine($"Sending message to remote: {msg}");
            RemoteCollegue.Method1(msg);
        }
    }
}
