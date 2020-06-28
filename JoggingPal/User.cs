using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class User : IUser
    {
        public string UserName { get; }
        public string Password { get; }
        IList<IUser> Members { get; }

        public User(string nameString, string passwordString)
        {
            UserName = nameString;
            Password = passwordString;
            Members = new List<IUser>();
        }

        public User(string nameString)
        {
            UserName = nameString;
            Password = "password";
            Members = new List<IUser>();
        }

        public void SignUpForEvent(Event selectedEvent)
        {
            new Participant(this, selectedEvent);
        }

        public InPersonEvent CreateInPersonEvent(string dateTimeString, double avgSpeed, string eventTitle, Location location)
        {
            return new InPersonEvent(dateTimeString, avgSpeed, eventTitle, location);
        }

        public VirtualEvent CreateVirtualEvent(string dateTimeString, double avgSpeed, string eventTitle, double length)
        {
            return new VirtualEvent(dateTimeString, avgSpeed, eventTitle, length);
        }
       
        public UserGroup CreateUserGroup(String name)
        {
            return new UserGroup(this, name);
        }

        public void JoinGroup(UserGroup group)
        {
            group.AddMember(this);
        }

        public void LeaveGroup(UserGroup group)
        {
            group.RemoveMember(this);
        }

        public void AddMember(IUser user)
        { }

        public void RemoveMember(IUser user)
        { }

        public IEnumerable<IUser> GetMembers()
        {
            return Members;
        }

        public Location CreateLocation(string name, double lat, double lon, double length)
        {
            return new Location(name, lat, lon, length);
        }
    }
}
