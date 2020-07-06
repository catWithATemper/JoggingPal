using JoggingPal.Models.Participants;

namespace JoggingPal.Models.ParticipantStates
{
    public interface IParticipantState
    {
        void SetLocation(ParticipationContext ctx);

        void CheckInAtEvent(ParticipationContext ctx);

        void UploadEventResults(ParticipationContext ctx);

        string ToString();
    }
}
