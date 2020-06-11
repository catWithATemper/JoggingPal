using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class LocationSet : ParticipantState
    {
        private static readonly LocationSet instance = new LocationSet();
        private LocationSet() { }

        public static LocationSet Instance { get => instance; }

        public void CheckInAtEvent(ParticipationContext ctx)
        {
            ctx.CurrentState = CheckedIn.Instance;
        }

        public void SetLocation(ParticipationContext ctx) { }

        public void UploadEventResults(ParticipationContext ctx) { }
    }
}
