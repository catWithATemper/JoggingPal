using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    interface IEventResultsBuilder
    {
        void BuildTotalTime(TimeSpan totalTime);

        void BuildMaxSpeed(double maxSpeed);

        void BuildAvgHeartRate(int avgHeartRate);
    }
}
