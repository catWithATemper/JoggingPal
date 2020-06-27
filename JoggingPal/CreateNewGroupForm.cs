﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class CreateNewGroupForm : Form
    {
        Database db = Database.Instance();
        public CreateNewGroupForm()
        {
            InitializeComponent();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            UserGroup newGroup = new UserGroup(LogInForm.CurrentUser, txtUserGroupNAme.Text);
            db.userGroups.Add(newGroup.GroupName, newGroup);
            Console.WriteLine(newGroup.ToString());
            this.Close();
        }
    }
}
