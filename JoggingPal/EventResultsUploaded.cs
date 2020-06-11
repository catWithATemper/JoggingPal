using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class EventResultsUploaded : ParticipantState
    {
        private static readonly EventResultsUploaded instance = new EventResultsUploaded();
        private EventResultsUploaded() { }

        public static EventResultsUploaded Instance { get => instance; }

        public void UploadEventResults(ParticipationContext ctx)
        {
            Console.WriteLine("Event results uploaded. ");
        }

        public void CheckInAtEvent(ParticipationContext ctx) { }

        public void SetLocation(ParticipationContext ctx) { }
    }
}
