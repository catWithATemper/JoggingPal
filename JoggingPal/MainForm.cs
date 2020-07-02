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
                Close();
            */
            LogInForm.CurrentUser = db.users["Tom"];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + LogInForm.CurrentUser.UserName;

            listUpcomingEventsLoad();
            listPastEventsLoad();
            listInPersonEventsLoad();
            listVirtualEventsLoad();
            listGroupsLoad();
        }

        private void btnEventsSignUp_Click(object sender, EventArgs e)
        {
            if (listInPersonEvents.SelectedItems.Count == 0
                && listVirtualEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which event you want to sign up to.");
                return;
            }
            
            Participant p = null;
            string key;
            foreach (ListViewItem item in listInPersonEvents.SelectedItems)
            { 
                key = item.SubItems[0].Text;
                if (db.inPersonEvents[key].FindParticipant(LogInForm.CurrentUser) != null)
                {
                    MessageBox.Show("You have already signed up for this event.");
                    return;
                }
                
                p = new Participant(LogInForm.CurrentUser, db.inPersonEvents[key]);
                listUpcomingEventsRefresh();
                MessageBox.Show("You have signed up successfully");
                return;
 
            }
            foreach (ListViewItem item in listVirtualEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                if (db.virtualEvents[key].FindParticipant(LogInForm.CurrentUser) != null)
                {
                    MessageBox.Show("You have already signed up for this event.");
                    return;
                }

                p = new Participant(LogInForm.CurrentUser, db.virtualEvents[key]);
                listUpcomingEventsRefresh();
                MessageBox.Show("You have signed up successfully");
                return;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            if (listUpcomingEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a virtual event from the list.");
                return;
            }
            BrowseLocationsForm browseLocations = new BrowseLocationsForm();

            foreach (ListViewItem item in listUpcomingEvents.SelectedItems)
            {   
                string key = item.SubItems[0].Text;
                if (!typeof(VirtualEvent).IsInstanceOfType(db.events[key]))
                {
                    MessageBox.Show("Choosing a location is only possible for virtual events.");
                    return;
                }
                else
                    browseLocations.SelectedEvent = (VirtualEvent)db.events[key];
            }
            browseLocations.ShowDialog();
            listUpcomingEventsRefresh();
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
            CreateNewEventForm createNewEvent = new CreateNewEventForm();
            createNewEvent.ShowDialog();
            listInPersonEventsRefresh();
            listVirtualEventsRefresh();
        }

        private void btnSignUpGroup_Click(object sender, EventArgs e)
        {
            if (listInPersonEvents.SelectedItems.Count == 0
                && listVirtualEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which event you want the group to be signed up to.");
                return;
            }
            
            SignUpGroupForm signUpGroup = new SignUpGroupForm();
            string key;
            foreach (ListViewItem item in listInPersonEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                signUpGroup.SelectedEvent = db.inPersonEvents[key];
            }
            foreach (ListViewItem item in listVirtualEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                signUpGroup.SelectedEvent = db.virtualEvents[key];
            }
            signUpGroup.ShowDialog();
            listUpcomingEventsRefresh();
        }

        private void btnCreateNewGroup_Click(object sender, EventArgs e)
        {
            CreateNewGroupForm createNewGroup = new CreateNewGroupForm();
            createNewGroup.ShowDialog();
            listUserGroupsRefresh();
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which group you would like to join.");
                return;
            }
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (db.userGroups[key].GetMembers().Contains(LogInForm.CurrentUser))
                {
                    MessageBox.Show("You have already joined this group.");
                    return;
                }
                db.userGroups[key].AddMember(LogInForm.CurrentUser);
                listUserGroupsRefresh();
            }
        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which group you would like to leave.");
                return;
            }
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (LogInForm.CurrentUser.UserName == db.userGroups[key].Admin.UserName)
                {
                    MessageBox.Show("You cannot leave this group since you are its administrator.");
                    return;
                }
                if (!db.userGroups[key].GetMembers().Contains(LogInForm.CurrentUser))
                {
                    MessageBox.Show("You have not joined this group yet.");
                }
                db.userGroups[key].RemoveMember(LogInForm.CurrentUser);
                listUserGroupsRefresh();
            }
        }

        private void btnCheckInAtEvent_Click(object sender, EventArgs e)
        {
            if (listUpcomingEvents.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select an upcoming event from the list.");
                return;
            }
            Participant p = null;
            string key;
            foreach (ListViewItem item in listUpcomingEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = db.events[key].FindParticipant(LogInForm.CurrentUser);
            }
            if (p.ctx.CurrentState == LocationSet.Instance)
            {
                p.CheckInAtEvent();
                listUpcomingEventsRefresh();
            }
            else
                MessageBox.Show("You have signed up to a virtual event. Select a location " +
                    "before checking in at the event.");
        }

        private void btnUploadEventResults_Click(object sender, EventArgs e)
        {
            if (listPastEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a past event from the list.");
                return;
            }
            UploadEventResultsForm uploadEventResults = new UploadEventResultsForm();
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                uploadEventResults.SelectedEvent = db.pastEvents[key];
            }

            Participant p = uploadEventResults.SelectedEvent.FindParticipant(LogInForm.CurrentUser);
            if (p.EventResults != null)
            {
                MessageBox.Show("You have already uploaded your results for this event.");
                return;
            }
            if (p.ctx.CurrentState != CheckedIn.Instance)
                MessageBox.Show("Please check in at the event before uploading your results.");
            else
            {
                uploadEventResults.ShowDialog();
                listPastEventsRefresh();
            }
        }

        private void btnEventResults_Click(object sender, EventArgs e)
        {
            if (listPastEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a past event from the list.");
                return;
            }
            SeeEventResultsForm seeEventResults = new SeeEventResultsForm();
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                seeEventResults.SelectedEvent = db.pastEvents[key];
            }
            seeEventResults.ShowDialog();
        }

        private void listUpcomingEventsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Title";
            columnHeader2.Text = "Date and time";
            columnHeader3.Text = "Event Type";
            columnHeader4.Text = "State";

            listUpcomingEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2,
                                                                    columnHeader3,
                                                                    columnHeader4});
            listUpcomingEventsRefresh();
        }

        private void listPastEventsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Title";
            columnHeader2.Text = "Date and time";
            columnHeader3.Text = "Event type";
            columnHeader4.Text = "State";

            listPastEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                             columnHeader2,
                                                             columnHeader3,
                                                             columnHeader4});
            listPastEventsRefresh();
        }

        private void listInPersonEventsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Title";
            columnHeader2.Text = "Date and time";
            columnHeader3.Text = "Average speed";
            columnHeader4.Text = "Location";

            listInPersonEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2,
                                                                    columnHeader3,
                                                                    columnHeader4});
            listInPersonEventsRefresh();
        }

        private void listVirtualEventsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Title";
            columnHeader2.Text = "Date and time";
            columnHeader3.Text = "Average speed";
            columnHeader4.Text = "Route length in km";

            listVirtualEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2,
                                                                    columnHeader3, 
                                                                    columnHeader4});
            listVirtualEventsRefresh();
        }

        private void listGroupsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Group name";
            columnHeader2.Text = "Administrator";
            columnHeader3.Text = "No. of members";
            columnHeader4.Text = "Joined";

            listGroups.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                            columnHeader2,
                                                            columnHeader3,
                                                            columnHeader4});
            listUserGroupsRefresh();
        }

        private void listUpcomingEventsRefresh()
        {
            listUpcomingEvents.Items.Clear();
            string[] upcomingEventElements = new string[4];

            foreach (Event userEvent in db.events.Values)
            {
                Participant p = userEvent.FindParticipant(LogInForm.CurrentUser);
                if (p != null)
                    if (userEvent.DateTime.CompareTo(DateTime.Now) > 0)
                    {
                        String eventType = typeof(InPersonEvent).IsInstanceOfType(userEvent) ? 
                                            "In person" : "Virtual";

                        upcomingEventElements[0] = userEvent.EventTitle;
                        upcomingEventElements[1] = userEvent.DateTime.ToString("dd/MM/yyyy HH:mm");
                        upcomingEventElements[2] = eventType;
                        upcomingEventElements[3] = p.ctx.CurrentState.ToString();

                        ListViewItem row = new ListViewItem(upcomingEventElements);

                        listUpcomingEvents.Items.Add(row);
                    }
            }
            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listPastEventsRefresh()
        {
            listPastEvents.Items.Clear();
            string[] pastEventElements = new string[4];
            foreach (Event userEvent in db.events.Values)
            {
                Participant p = userEvent.FindParticipant(LogInForm.CurrentUser);
                if (p != null)
                    if (!(userEvent.DateTime.CompareTo(DateTime.Now) > 0))
                    {
                        String eventType = typeof(InPersonEvent).IsInstanceOfType(userEvent) ?
                                            "In person" : "Virtual";

                        pastEventElements[0] = userEvent.EventTitle;
                        pastEventElements[1] = userEvent.DateTime.ToString("dd/MM/yyyy HH:mm");
                        pastEventElements[2] = eventType;
                        pastEventElements[3] = p.ctx.CurrentState.ToString();

                        ListViewItem row = new ListViewItem(pastEventElements);

                        listPastEvents.Items.Add(row);
                    }
            }
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listInPersonEventsRefresh()
        {
            listInPersonEvents.Items.Clear();
            string[] InPersonEventElements = new string[4];

            foreach (InPersonEvent item in db.inPersonEvents.Values)
            {
                if (item.DateTime.CompareTo(DateTime.Now) > 0)
                {
                    InPersonEventElements[0] = item.EventTitle;
                    InPersonEventElements[1] = item.DateTime.ToString("dd/MM/yyyy HH:mm");
                    InPersonEventElements[2] = item.AverageSpeed.ToString();
                    InPersonEventElements[3] = item.RunningLocation.ToString();

                    ListViewItem row = new ListViewItem(InPersonEventElements);

                    listInPersonEvents.Items.Add(row);
                }
            }
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listVirtualEventsRefresh()
        {
            listVirtualEvents.Items.Clear();
            string[] virtualEventElements = new string[4];

            foreach (VirtualEvent item in db.virtualEvents.Values)
            {
                if (item.DateTime.CompareTo(DateTime.Now) > 0)
                {
                    virtualEventElements[0] = item.EventTitle;
                    virtualEventElements[1] = item.DateTime.ToString("dd/MM/yyyy HH:mm");
                    virtualEventElements[2] = item.AverageSpeed.ToString();
                    virtualEventElements[3] = item.RouteLength.ToString();

                    ListViewItem row = new ListViewItem(virtualEventElements);

                    listVirtualEvents.Items.Add(row);
                }
            }
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listUserGroupsRefresh()
        {
            listGroups.Items.Clear();
            string[] groupElements = new string[4];

            foreach (UserGroup group in db.userGroups.Values)
            {
                groupElements[0] = group.GroupName;
                groupElements[1] = group.Admin.UserName;
                groupElements[2] = group.Members.Count.ToString();

                if (group.Members.Contains(LogInForm.CurrentUser))
                    groupElements[3] = "Yes";
                else
                    groupElements[3] = "No";

                ListViewItem row = new ListViewItem(groupElements);

                listGroups.Items.Add(row);
            }
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            if (listUpcomingEvents.SelectedItems.Count == 0
                && listPastEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an event to view the details.");
                return;
            }

            EventDetailsForm eventDetails = new EventDetailsForm();
            string key;

            foreach (ListViewItem item in listUpcomingEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                eventDetails.SelectedEvent = db.events[key];
            }
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                eventDetails.SelectedEvent = db.events[key];
            }
            eventDetails.ShowDialog();
            listUpcomingEventsRefresh();
            listPastEventsRefresh();
        }

        private void btnChooseLocation_Click_1(object sender, EventArgs e)
        {

        }
    }
}
