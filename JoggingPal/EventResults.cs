using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class EventResults
    {
        private Dictionary<string, double> resultParts = new Dictionary<string, double>();

        public void Add(string resultKey, double resultValue)
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
