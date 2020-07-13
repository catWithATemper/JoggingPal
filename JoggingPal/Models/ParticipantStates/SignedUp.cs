using JoggingPal.Models.Participants;
using System;

namespace JoggingPal.Models.ParticipantStates
{
    class SignedUp : IParticipantState
    {
        private static readonly SignedUp instance = new SignedUp();
        private SignedUp() { }

        public static SignedUp Instance { get => instance; }

        public void SetLocation(ParticipationContext ctx)
        {
            ctx.CurrentState = LocationSet.Instance;
        }

        public void CheckInAtEvent(ParticipationContext ctx) => throw new InvalidCastException();

        public void UploadEventResults(ParticipationContext ctx) => throw new InvalidCastException();

        public override string ToString()
        {
            return "Signed up";
        }
    }
}
