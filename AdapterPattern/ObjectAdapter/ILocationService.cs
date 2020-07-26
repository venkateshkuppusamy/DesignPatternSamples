using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ObjectAdapter
{
    interface ILocationService
    {
        string GetLocationStatus(string locationCode);

        bool IsDDDLocation(string locationCode);
    }
}
