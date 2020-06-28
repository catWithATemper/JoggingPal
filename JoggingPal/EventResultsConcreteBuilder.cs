using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class EventResultsConcreteBuilder : IEventResultsBuilder
    {
        private EventResults eventResults;

        private void Reset()
        {
            eventResults = new EventResults();
        }

        public EventResultsConcreteBuilder()
        {
            this.Reset();
        }

        public void BuildTotalTime(TimeSpan totalTime)
        {
            eventResults.Add("Total time: ", totalTime.ToString());
        }

        public void BuildMaxSpeed(double maxSpeed)
        {
            eventResults.Add("Maximum speed: ", maxSpeed.ToString());
        }

        public void BuildAvgHeartRate(int avgHeartRate)
        {
            eventResults.Add("Average heart rate: ", avgHeartRate.ToString());
        }

        public EventResults GetResults()
        {
            EventResults results = eventResults;
            this.Reset();
            return results;
        }
    }
}
