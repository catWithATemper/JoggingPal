using JoggingPal.Models.Users;
using JoggingPal.Db;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class CreateNewGroupForm : Form
    {
        private Database db = Database.Instance();
        public CreateNewGroupForm()
        {
            InitializeComponent();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtUserGroupName.Text;
            if (String.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Please specify a name for the group.");
                return;
            }
            if (db.UserGroups.ContainsKey(groupName))
            {
                MessageBox.Show("A group with this name already exists. Please provide a different title.");
                return;
            }

            UserGroup newGroup = LogInForm.CurrentUser.CreateUserGroup(groupName);
            db.UserGroups.Add(newGroup.GroupName, newGroup);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
