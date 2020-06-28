using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class EventResults
    {
        public Dictionary<string, string> resultParts = new Dictionary<string, string>();
        
        public void Add(string resultKey, string resultValue)
        {
            resultParts.Add(resultKey, resultValue);
        }

        public String ListParts()
        {
            String str = String.Join(", ", resultParts);
            return "Event results: " + str + "\n";
        }


    }
}
