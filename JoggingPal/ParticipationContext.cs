using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class ParticipationContext
    {
        public ParticipationContext(Participant participant)
        {
            this.Participant = participant;
            this.CurrentState = SignedUp.Instance;
        }

        public Participant Participant { get; set; }

        public ParticipantState CurrentState { get; set; }

        public void SetLocation() => CurrentState.SetLocation(this);

        public void CheckInAtEvent() => CurrentState.CheckInAtEvent(this);

        public void UploadEventResults() => CurrentState.UploadEventResults(this);
    }
}
