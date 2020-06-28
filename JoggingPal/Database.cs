using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoggingPal
{
    class Database
    {
        private static Database instance = new Database();

        public Dictionary<string, User> users = new Dictionary<string, User>();
        public Dictionary<string, Event> events = new Dictionary<string, Event>();
        public Dictionary<string, VirtualEvent> virtualEvents = new Dictionary<string, VirtualEvent>();
        public Dictionary<string, InPersonEvent> inPersonEvents = new Dictionary<string, InPersonEvent>();
        public Dictionary<string, Location> joggingLocations = new Dictionary<string, Location>();
        public Dictionary<string, UserGroup> userGroups = new Dictionary<string, UserGroup>();
        public Dictionary<string, Event> pastEvents = new Dictionary<string, Event>();
        public Dictionary<string, Event> upcomingEvents = new Dictionary<string, Event>();

        protected Database () 
        {
            User user1 = new User("Tom");
            User user2 = new User("Alex");
            User user3 = new User("Lisa");
            User user4 = new User("Mario");
            User user5 = new User("Lucia");

            users.Add(user1.UserName, user1);
            users.Add(user2.UserName, user2);
            users.Add(user3.UserName, user3);
            users.Add(user4.UserName, user4);
            users.Add(user5.UserName, user5);

            Location route1 = new Location("Ostpark, Munich", 48.112242, 11.630701, 5);
            Location route2 = new Location("Parco di Villa Borghese, Rome", 41.914614, 12.481987, 5);
            Location route3 = new Location("Parco degli Acquedotti, Rome", 41.853406, 12.557115, 7);

            joggingLocations.Add(route1.RouteName, route1);
            joggingLocations.Add(route2.RouteName, route2);
            joggingLocations.Add(route3.RouteName, route3);

            Event jogging1 = new InPersonEvent("10/7/2020 11:00:00 AM", 7.0,
                                                "Jogging at Ostpark", route1);
            Event jogging2 = new InPersonEvent("09/7/2020 05:00:00 PM", 7.0,
                                                "After work jogging ",route1);
            Event jogging3 = new VirtualEvent("02/7/2020 11:00:00 AM", 7.0,
                                               "Jogging together as a virtual group", 8.0);
            Event jogging4 = new InPersonEvent("01/06/2020 10:00:00 AM", 6.0,
                                                "Morning jogging at Parco degli Acquedotti", route3);

            events.Add(jogging1.EventTitle, jogging1);
            events.Add(jogging2.EventTitle, jogging2);
            events.Add(jogging3.EventTitle, jogging3);
            events.Add(jogging4.EventTitle, jogging4);

            foreach (Event e in events.Values)
            {
                if (typeof(InPersonEvent).IsInstanceOfType(e))
                    inPersonEvents.Add(e.EventTitle, (InPersonEvent)e);
                else
                    virtualEvents.Add(e.EventTitle,(VirtualEvent)e);
            }

            foreach (Event e in events.Values)
            {
                if (e.DateTime.CompareTo(DateTime.Now) > 0)
                    upcomingEvents.Add(e.EventTitle, e);
                else
                    pastEvents.Add(e.EventTitle, e);
            }

            Participant part1 = new Participant(user1, jogging1);
            Participant part2 = new Participant(user1, jogging3);
            Participant part3 = new Participant(user1, jogging4);
            part3.CheckInAtEvent();

            UserGroup group1 = new UserGroup(user1, "Munich Joggers");
            UserGroup group2 = new UserGroup(user2, "Milan Joggers");
            UserGroup group3 = new UserGroup(user3, "City jogggers");

            userGroups.Add(group1.GroupName, group1);
            userGroups.Add(group2.GroupName, group2);
            userGroups.Add(group3.GroupName, group3);

            group1.AddMember(user3);
            group1.AddMember(user4);
            group2.AddMember(user4);
            group2.AddMember(user5);
            group3.AddMember(user1);

            Participant part4 = new Participant(user2, jogging4);
            Participant part5 = new Participant(user3, jogging4);
            Participant part6 = new Participant(user4, jogging4);
            part4.CheckInAtEvent();
            part5.CheckInAtEvent();
            part6.CheckInAtEvent();

            EventResults results1 = part3.UploadEventResults(TimeSpan.Parse("00:31:00", CultureInfo.InvariantCulture), 7.4, 166);
            EventResults results2 = part4.UploadEventResults(TimeSpan.Parse("00:31:00", CultureInfo.InvariantCulture), null, 170);
            EventResults results3 = part5.UploadEventResults(TimeSpan.Parse("00:34:00", CultureInfo.InvariantCulture), 6.5, null);
            EventResults results4 = part6.UploadEventResults(TimeSpan.Parse("00:35:00", CultureInfo.InvariantCulture), null, null);
        }

        public static Database Instance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
    }
}
