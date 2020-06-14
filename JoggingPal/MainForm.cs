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
    public partial class MainForm : Form
    {
        Database db = Database.Instance();

        public MainForm()
        {
            InitializeComponent();
            
            LogInForm logIn = new LogInForm();
            var result = logIn.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Event item in db.events)
            {
                if (typeof(InPersonEvent).IsInstanceOfType(item))
                    listView1.Items.Add(item.ToString());
                    //textBox3.Text = (item.ToString() + "\n");
                else
                    listView2.Items.Add(item.ToString());
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Participant p = null;
            foreach (int i in listView1.SelectedIndices)
            {
                p = new Participant(db.users[1], db.events[i]);
            }
            foreach(int i in listView2.SelectedIndices)
            {
                p = new Participant(db.users[1], db.events[i]);
            }
            if (p != null)
                listView3.Items.Add(p.ToString());
        }
    }
}
