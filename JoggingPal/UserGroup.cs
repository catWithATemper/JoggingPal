using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public class UserGroup : IUser
    {
        public User admin;
        string groupName;
        public IList<IUser> members;

        public UserGroup(User administrator, String name)
        {
            admin = administrator;
            groupName = name;
            members = new List<IUser>();
            members.Add(admin);
        }

        public void AddMember(IUser user)
        {
            members.Add(user);
        }


        public void RemoveMember(IUser user)
        {
            members.Remove(user);
        }

        public IEnumerable<IUser> GetMembers()
        {
            return members;
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
            foreach (IUser user in members)
            {
                user.SignUpForEvent(selectedEvent);
            }
        }

        public UserGroup CreateUserGroup(String name)
        {
            return new UserGroup(this.admin, name);
        }

        public void InviteToGroup()
        { }

        public override String ToString()
        {
            return "Group name: " + groupName + " Admin: " + admin.userName + " members: "
                + members.Count;
        }
    }
}
