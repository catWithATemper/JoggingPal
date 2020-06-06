using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JoggingPal
{
    class User : IUser
    {
        string email;
        string password;
        public string userName;
        //city
        double avgSpeed;
        IList<IUser> members;

        public double AvgSpeed
        {
            get { return avgSpeed; }
            set { avgSpeed = value; }
        }

        public User(string nameString, string emailString, string passwordString)
        {
            userName = nameString;
            email = emailString;
            password = passwordString;
            members = new List<IUser>();
        }

        public User(string nameString)
        {
            userName = nameString;
            email = "";
            password = "password";
            members = new List<IUser>();
        }

        public bool LogIn(string nameString, string passwordString)
        {
            bool success = false;
            if (userName == nameString && password == passwordString)
                success = true;
            return success;
        }

        //Return type was changed from "participant"
        public void SignUpForEvent(Event selectedEvent)
        {
            new Participant(this, selectedEvent);
        }

        public InPersonEvent CreateInPersonEvent(string dateTimeString, double avgSpeed, Location location)
        {
            return new InPersonEvent(dateTimeString, avgSpeed, location);
        }

        public VirtualEvent CreateVirtualEvent(string dateTimeString, double avgSpeed, double length)
        {
            return new VirtualEvent(dateTimeString, avgSpeed, length);
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
            return members;
        }

        public Location CreateLocation(string name, double lat, double lon, double length)
        {
            return new Location(name, lat, lon, length);
        }

        public void CheckInAtEvent()
        { }
    }
}
