using JoggingPal.Models.ParticipantStates;

namespace JoggingPal.Models.Participants
{
    public class ParticipationContext
    {
        public ParticipationContext(Participant participant)
        {
            Participant = participant;
            CurrentState = SignedUp.Instance;
        }

        public Participant Participant { get; set; }

        public IParticipantState CurrentState { get; set; }

        public void SetLocation() => CurrentState.SetLocation(this);

        public void CheckInAtEvent() => CurrentState.CheckInAtEvent(this);

        public void UploadEventResults() => CurrentState.UploadEventResults(this);
    }
}
