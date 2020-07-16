using JoggingPal.Models.Events;
using JoggingPal.Models.Locations;
using JoggingPal.Models.Results;
using JoggingPal.Models.Users;
using System;

namespace JoggingPal.Models.Participants
{
    public class Participant
    {
        public User EventParticipant { get; }
        public Event RunningEvent { get; }
        public Location RunningLocation { get; set; }

        public ParticipationContext Ctx { get; }
        public EventResults EventResults { get; set; }

        public Participant(User user, Event selectedEvent)
        {
            EventParticipant = user;
            RunningEvent = selectedEvent;

            RunningEvent.Participants.Add(this);

            Ctx = new ParticipationContext(this);

            if (typeof(InPersonEvent).IsInstanceOfType(RunningEvent))
            {
                RunningLocation = ((InPersonEvent)RunningEvent).RunningLocation;
                Ctx.SetLocation();
            }
        }

        public void SetRunningLocation(Location location)
        {
            RunningLocation = location;
            Ctx.SetLocation();
        }

        public void CheckInAtEvent()
        {
            Ctx.CheckInAtEvent();
        }

        public EventResults UploadEventResults(TimeSpan totalTime, double? maxSpeed, int? avgHeartRate)
        {
            EventResultsDirector director = new EventResultsDirector();
            EventResultsConcreteBuilder builder = new EventResultsConcreteBuilder();
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

            Ctx.UploadEventResults();

            return EventResults;
        }

        public override string ToString()
        {
            return EventParticipant.UserName + " has signed up for " + RunningEvent.ToString()
                + RunningLocation.ToString();
        }
    }
}
