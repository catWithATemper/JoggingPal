using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class Participant
    {
        public User EventParticipant { get; }
        public Event JoggingEvent { get; }
        public Location JoggingLocation { get; set; }

        public ParticipationContext ctx;
        public EventResults EventResults { get; set; }

        public Participant(User user, Event selectedEvent)
        {
            EventParticipant = user;
            JoggingEvent = selectedEvent;

            JoggingEvent.Participants.Add(this);

            ctx = new ParticipationContext(this);

            if (typeof(InPersonEvent).IsInstanceOfType(JoggingEvent))
            {
                JoggingLocation = ((InPersonEvent)JoggingEvent).RunningLocation;
                ctx.SetLocation();
            }
        }

        public void SetRunningLocation(Location location)
        {
            JoggingLocation = location;
            ctx.SetLocation();
        }

        public void CheckInAtEvent()
        {
            ctx.CheckInAtEvent();        
        }

        public EventResults UploadEventResults(double? totalTime, double? maxSpeed, int? avgHeartRate)
        {
            var director = new EventResultsDirector();
            var builder = new EventResultsConcreteBuilder();
            director.Builder = builder;

            if (totalTime != null && maxSpeed != null && avgHeartRate != null)
                director.BuildDetailedResults(totalTime.Value, maxSpeed.Value, avgHeartRate.Value);
            else if (totalTime != null && maxSpeed != null && avgHeartRate == null)
                director.BuildResultsWithMaxSpeed(totalTime.Value, maxSpeed.Value);
            else if (totalTime != null && maxSpeed == null && avgHeartRate != null)
                director.BuildResultsWithHeartRate(totalTime.Value, avgHeartRate.Value);
            else if ((totalTime != null && maxSpeed == null && avgHeartRate == null))
                director.BuildSimpleResults(totalTime.Value);
            else
                throw new InvalidOperationException();

            EventResults = builder.GetResults();

            ctx.UploadEventResults();

            return EventResults;
        }


        public EventResults GetEventResults()
        {
            return this.EventResults;
        }

        public override String ToString()
        {
            return (EventParticipant.UserName + " has signed up for " + JoggingEvent.ToString()
                + JoggingLocation.ToString());
        }
    }
}
