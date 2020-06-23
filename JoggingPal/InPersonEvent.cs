using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class InPersonEvent : Event
    
    {
        public Location RunningLocation { get; }

        public InPersonEvent(string dateTimeString, double avgSpeed, Location location)
        : base(dateTimeString, avgSpeed)
        {
            RunningLocation = location;
        }

        public InPersonEvent(DateTime dateTime, double avgSpeed, Location location)
        : base(dateTime, avgSpeed)
        {
            RunningLocation = location;
        }

        public override String ToString()
        {
            return (base.ToString() + " Location: " + RunningLocation.RouteName);
        }
    }
}
