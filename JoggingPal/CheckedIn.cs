﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class CheckedIn : ParticipantState
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
            ctx.CurrentState = CheckedIn.Instance;
        }

        public void SetLocation(ParticipationContext ctx) => throw new InvalidCastException();

        public override string ToString()
        {
            return "Checked in";
        }

    }
}
