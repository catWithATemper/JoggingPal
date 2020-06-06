using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace JoggingPal
{
    class Location
    {
        string routeName;
        GeoCoordinate startingPoint;
        double routeLength;
        double elevationDifference;

        public Location(string name, double lat, double lon, double length)
        {
            routeName = name;
            startingPoint = new GeoCoordinate(lat, lon);
            routeLength = length;
        }

        public override String ToString()
        {
            return (routeName + ", " + startingPoint.ToString() + ", " + routeLength + " km");
        }

    }
}
