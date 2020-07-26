using System;
using System.Collections.Generic;

namespace AdapterPattern.SimpleDemo
{
    class Adaptee
    {
        public void Action1(string key, string value)
        {
            Console.WriteLine($"Do the operation for {key} and {value}");
        }
        public void Action2(List<string> values)
        {
            Console.WriteLine($"Do the operation for {values}");
        }

    }
}
