using JoggingPal.Models.Participants;
using System;

namespace JoggingPal.Models.ParticipantStates
{
    class LocationSet : IParticipantState
    {
        private static readonly LocationSet instance = new LocationSet();
        private LocationSet() { }

        public static LocationSet Instance { get => instance; }

        public void CheckInAtEvent(ParticipationContext ctx)
        {
            ctx.CurrentState = CheckedIn.Instance;
        }

        public void SetLocation(ParticipationContext ctx)
        {
            ctx.CurrentState = Instance;
        }

        public void UploadEventResults(ParticipationContext ctx) => throw new InvalidOperationException();

        public override string ToString()
        {
            return "Location set";
        }
    }
}
