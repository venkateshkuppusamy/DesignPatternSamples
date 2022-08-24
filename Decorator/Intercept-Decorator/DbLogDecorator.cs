using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Intercept_Decorator
{
    internal class DbLogDecorator : IApiClient
    {
        private readonly IApiClient apiClient;

        public DbLogDecorator(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public string GetPage()
        {
            var page = this.apiClient.GetPage();
            Console.WriteLine($"Log page {page} to db via {nameof(DbLogDecorator)}");
            return page;
        }

        public int GetPageIndex()
        {
            return this.GetPageIndex();
        }
    }
}
