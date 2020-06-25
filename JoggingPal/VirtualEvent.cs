using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
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

        public override String ToString()
        {
            return (base.ToString() + " Routelength: " + RouteLength + " km");
        }
    }
}
