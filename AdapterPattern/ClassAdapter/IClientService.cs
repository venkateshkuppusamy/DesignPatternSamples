using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ClassAdapter
{
    interface IClientService
    {
        bool IfExists(string name);
        void Add(Dictionary<string,string> clients);
    }
}
