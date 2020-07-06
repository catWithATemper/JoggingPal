using System;

namespace JoggingPal.Models.Events
{
    // extend Event
    public class VirtualEvent : Event
    {
        public double RouteLength { get; }

        public VirtualEvent(string dateTimeString, double avgSpeed, string title, double length)
        : base(dateTimeString, avgSpeed, title)
        {
            RouteLength = length;
        }

        public VirtualEvent(DateTime dateTime, double avgSpeed, string title, double length)
        : base(dateTime, avgSpeed, title)
        {
            RouteLength = length;
        }

        public override string ToString()
        {
            return base.ToString() + " Routelength: " + RouteLength + " km";
        }
    }
}
