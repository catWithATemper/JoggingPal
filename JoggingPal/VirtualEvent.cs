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
        double routeLength;
        double elevationDiff;

        public VirtualEvent(string dateTimeString, double avgSpeed, double length)
        : base(dateTimeString, avgSpeed)
        {
            routeLength = length;
        }

        public VirtualEvent(DateTime dateTime, double avgSpeed, double length)
        : base(dateTime, avgSpeed)
        {
            routeLength = length;
        }

        public override String ToString()
        {
            return (base.ToString() + " Routelength: " + routeLength + " km");
        }
    }
}
