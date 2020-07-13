using JoggingPal.Models.Participants;
using System;

namespace JoggingPal.Models.ParticipantStates
{
    class EventResultsUploaded : IParticipantState
    {
        private static readonly EventResultsUploaded instance = new EventResultsUploaded();
        private EventResultsUploaded() { }

        public static EventResultsUploaded Instance { get => instance; }

        public void UploadEventResults(ParticipationContext ctx)
        {
            ctx.CurrentState = Instance;
        }

        public void CheckInAtEvent(ParticipationContext ctx) => throw new InvalidOperationException();

        public void SetLocation(ParticipationContext ctx) => throw new InvalidOperationException();

        public override string ToString()
        {
            return "Results uploaded";
        }
    }
}
