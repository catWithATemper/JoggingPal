using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
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
