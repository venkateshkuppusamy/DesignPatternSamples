namespace Mediator.Basic2
{
    public interface ILocalCollegue
    {
        void SetMediator(AbstractMediator mediator);
        void Operation1();
        void Operation2(string msg);
    }
}
