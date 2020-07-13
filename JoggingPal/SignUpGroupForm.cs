using JoggingPal.Models.Events;
using JoggingPal.Models.Users;
using JoggingPal.Db;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class SignUpGroupForm : Form
    {
        private Database db = Database.Instance();

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
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Group name", "Administrator", "No. of members" });

            listGroups.Columns.AddRange(columnHeaders);

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
