using System.Collections.Generic;

namespace JoggingPal.Models.Results
{
    public class EventResults
    {
        public Dictionary<string, string> resultParts = new Dictionary<string, string>();

        public void Add(string resultKey, string resultValue)
        {
            resultParts.Add(resultKey, resultValue);
        }

        public string ToString()
        {
            string str = string.Join(", ", resultParts);
            return "Event results: " + str + "\n";
        }
    }
}
