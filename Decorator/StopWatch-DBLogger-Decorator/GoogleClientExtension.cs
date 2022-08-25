using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.StopWatch_DBLogger_Decorator
{
    static class GoogleClientExtension
    {
        public static string GetPageWithDBLog(this GoogleClient googleClient)
        {
            var page = googleClient.GetPage();
            Console.WriteLine($"Log page {page} to db using extension method {nameof(GoogleClientExtension.GetPageWithDBLog)}");
            return page;
        }
    }
}
