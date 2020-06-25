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
            /*
             for (int i = 0; i < db.users.Count; i++)

                if (txtUsername.Text == db.users[i].UserName &&
                        txtPassword.Text == db.users[i].Password)
                {
                     db.currentUser = db.users[i];
                     MessageBox.Show("You are logged in");
                     this.DialogResult = DialogResult.OK;
                     this.Close();
                }
             */
            string username = txtUsername.Text;
            if (db.users.ContainsKey(username))
                if (txtPassword.Text == db.users[username].Password)
                {
                    //db.currentUser = db.users[i];
                    MessageBox.Show("You are logged in");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            
        }
    }
}
