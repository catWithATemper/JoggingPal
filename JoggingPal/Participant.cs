using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class Participant
    {
        User eventParticipant;
        Event joggingEvent;
        Location joggingLocation;
        bool isSignedUp;
        //Results results;

        public Participant(User user, Event selectedEvent)
        {
            eventParticipant = user;
            joggingEvent = selectedEvent;

            joggingEvent.participants.Add(this);

            if (typeof(InPersonEvent).IsInstanceOfType(joggingEvent)) 
                joggingLocation = ((InPersonEvent)joggingEvent).runningLocation;

        }

        public void SetRunningLocation(Location location)
        {
            joggingLocation = location;
        }

        public static void CheckInAtEvent()
        { }

        public override String ToString()
        {
            return (eventParticipant.userName + " has signed up for " + joggingEvent.ToString()
                + joggingLocation.ToString());
        }
    }
}
