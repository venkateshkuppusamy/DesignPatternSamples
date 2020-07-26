using System.Collections.Generic;

namespace AdapterPattern.ClassAdapter
{
    class ClientBusiness
    {
        List<string> _clients { get; set; } = new List<string>();
        public int count { get; set; }
        public int GetClientCount(string name)
        {
            return count;
        }

        public void AddClient(List<string> clients)
        {
            this._clients.AddRange(clients);
        }
    }
}
