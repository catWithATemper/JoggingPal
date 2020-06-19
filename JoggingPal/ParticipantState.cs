using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public interface ParticipantState
    {
        void SetLocation(ParticipationContext ctx);

        void CheckInAtEvent(ParticipationContext ctx);

        void UploadEventResults(ParticipationContext ctx);
    }
}
