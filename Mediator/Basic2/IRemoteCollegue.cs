namespace Mediator.Basic2
{
    public interface IRemoteCollegue
    {
        void SetMediator(AbstractMediator mediator);
        void Method1(string msg);
        void Method2();
    }
}
