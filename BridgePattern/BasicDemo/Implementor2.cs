namespace BridgePattern.BasicDemo
{
    class Implementor2 : IImplementor
    {
        public string Get1()
        {
            return $"{nameof(Implementor2)}     {nameof(Get1)}";
        }

        public string Get2()
        {
            return $"{nameof(Implementor2)}     {nameof(Get2)}";
        }
    }
}
