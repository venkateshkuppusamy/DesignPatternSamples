using Mediator.Basic;
using Mediator.CabRide;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RiderApp();
            //UseBasicMediator();
        }

        static void UseBasicMediator()
        {
            AbstractCollegue c1 = new Collegue("Venki");
            AbstractCollegue c2 = new Collegue("Anandraj");
            AbstractCollegue c3 = new Collegue("Sadish");
            AbstractCollegue c4 = new Collegue("KP");
            
            AbstractMediator mediator = new Mediator.Basic.Mediator2(new AbstractCollegue[]{c1, c2,c3,c4});

            c1.SendMessage("Hi guys... ");
            c2.SendMessage("Good morning ");
            c3.SendMessage("Where is KP ");
            c4.SendMessage("I am here nilu... ");
            Console.ReadLine();
        }

        static void RiderApp()
        {
            OLARideControl rideControl = new OLARideControl();
            
            AbstractDriver driver1 = new Driver() { Name = "arun", ContactNo = "124343", CurrentLocation = "Veachery 100 ft road", VehicleNo = "2345" };
            driver1.SetRideControl(rideControl);
            driver1.OpenCab();

            AbstractDriver driver2 = new Driver() { Name = "mahi", ContactNo = "988764", CurrentLocation = "Phoneix Mall", VehicleNo = "0987" };
            driver2.SetRideControl(rideControl);
            driver2.OpenCab();

            AbstractDriver driver3 = new Driver() { Name = "aru", ContactNo = "124343", CurrentLocation = "Dhandeeshwarm", VehicleNo = "8731" };
            driver3.SetRideControl(rideControl);
            driver3.OpenCab();

            AbstractRider rider1 = new Rider() { Name = "venki", ContactNo = "98887237", Location = "Velachery Gangai Nagar" };
            rider1.SetRideControl(rideControl);

            AbstractRider rider2 = new Rider() { Name = "karrupu", ContactNo = "988002237", Location = "Velachery Vijay Nagar" };
            rider2.SetRideControl(rideControl);

            // rider1 books and then cancels
            var drivers = rider1.SearchRide();
            Console.WriteLine("Driver details");
            foreach (var item in drivers)
            {
                Console.WriteLine($"{item.Item1},{item.Item2},{item.Item3}");
            }
            Console.WriteLine($"{rider1.GetRiderDetail().Item1}, pick the driver for ride");
            string driverName = Console.ReadLine();
            rider1.ConfirmRide(driverName);
            Thread.Sleep(5000);
            Console.WriteLine("Waited for 5 sec and cancelling the ride");
            rider1.CancelRide(driverName);

            // rider2 books and driver cancels
            drivers = rider2.SearchRide();
            Console.WriteLine("Driver details");
            foreach (var item in drivers)
            {
                Console.WriteLine($"{item.Item1},{item.Item2},{item.Item3}");
            }
            Console.WriteLine($"{rider2.GetRiderDetail().Item1}, pick the driver for ride");
            driverName = Console.ReadLine();
            rider2.ConfirmRide(driverName);

            Thread.Sleep(10000);
            Console.WriteLine("Waited for 10 sec and cancelling the ride");

            var driver = new List<AbstractDriver>() { driver1, driver2, driver3 }.Where(w=> w.GetDriverDetail().Item1 == driverName).FirstOrDefault();
            driver.CancelRide(driver.GetDriverDetail().Item1);



            Console.ReadLine();
        }
    }
}
