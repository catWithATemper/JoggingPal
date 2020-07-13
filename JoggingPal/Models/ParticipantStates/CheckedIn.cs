using JoggingPal.Models.Participants;
using System;

namespace JoggingPal.Models.ParticipantStates
{
    class CheckedIn : IParticipantState
    {
        private static readonly CheckedIn instance = new CheckedIn();
        private CheckedIn() { }

        public static CheckedIn Instance { get => instance; }

        public void UploadEventResults(ParticipationContext ctx)
        {
            ctx.CurrentState = EventResultsUploaded.Instance;
        }

        public void CheckInAtEvent(ParticipationContext ctx)
        {
            ctx.CurrentState = Instance;
        }

        public void SetLocation(ParticipationContext ctx) => throw new InvalidOperationException();

        public override string ToString()
        {
            return "Checked in";
        }
    }
}
