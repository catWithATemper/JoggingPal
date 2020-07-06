using System;

namespace JoggingPal.Models.Results
{
    interface IEventResultsBuilder
    {
        void BuildTotalTime(TimeSpan totalTime);

        void BuildMaxSpeed(double maxSpeed);

        void BuildAvgHeartRate(int avgHeartRate);
    }
}
