using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.StopWatch_DBLogger_Decorator
{
    internal class Startup
    {

        public static void Run()
        {
            //Stopwatch decorator to measure the time taken the fetch data from GetPage method.
            //IApiClient apiClient = new GoogleClient();
            //var page = apiClient.GetPage();
            //Console.WriteLine(page);
            //IApiClient apiClientStopwatchDecorator = new StopWatchClientDecorator(apiClient);
            //page = apiClientStopwatchDecorator.GetPage();
            //Console.WriteLine(page);

            //DBLog decorator to Log results from GetPage method to database.
            //IApiClient apiClient = new GoogleClient();
            //var page = apiClient.GetPage();
            //Console.WriteLine(page);
            //IApiClient apiClient = new DbLogDecorator(new GoogleClient());
            //var page = apiClient.GetPage();
            //Console.WriteLine(page);

            //Log results from GetPage method via new extension method. does not work the IApiClient interface.
            //GoogleClient googleClient = new GoogleClient();
            //var page = googleClient.GetPageWithDBLog();
            //Console.WriteLine(page);


            //Log results from GetPage method via function passing. additional changes in client code.
            //IApiClient apiClient = new GoogleClient();
            //var page = WithDBLog(apiClient.GetPage);
            //Console.WriteLine(page);



        }
        /// <summary>
        /// Logs function result to db via funtion passing.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string WithDBLog(Func<string> func)
        {
            var page = func.Invoke();
            Console.WriteLine($"Log page {page} to db with function passing");
            return page;
        }
    }
}
