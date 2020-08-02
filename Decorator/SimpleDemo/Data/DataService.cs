using System;



namespace Decorator.SimpleDemo.Data
{
    class DataService : IDataService
    {
        public string Get(int id)
        {
            return new Random().Next(0, id).ToString();
        }
    }
}