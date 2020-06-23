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
        double RouteLength { get; }

        public VirtualEvent(string dateTimeString, double avgSpeed, double length)
        : base(dateTimeString, avgSpeed)
        {
            RouteLength = length;
        }

        public VirtualEvent(DateTime dateTime, double avgSpeed, double length)
        : base(dateTime, avgSpeed)
        {
            RouteLength = length;
        }

        public override String ToString()
        {
            return (base.ToString() + " Routelength: " + RouteLength + " km");
        }
    }
}
