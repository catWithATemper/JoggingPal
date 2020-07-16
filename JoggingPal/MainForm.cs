using JoggingPal.Models.Events;
using JoggingPal.Models.Participants;
using JoggingPal.Models.ParticipantStates;
using JoggingPal.Models.Users;
using JoggingPal.Db;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace JoggingPal
{
    public partial class MainForm : Form
    {
        private Database db = Database.Instance();

        public MainForm()
        {
            InitializeComponent();
            
            LogInForm logIn = new LogInForm();
            var result = logIn.ShowDialog();
            if (result == DialogResult.Cancel)
                Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + LogInForm.CurrentUser.UserName;

            listUpcomingEventsLoad();
            listPastEventsLoad();
            listInPersonEventsLoad();
            listVirtualEventsLoad();
            listUserGroupsLoad();
        }

        //
        //Tab 1: User area
        //
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
                if (!typeof(VirtualEvent).IsInstanceOfType(db.Events[key]))
                {
                    MessageBox.Show("Choosing a location is only possible for virtual events.");
                    return;
                }
                else
                    browseLocations.SelectedEvent = (VirtualEvent)db.Events[key];
            }
            browseLocations.ShowDialog();
            listUpcomingEventsRefresh();
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
                p = db.Events[key].FindParticipant(LogInForm.CurrentUser);
            }
            if (p.Ctx.CurrentState == CheckedIn.Instance
                || p.Ctx.CurrentState == EventResultsUploaded.Instance)
            {
                MessageBox.Show("You have already checked in at this event.");
                return;
            }
            if (p.Ctx.CurrentState == LocationSet.Instance)
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
                uploadEventResults.SelectedEvent = db.PastEvents[key];
            }

            Participant p = uploadEventResults.SelectedEvent.FindParticipant(LogInForm.CurrentUser);
            if (p.EventResults != null)
            {
                MessageBox.Show("You have already uploaded your results for this event.");
                return;
            }
            if (p.Ctx.CurrentState != CheckedIn.Instance)
                MessageBox.Show("Please check in at the event before uploading your results.");
            else
            {
                uploadEventResults.ShowDialog();
                listPastEventsRefresh();
            }
        }

        private void btnSeeEventResults_Click(object sender, EventArgs e)
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
                seeEventResults.SelectedEvent = db.PastEvents[key];
            }
            seeEventResults.ShowDialog();
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
                eventDetails.SelectedEvent = db.Events[key];
            }
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                eventDetails.SelectedEvent = db.Events[key];
            }
            eventDetails.ShowDialog();
            listUpcomingEventsRefresh();
            listPastEventsRefresh();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listUpcomingEventsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Title", "Date and time", "Event Type", "State"});

            listUpcomingEvents.Columns.AddRange(columnHeaders);

            listUpcomingEventsRefresh();
        }

        private void listPastEventsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Title", "Date and time", "Event Type", "State" });

            listPastEvents.Columns.AddRange(columnHeaders);

            listPastEventsRefresh();
        }

        private void listUpcomingEventsRefresh()
        {
            listUpcomingEvents.Items.Clear();
            string[] upcomingEventElements = new string[4];

            foreach (Event userEvent in db.UpcomingEvents.Values)
            {
                Participant p = userEvent.FindParticipant(LogInForm.CurrentUser);
                if (p != null)
                {
                    String eventType = typeof(InPersonEvent).IsInstanceOfType(userEvent) ?
                                        "In person" : "Virtual";

                    upcomingEventElements[0] = userEvent.EventTitle;
                    upcomingEventElements[1] = userEvent.DateTime.ToString("dd/MM/yyyy HH:mm");
                    upcomingEventElements[2] = eventType;
                    upcomingEventElements[3] = p.Ctx.CurrentState.ToString();

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
            foreach (Event userEvent in db.PastEvents.Values)
            {
                Participant p = userEvent.FindParticipant(LogInForm.CurrentUser);
                if (p != null)
                {
                    String eventType = typeof(InPersonEvent).IsInstanceOfType(userEvent) ?
                                        "In person" : "Virtual";

                    pastEventElements[0] = userEvent.EventTitle;
                    pastEventElements[1] = userEvent.DateTime.ToString("dd/MM/yyyy HH:mm");
                    pastEventElements[2] = eventType;
                    pastEventElements[3] = p.Ctx.CurrentState.ToString();

                    ListViewItem row = new ListViewItem(pastEventElements);

                    listPastEvents.Items.Add(row);
                }
            }
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listUpcomingEvents_Click(object sender, EventArgs e)
        {
            listPastEvents.SelectedItems.Clear();
        }

        private void listPastEvents_Click(object sender, EventArgs e)
        {
            listUpcomingEvents.SelectedItems.Clear();
        }

        //
        //Tab 2: Find events
        //
        private void btnSignUpForEvent_Click(object sender, EventArgs e)
        {
            if (listInPersonEvents.SelectedItems.Count == 0
                && listVirtualEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which event you want to sign up to.");
                return;
            }
            SignUpForEvent(listInPersonEvents.SelectedItems, db.InPersonEvents);
            SignUpForEvent(listVirtualEvents.SelectedItems, db.VirtualEvents);
        }

        private void SignUpForEvent(ListView.SelectedListViewItemCollection selectedItems,
                                Dictionary<String, Event> events)
        {
            foreach (ListViewItem item in selectedItems)
            {
                String key = item.SubItems[0].Text;
                if (events[key].FindParticipant(LogInForm.CurrentUser) != null)
                {
                    MessageBox.Show("You have already signed up for this event.");
                    return;
                }
                else
                {
                    LogInForm.CurrentUser.SignUpForEvent(events[key]);
                    listUpcomingEventsRefresh();
                    MessageBox.Show("You have signed up successfully");
                }
            }
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

            SignUpGroupForEvent(listInPersonEvents.SelectedItems, db.InPersonEvents, signUpGroup);
            SignUpGroupForEvent(listVirtualEvents.SelectedItems, db.VirtualEvents, signUpGroup);
            
            signUpGroup.ShowDialog();
            listUpcomingEventsRefresh();
        }

        private void SignUpGroupForEvent(ListView.SelectedListViewItemCollection selectedItems,
                                        Dictionary<String, Event> events,
                                        SignUpGroupForm signUpGroup)
        {
            foreach (ListViewItem item in selectedItems)
            {
                string key = item.SubItems[0].Text;
                signUpGroup.SelectedEvent = events[key];
            }
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
            CreateNewEventForm createNewEvent = new CreateNewEventForm();
            createNewEvent.ShowDialog();
            listInPersonEventsRefresh();
            listVirtualEventsRefresh();
        }

        private void listInPersonEventsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Title", "Date and time", "Average speed", "Location" });

            listInPersonEvents.Columns.AddRange(columnHeaders);
            listInPersonEventsRefresh();
        }

        private void listVirtualEventsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Title", "Date and time", "Average speed", "Route length" });

            listVirtualEvents.Columns.AddRange(columnHeaders);
            listVirtualEventsRefresh();
        }

        private void listInPersonEventsRefresh()
        {
            listInPersonEvents.Items.Clear();
            string[] InPersonEventElements = new string[4];

            foreach (InPersonEvent item in db.InPersonEvents.Values)
            {
                if (item.DateTime.CompareTo(DateTime.Now) > 0)
                {
                    InPersonEventElements[0] = item.EventTitle;
                    InPersonEventElements[1] = item.DateTime.ToString("dd/MM/yyyy HH:mm");
                    InPersonEventElements[2] = item.AverageSpeed.ToString() + " km/h";
                    InPersonEventElements[3] = item.RunningLocation.ToString() + " km";

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

            foreach (VirtualEvent item in db.VirtualEvents.Values)
            {
                if (item.DateTime.CompareTo(DateTime.Now) > 0)
                {
                    virtualEventElements[0] = item.EventTitle;
                    virtualEventElements[1] = item.DateTime.ToString("dd/MM/yyyy HH:mm");
                    virtualEventElements[2] = item.AverageSpeed.ToString() + " km/h";
                    virtualEventElements[3] = item.RouteLength.ToString() + " km";

                    ListViewItem row = new ListViewItem(virtualEventElements);

                    listVirtualEvents.Items.Add(row);
                }
            }
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listInPersonEvents_Click(object sender, EventArgs e)
        {
            listVirtualEvents.SelectedItems.Clear();
        }

        private void listVirtualEvents_Click(object sender, EventArgs e)
        {
            listInPersonEvents.SelectedItems.Clear();
        }

        //
        //Tab 3: Find groups
        //
        private void btnCreateNewGroup_Click(object sender, EventArgs e)
        {
            CreateNewGroupForm createNewGroup = new CreateNewGroupForm();
            createNewGroup.ShowDialog();
            listUserGroupsRefresh();
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            if (listUserGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which group you would like to join.");
                return;
            }
            foreach (ListViewItem item in listUserGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (db.UserGroups[key].GetMembers().Contains(LogInForm.CurrentUser))
                {
                    MessageBox.Show("You have already joined this group.");
                    return;
                }
                db.UserGroups[key].AddMember(LogInForm.CurrentUser);
                listUserGroupsRefresh();
            }
        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            if (listUserGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select which group you would like to leave.");
                return;
            }
            foreach (ListViewItem item in listUserGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (LogInForm.CurrentUser.UserName == db.UserGroups[key].Admin.UserName)
                {
                    MessageBox.Show("You cannot leave this group since you are its administrator.");
                    return;
                }
                if (!db.UserGroups[key].GetMembers().Contains(LogInForm.CurrentUser))
                {
                    MessageBox.Show("You have not joined this group yet.");
                }
                db.UserGroups[key].RemoveMember(LogInForm.CurrentUser);
                listUserGroupsRefresh();
            }
        }

        private void listUserGroupsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Group name", "Administrator", "No. of members", "Joined" });

            listUserGroups.Columns.AddRange(columnHeaders);
            listUserGroupsRefresh();
        }

        private void listUserGroupsRefresh()
        {
            listUserGroups.Items.Clear();
            string[] groupElements = new string[4];

            foreach (UserGroup group in db.UserGroups.Values)
            {
                groupElements[0] = group.GroupName;
                groupElements[1] = group.Admin.UserName;
                groupElements[2] = group.Members.Count.ToString();

                if (group.Members.Contains(LogInForm.CurrentUser))
                    groupElements[3] = "Yes";
                else
                    groupElements[3] = "No";

                ListViewItem row = new ListViewItem(groupElements);

                listUserGroups.Items.Add(row);
            }
            listUserGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listUserGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
