using System;

namespace JoggingPal.Models.Results
{
    class EventResultsDirector
    {
        private IEventResultsBuilder builder;

        public IEventResultsBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildSimpleResults(TimeSpan totalTime)
        {
            builder.BuildTotalTime(totalTime);
        }

        public void BuildResultsWithMaxSpeed(TimeSpan totalTime, double maxSpeed)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildMaxSpeed(maxSpeed);
        }

        public void BuildResultsWithHeartRate(TimeSpan totalTime, int avgHeartRate)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildAvgHeartRate(avgHeartRate);
        }

        public void BuildDetailedResults(TimeSpan totalTime, double maxSpeed, int avgHeartRate)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildMaxSpeed(maxSpeed);
            builder.BuildAvgHeartRate(avgHeartRate);
        }
    }
}
