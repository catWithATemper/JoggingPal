using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class InPersonEvent : Event
    
    {
        public Location runningLocation;

        public InPersonEvent(string dateTimeString, double avgSpeed, Location location) 
            : base(dateTimeString, avgSpeed)
        {
            runningLocation = location;
        }

        public override String ToString()
        {
            return (base.ToString() + " Location: " + runningLocation);
        }
    }
}
