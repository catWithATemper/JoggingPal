using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class SignedUp : ParticipantState
    {
        private static readonly SignedUp instance = new SignedUp();
        private SignedUp() { }

        public static SignedUp Instance { get => instance; }

        public void SetLocation(ParticipationContext ctx)
        {
            ctx.CurrentState = LocationSet.Instance;
        }

        public void CheckInAtEvent(ParticipationContext ctx) { }

        public void UploadEventResults(ParticipationContext ctx) { }

        public override string ToString()
        {
            return "Signed up";
        }




    }
}
