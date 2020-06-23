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
        public DateTime DateTime { get; }

        double AverageSpeed { get; }

        public IList<Participant> Participants { get; }

        public Event(string dateTimeString, double avgSpeed) :this (
            DateTime.Parse(dateTimeString, System.Globalization.CultureInfo.CurrentCulture), 
            avgSpeed)
        {

        }

        public Event(DateTime dateTime, double avgSpeed)
        {
            AverageSpeed = avgSpeed;
            this.DateTime = dateTime;
            Participants = new List<Participant>();
        }

        public Participant FindParticipant(User user)
        {
            for (int i = 0; i < Participants.Count; i++)
            {
                if (user.UserName == Participants[i].EventParticipant.UserName)
                    return Participants[i];
            }
            return null;
        }


        public override String ToString()
        {
            return " at " + DateTime.ToString() + " average speed: " + AverageSpeed + " km/h";
        }
    }
}
