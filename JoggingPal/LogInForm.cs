using JoggingPal.Models.Users;
using JoggingPal.Db;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class LogInForm : Form
    {
        public static User CurrentUser { get; set; }

        Database db = Database.Instance();
        public LogInForm()
        {
            InitializeComponent();
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (db.Users.ContainsKey(username))
                if (txtPassword.Text == db.Users[username].Password)
                {
                    CurrentUser = db.Users[username];
                    MessageBox.Show("You are logged in");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username and password do not match.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
        }
    }
}
