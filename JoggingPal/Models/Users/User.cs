using JoggingPal.Models.Events;
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
    }
}
