using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace JoggingPal
{
    public class Location
    {
        public string RouteName { get; }
        public GeoCoordinate StartingPoint { get; }
        public double RouteLength { get; }

        public Location(string name, double lat, double lon, double length)
        {
            RouteName = name;
            StartingPoint = new GeoCoordinate(lat, lon);
            RouteLength = length;
        }

        public override String ToString()
        {
            return (RouteName + ", " + StartingPoint.ToString() + ", " + RouteLength + " km");
        }

    }
}
