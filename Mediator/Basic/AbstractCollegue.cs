namespace Mediator.Basic
{
    public abstract class AbstractCollegue
    {
        AbstractMediator mediator { get; set; }
        public string Name { get; set; }
        public void SetMediator(AbstractMediator mediator) {
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }

        public abstract void ReceiveNotification(string message);

    }
}
