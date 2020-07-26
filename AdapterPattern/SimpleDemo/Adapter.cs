using System;
using System.Collections.Generic;

namespace AdapterPattern.SimpleDemo
{
    class Adapter : ITarget
    {
        private readonly Adaptee _existingClass;
        public Adapter(Adaptee existingClass)
        {
            _existingClass = existingClass;
        }

        void ITarget.Operation1(string str)
        {
            Console.WriteLine($"Do the operation for string {str}");
        }

        void ITarget.Operation2(KeyValuePair<string, string> user)
        {
            Console.WriteLine("redirecting to adaptee class");
            _existingClass.Action1(user.Key, user.Value);
        }
    }
}
