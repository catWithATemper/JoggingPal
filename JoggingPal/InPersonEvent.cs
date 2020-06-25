using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class InPersonEvent : Event
    
    {
        public Location RunningLocation { get; }

        public InPersonEvent(string dateTimeString, double avgSpeed, string title, Location location)
        : base(dateTimeString, avgSpeed, title)
        {
            RunningLocation = location;
        }

        public InPersonEvent(DateTime dateTime, double avgSpeed, string title, Location location)
        : base(dateTime, avgSpeed, title)
        {
            RunningLocation = location;
        }

        public override String ToString()
        {
            return (base.ToString() + " Location: " + RunningLocation.RouteName);
        }
    }
}
