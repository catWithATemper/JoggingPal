using JoggingPal.Models.Events;
using System.Collections.Generic;

namespace JoggingPal.Models.Users
{
    public class UserGroup : IUser
    {
        public User Admin { get; }
        public string GroupName { get; }
        public IList<IUser> Members { get; }

        public UserGroup(User administrator, string name)
        {
            Admin = administrator;
            GroupName = name;
            Members = new List<IUser>();
            Members.Add(Admin);
        }

        public void AddMember(IUser user)
        {
            Members.Add(user);
        }

        public void RemoveMember(IUser user)
        {
            Members.Remove(user);
        }

        public IEnumerable<IUser> GetMembers()
        {
            return Members;
        }

        public void SignUpForEvent(Event selectedEvent)
        {
            foreach (IUser user in Members)
                if (typeof(User).IsInstanceOfType(user)
                    && selectedEvent.FindParticipant((User)user) == null)
                    user.SignUpForEvent(selectedEvent);
        }

        public override string ToString()
        {
            return "Group name: " + GroupName + " Admin: " + Admin.UserName + " members: "
                + Members.Count;
        }
    }
}
