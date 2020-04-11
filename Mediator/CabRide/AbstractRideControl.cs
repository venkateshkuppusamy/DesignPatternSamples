using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Mediator.CabRide
{
    abstract class AbstractRideControl
    {
        protected List<AbstractDriver> availableDrivers { get; set; } = new List<AbstractDriver>();
        protected List<AbstractRider> riders { get; set; } = new List<AbstractRider>();

        protected Dictionary<AbstractDriver, AbstractRider> confirmedRides { get; set; } = new Dictionary<AbstractDriver, AbstractRider>();

        public void RegisterDriver(AbstractDriver driver)
        {
            Console.WriteLine($"Driver registering {driver.GetDriverDetail().Item1}");
            Thread.Sleep(1000);
            availableDrivers.Add(driver);
        }

        public void RegisterRider(AbstractRider rider)
        {
            Console.WriteLine($"Rider registering {rider.GetRiderDetail().Item1}");
            Thread.Sleep(1000);
            riders.Add(rider);
        }

        public void DeregisterDriver(AbstractDriver driver)
        {
            availableDrivers.Remove(driver);
        }

        public void DeregisterRider(AbstractRider rider)
        {
            riders.Remove(rider);
        }

        public List<(string, string, string)> GetDrivers()
        {
            Console.WriteLine("Getting drivers list...");
            return availableDrivers.Select(s => s.GetDriverDetail()).ToList();

        }

        public (string, string) ConfirmDriver(string name, AbstractRider rider) {
            var driver = availableDrivers.Where(w => w.GetDriverDetail().Item1 == name).FirstOrDefault();
            confirmedRides.Add(driver, rider);
            availableDrivers.Remove(driver);
             (string rName, string contact, string location) = rider.GetRiderDetail();
            driver.NotifyPickup($"Picke up the rider at {rName},{contact} at {location} ");
            return (driver.GetDriverDetail().Item2, driver.GetDriverDetail().Item2);
        }

        public void CancelRide(string driverName)
        {
            var driver = confirmedRides.Where(w => w.Key.GetDriverDetail().Item1 == driverName).FirstOrDefault().Key;
            var rider = confirmedRides[driver];
            this.confirmedRides.Remove(driver);
            this.availableDrivers.Add(driver);
            this.riders.Add(rider);
            rider.ReceiveNotification("Your ride is been cancelled");
            driver.ReceiveNotification("Your ride is been cancelled");
        }
    }

    class OLARideControl : AbstractRideControl
    { 
    }
}
