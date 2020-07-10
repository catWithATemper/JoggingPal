using JoggingPal.Models.Participants;
using JoggingPal.Models.Users;
using System;
using System.Collections.Generic;

namespace JoggingPal.Models.Events
{
    public abstract class Event
    {
        public DateTime DateTime { get; }

        public double AverageSpeed { get; }

        public string EventTitle { get; }

        public IList<Participant> Participants { get; }

        public Event(DateTime dateTime, double avgSpeed, string title)
        {
            AverageSpeed = avgSpeed;
            DateTime = dateTime;
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

        public override string ToString()
        {
            return EventTitle + "Date and time: " + DateTime.ToString() + " average speed: " 
                + AverageSpeed + " km/h";
        }
    }
}
