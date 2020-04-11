using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.CabRide
{
    abstract class AbstractRider
    {
        protected AbstractRideControl rideControl { get; set; }
        public abstract List<(string, string, string)> SearchRide();
        public abstract (string, string) ConfirmRide(string name);
        public abstract (string, string,string) GetRiderDetail();
        public  void SetRideControl(AbstractRideControl rideControl)
        {
            this.rideControl = rideControl;
           
        }

          public abstract void CancelRide(string driverName);
          public string ReceiveNotification(string message) => message;
       
    }
}
