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

        public void BuildSimpleResults(double totalTime)
        {
            builder.BuildTotalTime(totalTime);
        }

        public void BuildResultsWithMaxSpeed(double totalTime, double maxSpeed)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildMaxSpeed(maxSpeed);
        }

        public void BuildResultsWithHeartRate(double totalTime, int avgHeartRate)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildAvgHeartRate(avgHeartRate);
        }

        public void BuildDetailedResults(double totalTime, double maxSpeed, int avgHeartRate)
        {
            builder.BuildTotalTime(totalTime);
            builder.BuildMaxSpeed(maxSpeed);
            builder.BuildAvgHeartRate(avgHeartRate);
        }

       
    
    }
}
