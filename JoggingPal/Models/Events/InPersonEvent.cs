using JoggingPal.Models.Locations;
using System;

namespace JoggingPal.Models.Events
{
    public class InPersonEvent : Event
    {
        public Location RunningLocation { get; }

        public InPersonEvent(DateTime dateTime, double avgSpeed, string title, Location location)
        : base(dateTime, avgSpeed, title)
        {
            RunningLocation = location;
        }

        public override string ToString()
        {
            return base.ToString() + " Location: " + RunningLocation.RouteName;
        }
    }
}
