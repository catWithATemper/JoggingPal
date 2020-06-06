using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Runtime.InteropServices.ComTypes;

namespace JoggingPal
{
    class Tester
    {
        public static void TestCreateLocation()
        {
            //GeoCoordinate Coordinates = new GeoCoordinate(48.112242, 11.630701);
            Location runningLocation = new Location("Ostpark", 48.112242, 11.630701, 5);
            Console.WriteLine(runningLocation.ToString() + "\n") ;
        }

        /* // Event is now abstract
        public static void TestCreateEvent()
        {
            Event abstractEvent = new Event("10/7/2020 11:00:00 AM", 7.0);
            Console.WriteLine(abstractEvent.ToString() + "\n");
        }
        */

        public static void TestCreateInPersonEvent()
        {
            Location joggingLocation = new Location("Ostpark", 48.112242, 11.630701, 10);
            InPersonEvent event1 = new InPersonEvent("10/7/2020 11:00:00 AM", 7.0, joggingLocation);
            Console.WriteLine(event1.GetType().Name + event1.ToString() + "\n");
        }

        /*
        public static void TestCreateVirtualEvent()
        {
            VirtualEvent event2 = new VirtualEvent("10/7/2020 11:00:00 AM", 7.0, 5.0);
            Console.WriteLine(event2.GetType().Name + event2.ToString() + "\n");
        }
        */

        public static void TestUserCreateLocation()
        {
            User user1 = new User("Tom");
            Location route = user1.CreateLocation("Ostpark", 48.112242, 11.630701, 5);
            Console.WriteLine(route.ToString() + "\n");
        }

        public static void TestUserCreateInPersonEvent()
        {
            User user1 = new User("Tom");
            Location route = user1.CreateLocation("Ostpark", 48.112242, 11.630701, 5);
            InPersonEvent event1 = user1.CreateInPersonEvent("10/7/2020 11:00:00 AM", 7.0, route);
            Console.WriteLine(event1.ToString());
        }

        public static void TestUserCreateVirtualEvent()
        {
            User user2 = new User("Tom");
            VirtualEvent event2 = user2.CreateVirtualEvent("10/7/2020 11:00:00 AM", 7.0, 8.0);
            Console.WriteLine(event2.ToString());
        }

        public static void TestUserSignUpForEvent()
        {
            User user2 = new User("Tom");
            User user1 = new User("Billy");
            VirtualEvent event2 = user2.CreateVirtualEvent("10/7/2020 11:00:00 AM", 7.0, 8.0);
            Location route = user1.CreateLocation("Ostpark", 48.112242, 11.630701, 5);

            //Participant participant1 = user1.SignUpForEvent(event2);
            //participant1.SetRunningLocation(route);
            
            //Console.WriteLine(participant1.ToString());  
        }

        public static void TestUserGroupSignUpForEvent()
        {
            User user2 = new User("Tom");
            User user1 = new User("Billy");
            User user3 = new User("Frank");
            UserGroup group = user1.CreateUserGroup("JoggingGroup");
            user2.JoinGroup(group);
            user3.JoinGroup(group);

            Location route = user1.CreateLocation("Ostpark", 48.112242, 11.630701, 5);
            InPersonEvent event1 = user1.CreateInPersonEvent("10/7/2020 11:00:00 AM", 7.0, route);
            InPersonEvent event2 = user1.CreateInPersonEvent("01/7/2020 09:00:00 AM", 7.0, route);

            user1.SignUpForEvent(event2);
            group.SignUpForEvent(event1);

            foreach(Participant p in event2.participants)
                Console.WriteLine(p.ToString());

            foreach (Participant p in event1.participants)
                Console.WriteLine(p.ToString());
        }

        public static void TestCompositeUserGroup()
        {
            User user2 = new User("Tom");
            User user1 = new User("Billy");
            User user3 = new User("Frank");
            UserGroup group = user1.CreateUserGroup("JoggingGroup");
            user2.JoinGroup(group);
            UserGroup largerGroup = group.CreateUserGroup("LargerJoggingGroup");
            user3.JoinGroup(largerGroup);

            foreach (User user in group.members)
                Console.WriteLine(user.userName.ToString());
            foreach (User user in largerGroup.members)
                Console.WriteLine(user.ToString());

            user2.LeaveGroup(group);
            foreach (IUser user in group.members)
                Console.WriteLine(user.ToString());
        }

    }
}
