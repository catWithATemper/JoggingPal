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
            lblGreeting.Text = "Hello " + db.currentUser.UserName;

            //In person events tab Events
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
            string[] InPersonEventElements = new string[4];

            foreach (InPersonEvent item in db.inPersonEvents.Values)
            {
                InPersonEventElements[0] = item.EventTitle;
                InPersonEventElements[1] = item.DateTime.ToString();
                InPersonEventElements[2] = item.AverageSpeed.ToString();
                InPersonEventElements[3] = item.RunningLocation.ToString();

                ListViewItem row = new ListViewItem(InPersonEventElements);

                listInPersonEvents.Items.Add(row);
            }
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Virtual events tab Events
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();
            ColumnHeader columnHeader7 = new ColumnHeader();
            ColumnHeader columnHeader8 = new ColumnHeader();

            columnHeader5.Text = "Title";
            columnHeader6.Text = "Date and time";
            columnHeader7.Text = "Average speed";
            columnHeader8.Text = "Route length in km";

            listVirtualEvents.Columns.AddRange(new ColumnHeader[] { columnHeader5,
                                                                    columnHeader6,
                                                                    columnHeader7,
                                                                    columnHeader8});

            string[] virtualEventElements = new string[4];

            foreach (VirtualEvent item in db.virtualEvents.Values)
            {
                virtualEventElements[0] = item.EventTitle;
                virtualEventElements[1] = item.DateTime.ToString();
                virtualEventElements[2] = item.AverageSpeed.ToString();
                virtualEventElements[3] = item.RouteLength.ToString();

                ListViewItem row = new ListViewItem(virtualEventElements);

                listVirtualEvents.Items.Add(row);
            }
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //User groups tab Groups

            ColumnHeader columnHeader9 = new ColumnHeader();
            ColumnHeader columnHeader10 = new ColumnHeader();
            ColumnHeader columnHeader11 = new ColumnHeader();

            columnHeader9.Text = "Group name";
            columnHeader10.Text = "Administrator";
            columnHeader11.Text = "No. of members";

            listGroups.Columns.AddRange(new ColumnHeader[] { columnHeader9,
                                                             columnHeader10,
                                                             columnHeader11});

            string[] groupElements = new string[3];

            foreach (UserGroup group in db.userGroups.Values)
            {
                groupElements[0] = group.GroupName;
                groupElements[1] = group.Admin.UserName;
                groupElements[2] = group.Members.Count.ToString();

                ListViewItem row = new ListViewItem(groupElements);

                listGroups.Items.Add(row);
            }
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Upcoming events tab User page

            ColumnHeader columnHeader12 = new ColumnHeader();
            ColumnHeader columnHeader13 = new ColumnHeader();
            ColumnHeader columnHeader14 = new ColumnHeader();
            ColumnHeader columnHeader15 = new ColumnHeader();

            columnHeader12.Text = "Title";
            columnHeader13.Text = "Date and time";
            columnHeader14.Text = "Average speed";
            columnHeader15.Text = "State";

            listUpcomingEvents.Columns.AddRange(new ColumnHeader[] { columnHeader12,
                                                                    columnHeader13,
                                                                    columnHeader14,
                                                                    columnHeader15});
            string[] upcomingEventElements = new string[4];

            //Past evebts tab user page

            ColumnHeader columnHeader16 = new ColumnHeader();
            ColumnHeader columnHeader17 = new ColumnHeader();
            ColumnHeader columnHeader18 = new ColumnHeader();
            ColumnHeader columnHeader19 = new ColumnHeader();

            columnHeader16.Text = "Title";
            columnHeader17.Text = "Date and time";
            columnHeader18.Text = "Average speed";
            columnHeader19.Text = "State";

            listPastEvents.Columns.AddRange(new ColumnHeader[] { columnHeader16,
                                                             columnHeader17,
                                                             columnHeader18,
                                                             columnHeader19});

            string[] pastEventElements = new string[4];

            foreach (Event userEvent in db.events.Values)
            {
                if (userEvent.FindParticipant(db.currentUser) != null)
                    if (userEvent.DateTime.CompareTo(DateTime.Now) > 0)
                    {
                        upcomingEventElements[0] = userEvent.EventTitle;
                        upcomingEventElements[1] = userEvent.DateTime.ToString();
                        upcomingEventElements[2] = userEvent.AverageSpeed.ToString();

                        ListViewItem row = new ListViewItem(upcomingEventElements);

                        listUpcomingEvents.Items.Add(row);
                    }
                    else
                    {
                        pastEventElements[0] = userEvent.EventTitle;
                        pastEventElements[1] = userEvent.DateTime.ToString();
                        pastEventElements[2] = userEvent.AverageSpeed.ToString();

                        ListViewItem row = new ListViewItem(pastEventElements);

                        listPastEvents.Items.Add(row);
                    }
            }

            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnEventsSignUp_Click(object sender, EventArgs e)
        {
            Participant p = null;
            string key;
            foreach (ListViewItem item in listInPersonEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = new Participant(db.currentUser, db.inPersonEvents[key]);
            }
            foreach(ListViewItem item in listVirtualEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = new Participant(db.currentUser, db.virtualEvents[key]);
            }
            Console.WriteLine(p.ToString());

            if (p != null)
            {
                UpcomingEventsListRefresh();
                MessageBox.Show("You have signed up successfully");
            }
            else
                MessageBox.Show("Select an event");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            BrowseLocationsForm browseLocations = new BrowseLocationsForm();

            foreach (ListViewItem item in listVirtualEvents.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                browseLocations.SelectedEvent = db.virtualEvents[key];
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

            string[] InPersonEventElements = new string[4];

            foreach (InPersonEvent item in db.inPersonEvents.Values)
            {
                InPersonEventElements[0] = item.EventTitle;
                InPersonEventElements[1] = item.DateTime.ToString();
                InPersonEventElements[2] = item.AverageSpeed.ToString();
                InPersonEventElements[3] = item.RunningLocation.ToString();

                ListViewItem row = new ListViewItem(InPersonEventElements);

                listInPersonEvents.Items.Add(row);
            }
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listInPersonEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            string[] virtualEventElements = new string[4];

            foreach (VirtualEvent item in db.virtualEvents.Values)
            {
                virtualEventElements[0] = item.EventTitle;
                virtualEventElements[1] = item.DateTime.ToString();
                virtualEventElements[2] = item.AverageSpeed.ToString();
                virtualEventElements[3] = item.RouteLength.ToString();

                ListViewItem row = new ListViewItem(virtualEventElements);

                listVirtualEvents.Items.Add(row);
            }
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVirtualEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnSignUpGroup_Click(object sender, EventArgs e)
        {
            SignUpGroupForm signUpGroup = new SignUpGroupForm();
            string key = null;
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
            Console.WriteLine(signUpGroup.SelectedEvent.ToString());

            signUpGroup.ShowDialog();
            UpcomingEventsListRefresh();
        }

        private void UpcomingEventsListRefresh()
        {
            string[] upcomingEventElements = new string[4];
            string[] pastEventElements = new string[4];

            foreach (Event userEvent in db.events.Values)
            {
                if (userEvent.FindParticipant(db.currentUser) != null)
                    if (userEvent.DateTime.CompareTo(DateTime.Now) > 0)
                    {
                        upcomingEventElements[0] = userEvent.EventTitle;
                        upcomingEventElements[1] = userEvent.DateTime.ToString();
                        upcomingEventElements[2] = userEvent.AverageSpeed.ToString();

                        ListViewItem row = new ListViewItem(upcomingEventElements);

                        listUpcomingEvents.Items.Add(row);
                    }
                    else
                    {
                        pastEventElements[0] = userEvent.EventTitle;
                        pastEventElements[1] = userEvent.DateTime.ToString();
                        pastEventElements[2] = userEvent.AverageSpeed.ToString();

                        ListViewItem row = new ListViewItem(pastEventElements);

                        listPastEvents.Items.Add(row);
                    }
            }

            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listUpcomingEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listPastEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            /*
            foreach (UserGroup group in db.userGroups.Values)
                listGroups.Items.Add(group.ToString());
            */

            string[] groupElements = new string[3];

            foreach (UserGroup group in db.userGroups.Values)
            {
                groupElements[0] = group.GroupName;
                groupElements[1] = group.Admin.UserName;
                groupElements[2] = group.Members.Count.ToString();

                ListViewItem row = new ListViewItem(groupElements);

                listGroups.Items.Add(row);
            }
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                db.userGroups[key].AddMember(db.currentUser);
                foreach (User user in db.userGroups[key].GetMembers())
                    Console.WriteLine(user.UserName);
            }
            UserGroupListRefresh();

        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (db.currentUser.UserName != db.userGroups[key].Admin.UserName)
                    db.userGroups[key].RemoveMember(db.currentUser);
                    foreach (User user in db.userGroups[key].GetMembers())
                    Console.WriteLine(user.UserName);
            }
            UserGroupListRefresh();
        }

        private void btnCheckInAtEvent_Click(object sender, EventArgs e)
        {
            Participant p = null;
            string key; 
            foreach (ListViewItem item in listUpcomingEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = db.events[key].FindParticipant(db.currentUser);
            }
            if (p.ctx.CurrentState == LocationSet.Instance)
                p.ctx.CheckInAtEvent();
            Console.WriteLine(p.ctx.CurrentState);      
        }

        private void btnUploadEventResults_Click(object sender, EventArgs e)
        {

            UploadEventResultsForm uploadEventResults = new UploadEventResultsForm();
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                uploadEventResults.SelectedEvent = db.pastEvents[key];
            }
            uploadEventResults.ShowDialog();
        }

        private void btnEventResults_Click(object sender, EventArgs e)
        {
            SeeEventResultsForm seeEventResults = new SeeEventResultsForm();
            foreach (ListViewItem item in listPastEvents.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                seeEventResults.SelectedEvent = db.pastEvents[key];
            }
            seeEventResults.ShowDialog();

        }
    }
}
