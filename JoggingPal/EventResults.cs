using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class EventResults
    {
        /*
        double totalSpeed;
        double avgSpeed;
        int avgHeartRate;
        */

        private List<Object> resultParts = new List<object>();

        public void Add(String part)
        {
            resultParts.Add(part);
        }

        public String ListParts()
        {
            String str = String.Join(", ", resultParts);
            return "Event results: " + str + "\n";
        }


    }
}
