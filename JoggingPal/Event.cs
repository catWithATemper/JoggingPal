using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    abstract class Event

    {
        DateTime dateTime;

        double averageSpeed;

        public IList<Participant> participants;

        public Event(string dateTimeString, double avgSpeed)
        {
            averageSpeed = avgSpeed;
            dateTime = DateTime.Parse(dateTimeString, System.Globalization.CultureInfo.InvariantCulture);
            participants = new List<Participant>();
        }

        public override String ToString()
        {
            return " at " + dateTime.ToString() + "\naverage speed: " + averageSpeed + " km/h";
        }
    }
}
