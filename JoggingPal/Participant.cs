using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class Participant
    {
        User eventParticipant;
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

        public EventResults UploadEventResults()
        {
            var director = new EventResultsDirector();
            var builder = new EventResultsConcreteBuilder();
            director.Builder = builder;

            director.BuildSimpleResults(20.0);

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
