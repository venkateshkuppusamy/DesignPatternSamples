using System;
using System.Diagnostics;

namespace Decorator.Intercept_Decorator
{
    internal class StopWatchClientDecorator : IApiClient
    {
        private readonly IApiClient apiClient;
        Stopwatch sw;

        public StopWatchClientDecorator(IApiClient apiClient)
        {
            this.apiClient = apiClient;
            sw = new Stopwatch();
        }

        public string GetPage()
        {
            Console.WriteLine("Initalizing stopwatch...");
            sw.Start();
            var page = this.apiClient.GetPage();
            sw.Stop();
            Console.WriteLine("Stopwatch complete" + nameof(GetPage) + " " + sw.ElapsedMilliseconds);
            return page;
        }

        public int GetPageIndex()
        {
            return apiClient.GetPageIndex();
        }
    }
}