﻿using System;
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
            Participant p = null;
            string key;
            foreach (ListViewItem item in listInPersonEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = new Participant(LogInForm.CurrentUser, db.inPersonEvents[key]);
            }
            foreach (ListViewItem item in listVirtualEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = new Participant(LogInForm.CurrentUser, db.virtualEvents[key]);
            }
            Console.WriteLine(p.ToString());

            if (p != null)
            {
                listUpcomingEventsRefresh();
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
            browseLocations.ShowDialog();
            listUpcomingEventsRefresh();
        }

        private void btnFindEvents_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabEvents);
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
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                db.userGroups[key].AddMember(LogInForm.CurrentUser);
                foreach (User user in db.userGroups[key].GetMembers())
                    Console.WriteLine(user.UserName);
            }
            listUserGroupsRefresh();
        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                if (LogInForm.CurrentUser.UserName != db.userGroups[key].Admin.UserName)
                    db.userGroups[key].RemoveMember(LogInForm.CurrentUser);
                foreach (User user in db.userGroups[key].GetMembers())
                    Console.WriteLine(user.UserName);
            }
            listUserGroupsRefresh();
        }

        private void btnCheckInAtEvent_Click(object sender, EventArgs e)
        {
            Participant p = null;
            string key;
            foreach (ListViewItem item in listUpcomingEvents.SelectedItems)
            {
                key = item.SubItems[0].Text;
                p = db.events[key].FindParticipant(LogInForm.CurrentUser);
            }
            if (p.ctx.CurrentState == LocationSet.Instance)
                p.ctx.CheckInAtEvent();

            listUpcomingEventsRefresh();
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

            Participant p = uploadEventResults.SelectedEvent.FindParticipant(LogInForm.CurrentUser);

            listPastEventsRefresh();
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

        private void listUpcomingEventsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Title";
            columnHeader2.Text = "Date and time";
            columnHeader3.Text = "Average speed";
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
            columnHeader3.Text = "Average speed";
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
            columnHeader3.Text = "Joined";

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
                        upcomingEventElements[0] = userEvent.EventTitle;
                        upcomingEventElements[1] = userEvent.DateTime.ToString();
                        upcomingEventElements[2] = userEvent.AverageSpeed.ToString();
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
                        pastEventElements[0] = userEvent.EventTitle;
                        pastEventElements[1] = userEvent.DateTime.ToString();
                        pastEventElements[2] = userEvent.AverageSpeed.ToString();
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
                InPersonEventElements[0] = item.EventTitle;
                InPersonEventElements[1] = item.DateTime.ToString();
                InPersonEventElements[2] = item.AverageSpeed.ToString();
                InPersonEventElements[3] = item.RunningLocation.ToString();

                ListViewItem row = new ListViewItem(InPersonEventElements);

                listInPersonEvents.Items.Add(row);
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
    }
}
