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
            foreach (UserGroup item in db.userGroups)
                if (db.currentUser.userName.Equals(item.admin.userName))
                {
                    listGroups.Items.Add(item.ToString());
                    Console.WriteLine(item.ToString());
                }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserGroup selectedGroup;
            Participant participant;
            foreach (int i in listGroups.SelectedIndices)
            {
                selectedGroup = db.userGroups[i];
                foreach (User user in selectedGroup.members)
                {
                    participant = new Participant(user, SelectedEvent);
                    Console.WriteLine(participant.ToString());
                }         
            }
        }
    }
}
