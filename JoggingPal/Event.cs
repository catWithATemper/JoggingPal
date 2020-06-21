using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public abstract class Event

    {
       public DateTime dateTime;

        double averageSpeed;

        public IList<Participant> participants;

        //Todo: chiamare l'altro costruttore da quello vecchio
        public Event(string dateTimeString, double avgSpeed)
        {
            averageSpeed = avgSpeed;
            dateTime = DateTime.Parse(dateTimeString, System.Globalization.CultureInfo.CurrentCulture);
            participants = new List<Participant>();
        }

        public Event(DateTime dateTime, double avgSpeed)
        {
            averageSpeed = avgSpeed;
            this.dateTime = dateTime;
            participants = new List<Participant>();
        }

        public Participant FindParticipant(User user)
        {
            for (int i = 0; i < participants.Count; i++)
            {
                if (user.userName == participants[i].eventParticipant.userName)
                    return participants[i];
            }
            return null;
        }


        public override String ToString()
        {
            return " at " + dateTime.ToString() + " average speed: " + averageSpeed + " km/h";
        }
    }
}
