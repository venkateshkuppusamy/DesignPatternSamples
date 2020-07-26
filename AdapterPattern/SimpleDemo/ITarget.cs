using System.Collections.Generic;

namespace AdapterPattern.SimpleDemo
{
    interface ITarget
    {
        void Operation1(string str);
        void Operation2(KeyValuePair<string,string> user);
    }
}
