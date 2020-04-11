using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.CabRide
{
    abstract class AbstractDriver
    {
        protected AbstractRideControl rideControl { get; set; }
        public abstract void OpenCab();
        public abstract void CloseCab();
        public abstract (string, string, string) GetDriverDetail();

        public abstract void NotifyPickup(string message);

        public void SetRideControl(AbstractRideControl rideControl)
        {
            this.rideControl = rideControl;
            
        }
        public abstract void CancelRide(string driverName);

        public string ReceiveNotification(string message) => message;
    }

}
