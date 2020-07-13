using JoggingPal.Models.Events;
using JoggingPal.Models.Participants;
using JoggingPal.Models.Users;
using JoggingPal.Db;
using System;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a group from the list.");
                return;
            }
            foreach (ListViewItem item in listGroups.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                UserGroup selectedGroup = db.UserGroups[key];

                selectedGroup.SignUpForEvent(SelectedEvent);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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

            foreach (UserGroup group in db.UserGroups.Values)
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
    }
}
