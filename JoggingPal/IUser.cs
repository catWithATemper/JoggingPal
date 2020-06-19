using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    public interface IUser
    {
        void SignUpForEvent(Event selectedEvent);

        UserGroup CreateUserGroup(String name);

        void JoinGroup(UserGroup group);

        void LeaveGroup(UserGroup group);

        void AddMember(IUser user);

        void RemoveMember(IUser user);




    }
}
