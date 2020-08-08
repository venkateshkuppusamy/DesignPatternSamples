namespace BridgePattern.BasicDemo
{
    class Implementor1 : IImplementor
    {
        public string Get1()
        {
            return $"{nameof(Implementor1)}     {nameof(Get1)}";
        }

        public string Get2()
        {
            return $"{nameof(Implementor1)}     {nameof(Get2)}";
        }
    }
}
