using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern.ClassAdapter
{
    class ClientService : ClientBusiness, IClientService
    {
        public void Add(Dictionary<string, string> clients)
        {
            this.AddClient(clients.Keys.ToList());
        }

        public bool IfExists(string name)
        {
            return this.GetClientCount(name) > 0;
        }
    }
}
