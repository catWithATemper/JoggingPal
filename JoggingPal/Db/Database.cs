using JoggingPal.Models.Events;
using JoggingPal.Models.Locations;
using JoggingPal.Models.Participants;
using JoggingPal.Models.Results;
using JoggingPal.Models.Users;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace JoggingPal.Db
{
    class Database
    {
        private static Database instance = new Database();

        public Dictionary<string, User> Users { get; } = new Dictionary<string, User>();
        public Dictionary<string, Event> Events { get; } = new Dictionary<string, Event>();
        public Dictionary<string, Location> RunningLocations { get; } = new Dictionary<string, Location>();
        public Dictionary<string, UserGroup> UserGroups { get; } = new Dictionary<string, UserGroup>();

        public Dictionary<string, InPersonEvent> InPersonEvents
        {
            get
            {
                Dictionary<string, InPersonEvent> inPersonEvents = new Dictionary<string, InPersonEvent>();
                foreach (Event e in Events.Values)
                {
                    if (typeof(InPersonEvent).IsInstanceOfType(e))
                        inPersonEvents.Add(e.EventTitle, (InPersonEvent)e);
                }
                return inPersonEvents;
            }
        }

        public Dictionary<string, VirtualEvent> VirtualEvents
        {
            get
            {
                Dictionary<string, VirtualEvent> virtualEvents = new Dictionary<string, VirtualEvent>();
                foreach (Event e in Events.Values)
                {
                    if (typeof(VirtualEvent).IsInstanceOfType(e))
                        virtualEvents.Add(e.EventTitle, (VirtualEvent)e);
                }
                return virtualEvents;
            }
        }

        public Dictionary<string, Event> PastEvents
        {
            get
            {
                Dictionary<string, Event> pastEvents = new Dictionary<string, Event>();
                foreach (Event e in Events.Values)
                {
                    if (e.DateTime.CompareTo(DateTime.Now) <= 0)
                        pastEvents.Add(e.EventTitle, e);
                }
                return pastEvents;
            }
        }

        public Dictionary<string, Event> UpcomingEvents
        {
            get
            {
                Dictionary<string, Event> upcomingEvents = new Dictionary<string, Event>();
                foreach (Event e in Events.Values)
                {
                    if (e.DateTime.CompareTo(DateTime.Now) > 0)
                        upcomingEvents.Add(e.EventTitle, e);
                }
                return upcomingEvents;
            }
        }

        protected Database()
        {
            User user1 = new User("Tom", "password");
            User user2 = new User("Alex", "password");
            User user3 = new User("Lisa", "password");
            User user4 = new User("Mario", "password");
            User user5 = new User("Lucia", "password");

            Users.Add(user1.UserName, user1);
            Users.Add(user2.UserName, user2);
            Users.Add(user3.UserName, user3);
            Users.Add(user4.UserName, user4);
            Users.Add(user5.UserName, user5);

            Location route1 = new Location("Ostpark, Munich", 48.112242, 11.630701, 5);
            Location route2 = new Location("Parco di Villa Borghese, Rome", 41.914614, 12.481987, 5);
            Location route3 = new Location("Parco degli Acquedotti, Rome", 41.853406, 12.557115, 7);

            RunningLocations.Add(route1.RouteName, route1);
            RunningLocations.Add(route2.RouteName, route2);
            RunningLocations.Add(route3.RouteName, route3);

            Event jogging1 = new InPersonEvent("01/08/2020 11:00:00 AM", 7.0,
                                                "Jogging at Ostpark", route1);
            Event jogging2 = new InPersonEvent("09/7/2020 05:00:00 PM", 7.0,
                                                "After work jogging ", route1);
            Event jogging3 = new VirtualEvent("15/7/2020 11:00:00 AM", 7.0,
                                               "Jogging together as a virtual group", 8.0);
            Event jogging4 = new InPersonEvent("01/06/2020 10:00:00 AM", 6.0,
                                                "Morning jogging at Parco degli Acquedotti", route3);
            Event jogging5 = new VirtualEvent("28/7/2020 7:00:00 PM", 7.0,
                                   "Jogging in different places", 8.0);

            Events.Add(jogging1.EventTitle, jogging1);
            Events.Add(jogging2.EventTitle, jogging2);
            Events.Add(jogging3.EventTitle, jogging3);
            Events.Add(jogging4.EventTitle, jogging4);
            Events.Add(jogging5.EventTitle, jogging5);

            Participant part1 = new Participant(user1, jogging1);
            Participant part2 = new Participant(user1, jogging3);
            Participant part3 = new Participant(user1, jogging4);
            Participant part4 = new Participant(user2, jogging4);
            Participant part5 = new Participant(user3, jogging4);
            Participant part6 = new Participant(user4, jogging4);
            Participant part7 = new Participant(user1, jogging5);
            part7.SetRunningLocation(route3);

            part3.CheckInAtEvent();
            part4.CheckInAtEvent();
            part5.CheckInAtEvent();
            part6.CheckInAtEvent();

            EventResults results1 = part3.UploadEventResults(TimeSpan.Parse("00:31:00", CultureInfo.InvariantCulture), 7.4, 166);
            EventResults results2 = part4.UploadEventResults(TimeSpan.Parse("00:31:00", CultureInfo.InvariantCulture), null, 170);
            EventResults results3 = part5.UploadEventResults(TimeSpan.Parse("00:34:00", CultureInfo.InvariantCulture), 6.5, null);
            EventResults results4 = part6.UploadEventResults(TimeSpan.Parse("00:35:00", CultureInfo.InvariantCulture), null, null);

            UserGroup group1 = new UserGroup(user1, "Munich Joggers");
            UserGroup group2 = new UserGroup(user2, "Milan Joggers");
            UserGroup group3 = new UserGroup(user3, "City jogggers");

            UserGroups.Add(group1.GroupName, group1);
            UserGroups.Add(group2.GroupName, group2);
            UserGroups.Add(group3.GroupName, group3);

            group1.AddMember(user3);
            group1.AddMember(user4);
            group2.AddMember(user4);
            group2.AddMember(user5);
            group3.AddMember(user1);
        }

        public static Database Instance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
    }
}
