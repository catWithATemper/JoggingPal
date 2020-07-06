using System;

namespace JoggingPal.Models.Results
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
            Reset();
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
            Reset();
            return results;
        }
    }
}
