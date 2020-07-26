using AdapterPattern.ClassAdapter;
using AdapterPattern.ObjectAdapter;
using AdapterPattern.SimpleDemo;
using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITarget target = new Adapter(new Adaptee());
            //target.Operation1("string1");
            //target.Operation2(new KeyValuePair<string, string>("userid", "uservalue"));
            //Console.ReadLine();

            //IClientService clientService = new ClientService();
            //Dictionary<string, string> clients = new Dictionary<string, string>();
            //clients.Add("venki", "venki");
            //clients.Add("mohana", "mohana");
            //clients.Add("sowjanya", "sowjanya");

            //clientService.Add(clients);
            //clientService.IfExists("anitha");

            ILocationService locationService = new LocationService(new LocationManager());

            locationService.GetLocationStatus("2345-0");
            locationService.IsDDDLocation("2345-0");

            Console.Read();

        }
    }
}
