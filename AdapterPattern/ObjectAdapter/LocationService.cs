using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.ObjectAdapter
{
    class LocationService : ILocationService
    {
        private readonly LocationManager _locationManager;

        public LocationService(LocationManager locationManager)
        {
            _locationManager = locationManager;
        }

        public string GetLocationStatus(string locationCode)
        {
            var locDetails = locationCode.Split("-").Select(s=> Convert.ToInt32(s)).ToArray();
            LocationCode locationCd = new LocationCode(locDetails[0], locDetails[1]);
            return _locationManager.GetLocationDetails(locationCd).OnlineStatus;
        }

        public bool IsDDDLocation(string locationCode)
        {
            var locDetails = locationCode.Split("-").Select(s => Convert.ToInt32(s)).ToArray();
            LocationCode locationCd = new LocationCode(locDetails[0], locDetails[1]);
            return _locationManager.GetLocationDetails(locationCd).IsDDD;
        }
    }
}
