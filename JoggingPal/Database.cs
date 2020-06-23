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
        public IList<VirtualEvent> virtualEvents = new List<VirtualEvent>();
        public IList<InPersonEvent> inPersonEvents = new List<InPersonEvent>();
        public Dictionary<string, Location> joggingLocations = new Dictionary<string, Location>();
        public IList<UserGroup> userGroups = new List<UserGroup>();
        public IList<Event> pastEvents = new List<Event>();
        public IList<Event> upcomingEvents = new List<Event>();

        public User currentUser;

        protected Database () 
        {
            User user1 = new User("Tom");
            User user2 = new User("Billy");
            User user3 = new User("Lisa");
            User user4 = new User("Mario");
            User user5 = new User("Lucia");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);

            //Only for testing
            currentUser = users[0];

            Location route1 = new Location("Ostpark, Munich", 48.112242, 11.630701, 5);
            Location route2 = new Location("Parco di Villa Borghese, Rome", 41.914614, 12.481987, 5);
            Location route3 = new Location("Parco degli Acquedotti, Rome", 41.853406, 12.557115, 7);

            joggingLocations.Add(route1.RouteName, route1);
            joggingLocations.Add(route2.RouteName, route2);
            joggingLocations.Add(route3.RouteName, route3);

            Event jogging1 = new InPersonEvent("10/7/2020 11:00:00 AM", 7.0, route1);
            Event jogging2 = new InPersonEvent("09/7/2020 05:00:00 PM", 7.0, route1);
            Event jogging3 = new VirtualEvent("02/7/2020 11:00:00 AM", 7.0, 8.0);
            Event jogging4 = new InPersonEvent("01/06/2020 10:00:00 AM", 6.0, route3);

            events.Add(jogging1);
            events.Add(jogging2);
            events.Add(jogging3);
            events.Add(jogging4);

            foreach (Event e in events)
            {
                if (typeof(InPersonEvent).IsInstanceOfType(e))
                    inPersonEvents.Add((InPersonEvent)e);
                else
                    virtualEvents.Add((VirtualEvent)e);
            }

            foreach (Event e in events)
            {
                if (e.DateTime.CompareTo(DateTime.Now) > 0)
                    upcomingEvents.Add(e);
                else
                    pastEvents.Add(e);
            }

            Participant part1 = new Participant(user1, jogging1);
            Participant part2 = new Participant(user1, jogging3);
            Participant part3 = new Participant(user1, jogging4);

            UserGroup group1 = new UserGroup(user1, "Munich Joggers");
            UserGroup group2 = new UserGroup(user2, "Milan Joggers");
            UserGroup group3 = new UserGroup(user3, "City jogggers");

            userGroups.Add(group1);
            userGroups.Add(group2);
            userGroups.Add(group3);

            group1.AddMember(user3);
            group1.AddMember(user4);
            group2.AddMember(user4);
            group2.AddMember(user5);
            group3.AddMember(user1);

            Participant part4 = new Participant(user2, jogging4);
            Participant part5 = new Participant(user3, jogging4);
            Participant part6 = new Participant(user4, jogging4);

            EventResults results1 = part3.UploadEventResults(31.0, 7.4, 166);
            EventResults results2 = part4.UploadEventResults(31.0, null, 170);
            EventResults results3 = part5.UploadEventResults(34.0, 6.5, null);
            EventResults results4 = part6.UploadEventResults(35.0, null, null);
        }

        public static Database Instance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

    }
}
