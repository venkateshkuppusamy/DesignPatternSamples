using System;

namespace Mediator.CabRide
{
    class Driver : AbstractDriver
    {
        public string Name { get; set; }
        public string VehicleNo { get; set; }
        public string ContactNo { get; set; }

        public string CurrentLocation { get; set; }

        public override void OpenCab()
        {
            rideControl.RegisterDriver(this);
        }

        public override void CloseCab()
        {
            rideControl.RegisterDriver(this);
        }

        public override (string, string, string) GetDriverDetail()
        {
            return (this.Name, this.ContactNo, this.CurrentLocation);
        }

        public override void NotifyPickup(string message)
        {
            Console.WriteLine(message);
        }

        public override void CancelRide(String driverName)
        {
            this.rideControl.CancelRide(driverName);
        }
    }
    
}
