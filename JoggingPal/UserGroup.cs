using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class UserGroup : IUser
    {
        public User Admin { get; }
        public string GroupName { get; }
        public IList<IUser> Members { get; }

        public UserGroup(User administrator, String name)
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

        public void JoinGroup(UserGroup group)
        {
            group.AddMember(this);
        }

        public void LeaveGroup(UserGroup group)
        {
            group.RemoveMember(this);
        }

        public void SignUpForEvent(Event selectedEvent)
        { 
            foreach (IUser user in Members)
            {
                user.SignUpForEvent(selectedEvent);
            }
        }

        public UserGroup CreateUserGroup(String name)
        {
            return new UserGroup(this.Admin, name);
        }

        public override String ToString()
        {
            return "Group name: " + GroupName + " Admin: " + Admin.UserName + " members: "
                + Members.Count;
        }
    }
}
