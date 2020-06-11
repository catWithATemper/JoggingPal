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
    
    }
}
