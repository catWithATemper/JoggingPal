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
        public User eventParticipant;
        Event joggingEvent;
        Location joggingLocation;
        public ParticipationContext ctx;
        bool isSignedUp;
        EventResults eventResults;

        public Participant(User user, Event selectedEvent)
        {
            eventParticipant = user;
            joggingEvent = selectedEvent;

            joggingEvent.participants.Add(this);

            ctx = new ParticipationContext(this);

            if (typeof(InPersonEvent).IsInstanceOfType(joggingEvent))
            {
                joggingLocation = ((InPersonEvent)joggingEvent).runningLocation;
                ctx.SetLocation();
            }
        }

        public void SetRunningLocation(Location location)
        {
            joggingLocation = location;
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

            eventResults = builder.GetResults();

            ctx.UploadEventResults();

            return eventResults;
        }

        public override String ToString()
        {
            return (eventParticipant.userName + " has signed up for " + joggingEvent.ToString()
                + joggingLocation.ToString());
        }
    }
}
