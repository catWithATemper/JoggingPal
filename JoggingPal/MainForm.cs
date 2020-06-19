using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class MainForm : Form
    {
        Database db = Database.Instance();

        public MainForm()
        {
            InitializeComponent();
            
            /*
            LogInForm logIn = new LogInForm();
            var result = logIn.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Close();
            */
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + db.currentUser.userName;

            foreach (Event item in db.events)
            {
                if (typeof(InPersonEvent).IsInstanceOfType(item))
                    listInPersonEvents.Items.Add(item.ToString());
                else
                    listVirtualEvents.Items.Add(item.ToString());
            }

            foreach (UserGroup group in db.userGroups)
                listGroups.Items.Add(group.ToString());

            foreach (Event upcomingEvent in db.events)
            {
                if (upcomingEvent.FindParticipant(db.currentUser) != null)
                {
                    listUpcomingEvents.Items.Add(upcomingEvent.ToString());
                }
            }
        }

        private void btnEventsSignUp_Click(object sender, EventArgs e)
        {
            Participant p = null;
            foreach (int i in listInPersonEvents.SelectedIndices)
            {
                p = new Participant(db.currentUser, db.inPersonEvents[i]);
            }
            foreach(int i in listVirtualEvents.SelectedIndices)
            {
                p = new Participant(db.currentUser, db.virtualEvents[i]);
            }
            Console.WriteLine(p.ToString());

            if (p != null)
            {
                listUpcomingEvents.Items.Add(p.ToString());
                MessageBox.Show("You have signed up successfully");
            }
            else
                MessageBox.Show("Select an event");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            BrowseLocationsForm browseLocations = new BrowseLocationsForm();

            foreach (int i in listVirtualEvents.SelectedIndices)
            {
                browseLocations.SelectedEvent = db.virtualEvents[i];
            }
            browseLocations.Show();
        }

        private void btnFindEvents_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabEvents);
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
            CreateNewEventForm createNewEvent = new CreateNewEventForm();
            createNewEvent.ShowDialog();
            EventListsRefresh();
        }

        private void EventListsRefresh()
        {
            listInPersonEvents.Items.Clear();
            listVirtualEvents.Items.Clear();
            foreach (Event item in db.events)
            {
                if (typeof(InPersonEvent).IsInstanceOfType(item))
                    listInPersonEvents.Items.Add(item.ToString());
                else
                    listVirtualEvents.Items.Add(item.ToString());
            }

        }

        private void btnSignUpGroup_Click(object sender, EventArgs e)
        {
            SignUpGroupForm signUpGroup = new SignUpGroupForm();
            foreach (int i in listInPersonEvents.SelectedIndices)
            {
                signUpGroup.SelectedEvent = db.inPersonEvents[i];
            }
            foreach (int i in listVirtualEvents.SelectedIndices)
            {
                signUpGroup.SelectedEvent = db.virtualEvents[i];
            }
            Console.WriteLine(signUpGroup.SelectedEvent.ToString());

            signUpGroup.ShowDialog();
            UpComingEventsListRefresh();
        }

        private void UpComingEventsListRefresh()
        {
            listUpcomingEvents.Items.Clear();
            foreach (Event upcomingEvent in db.events)
            {
                if (upcomingEvent.FindParticipant(db.currentUser) != null)
                {
                    listUpcomingEvents.Items.Add(upcomingEvent.ToString());
                }
            }

        }

        private void btnCreateNewGroup_Click(object sender, EventArgs e)
        {
            CreateNewGroupForm createNewGroup = new CreateNewGroupForm();
            createNewGroup.ShowDialog();
            UserGroupListRefresh();
        }

        private void UserGroupListRefresh()
        {
            listGroups.Items.Clear();
            foreach (UserGroup group in db.userGroups)
                listGroups.Items.Add(group.ToString());
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            foreach (int i in listGroups.SelectedIndices)
            {
                db.userGroups[i].AddMember(db.currentUser);
                foreach (User user in db.userGroups[i].GetMembers())
                    Console.WriteLine(user.userName);
            }
            UserGroupListRefresh();

        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            foreach (int i in listGroups.SelectedIndices)
            {
                if (db.currentUser.userName != db.userGroups[i].admin.userName)
                    db.userGroups[i].RemoveMember(db.currentUser);
                    foreach (User user in db.userGroups[i].GetMembers())
                    Console.WriteLine(user.userName);
            }
            UserGroupListRefresh();
        }
    }
}
