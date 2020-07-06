using System.Device.Location;

namespace JoggingPal.Models.Locations
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

        public override string ToString()
        {
            return RouteName + ", " + StartingPoint.ToString() + ", " + RouteLength + " km";
        }
    }
}
