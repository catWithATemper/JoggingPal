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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string username = txtUsername.Text;
            if (db.users.ContainsKey(username))
                if (txtPassword.Text == db.users[username].Password)
                {
                    CurrentUser = db.users[username];
                    MessageBox.Show("You are logged in");
                    DialogResult = DialogResult.OK;
                    Close();
                }   
        }
    }
}
