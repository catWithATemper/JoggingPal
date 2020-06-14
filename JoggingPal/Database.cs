using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class Database
    {
        private static Database instance = new Database();

        public IList<User> users = new List<User>();
        public IList<Event> events = new List<Event>();

        protected Database () 
        {
            users.Add(new User("Tom"));
            users.Add(new User("Billy"));

            Location route1 = new Location("Ostpark", 48.112242, 11.630701, 5);

            events.Add(new InPersonEvent("10/7/2020 11:00:00 AM", 7.0, route1));
            events.Add(new InPersonEvent("09/7/2020 05:00:00 PM", 7.0, route1));
            events.Add(new VirtualEvent("02/7/2020 11:00:00 AM", 7.0, 8.0));
        }

        public static Database Instance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

    }
}
