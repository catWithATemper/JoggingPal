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

        public EventResults UploadEventResults(TimeSpan totalTime, double? maxSpeed, int? avgHeartRate)
        {
            var director = new EventResultsDirector();
            var builder = new EventResultsConcreteBuilder();
            director.Builder = builder;

            if (maxSpeed != null && avgHeartRate != null)
                director.BuildDetailedResults(totalTime, maxSpeed.Value, avgHeartRate.Value);
            else if (maxSpeed != null && avgHeartRate == null)
                director.BuildResultsWithMaxSpeed(totalTime, maxSpeed.Value);
            else if (maxSpeed == null && avgHeartRate != null)
                director.BuildResultsWithHeartRate(totalTime, avgHeartRate.Value);
            else if (maxSpeed == null && avgHeartRate == null)
                director.BuildSimpleResults(totalTime);
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
