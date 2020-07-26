using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.ObjectAdapter
{
    class LocationManager
    {
        List<Location> _locations = new List<Location>();

        public LocationManager()
        {
            _locations.Add(new Location() { ID = 1, LocationCode = new LocationCode(2345, 0), name = "Velachery", OnlineStatus = "Online",IsDDD = true });
            _locations.Add(new Location() { ID = 2, LocationCode = new LocationCode(2245, 1), name = "Adyar", OnlineStatus = "Online" });
            _locations.Add(new Location() { ID = 3, LocationCode = new LocationCode(11545, 0), name = "Pallinarnai", OnlineStatus = "Offline" });
        }

        public Location GetLocationDetails(LocationCode locationCode)
        {
            return _locations.Where(s => s.LocationCode.Code == locationCode.Code && 
                    s.LocationCode.SatelliteNumber == locationCode.SatelliteNumber).FirstOrDefault();
        }
    }

    class Location
    {
        public LocationCode LocationCode { get; set; }
        public int ID { get; set; }
        public string name { get; set; }
        public string OnlineStatus { get; set; }
        public bool IsDDD { get; set; }
    }

    class LocationCode
    {
        public LocationCode(int code, int satelliteNumber)
        {
            this.Code = code;
            this.SatelliteNumber = satelliteNumber;
        }
        public int Code { get; set; }
        public int SatelliteNumber { get; set; }

        static LocationCode Create(int code,int satelliteNumber)
        {
            return new LocationCode(code, satelliteNumber);
        }
        
    }
}
