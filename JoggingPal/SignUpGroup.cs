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
    public partial class SignUpGroupForm : Form
    {
        Database db = Database.Instance();

        public SignUpGroupForm()
        {
            InitializeComponent();
        }

        public Event SelectedEvent { get; set; }

        private void SignUpGroupForm_Load(object sender, EventArgs e)
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();

            columnHeader1.Text = "Group name";
            columnHeader2.Text = "Administrator";
            columnHeader3.Text = "No. of members";

            listGroups.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                             columnHeader2,
                                                             columnHeader3});

            string[] groupElements = new string[3];

            foreach (UserGroup group in db.userGroups.Values)
            {
                if (LogInForm.CurrentUser.UserName.Equals(group.Admin.UserName))
                {
                    groupElements[0] = group.GroupName;
                    groupElements[1] = group.Admin.UserName;
                    groupElements[2] = group.Members.Count.ToString();

                    ListViewItem row = new ListViewItem(groupElements);

                    listGroups.Items.Add(row);
                }
            }
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a group from the list.");
                return;
            }
            UserGroup selectedGroup;
            Participant participant;
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                selectedGroup = db.userGroups[key];
                foreach (User user in selectedGroup.Members)
                    participant = new Participant(user, SelectedEvent);
            }
            Close();
        }
    }
}
