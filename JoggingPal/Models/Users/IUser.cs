﻿using JoggingPal.Models.Events;

namespace JoggingPal.Models.Users
{
    public interface IUser
    {
        void SignUpForEvent(Event selectedEvent);

        void AddMember(IUser user);

        void RemoveMember(IUser user);
    }
}
