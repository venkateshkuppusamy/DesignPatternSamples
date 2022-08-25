using System;
using System.Threading.Tasks;

namespace Decorator.StopWatch_DBLogger_Decorator
{
    internal class GoogleClient : IApiClient
    {
        public string GetPage()
        {
            Console.WriteLine("Fetching Google Page...");
            Task.Delay(1000).Wait();
            return "Google Page";
        }

        public int GetPageIndex()
        {
            return new Random().Next(1, 10);
        }
    }
}