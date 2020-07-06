using JoggingPal.Models.Events;
using JoggingPal.Models.Locations;
using JoggingPal.Models.Participants;
using System.Collections.Generic;

namespace JoggingPal.Models.Users

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

        public UserGroup CreateUserGroup(string name)
        {
            return new UserGroup(this, name);
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
