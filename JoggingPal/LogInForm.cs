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
            //this.ShowDialog();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
           textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < db.users.Count; i++)

               if (textBox1.Text == db.users[i].userName &&
                       textBox2.Text == db.users[i].password)
               {
                   MessageBox.Show("You are logged in");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                  
               }
        }

        /*
        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        */

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            /*
            try 
            {
                var button = sender as Button;
                var buttonName = button.Name;
                if (string.Equals((sender as Button).Name, @"CloseButton"))
                    Application.Exit();
                // Do something proper to CloseButton.
                else
                { }
            }
            catch
            {
                Console.WriteLine("Exception");
            }

        // Then assume that X has been clicked and act accordingly.
        */
        }
    }
}
