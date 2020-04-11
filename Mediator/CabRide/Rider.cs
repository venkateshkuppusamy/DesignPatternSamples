using System.Collections.Generic;

namespace Mediator.CabRide
{
    class Rider : AbstractRider
    {
        public string Name { get; set; }
        public string  ContactNo { get; set; }
        public string  Location { get; set; }

        public override void CancelRide(string driverName)
        {
            rideControl.CancelRide(driverName);
        }

        public override (string,string) ConfirmRide(string name)
        {
            return rideControl.ConfirmDriver(name,this);
        }

        public override (string, string, string) GetRiderDetail() {
            return (Name, ContactNo, Location);
        }

        public override List<(string, string, string)> SearchRide()
        {
            rideControl.RegisterRider(this);
            return rideControl.GetDrivers();            
        }

    }
}
