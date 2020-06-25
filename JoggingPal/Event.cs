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

        public double AverageSpeed { get; }

        public string EventTitle { get; }

        public IList<Participant> Participants { get; }

        public Event(string dateTimeString, double avgSpeed, string title) :this (
            DateTime.Parse(dateTimeString, System.Globalization.CultureInfo.CurrentCulture), 
            avgSpeed, title)
        {

        }

        public Event(DateTime dateTime, double avgSpeed, string title)
        {
            AverageSpeed = avgSpeed;
            this.DateTime = dateTime;
            EventTitle = title;
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
