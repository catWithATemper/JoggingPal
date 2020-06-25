namespace JoggingPal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUserArea = new System.Windows.Forms.TabPage();
            this.btnEventResults = new System.Windows.Forms.Button();
            this.btnUploadEventResults = new System.Windows.Forms.Button();
            this.btnCheckInAtEvent = new System.Windows.Forms.Button();
            this.lblPastEvents = new System.Windows.Forms.Label();
            this.listPastEvents = new System.Windows.Forms.ListView();
            this.btnCreateNewEvent = new System.Windows.Forms.Button();
            this.btnFindEvents = new System.Windows.Forms.Button();
            this.btnUserAreaLogOut = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.listUpcomingEvents = new System.Windows.Forms.ListView();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.btnSignUpGroup = new System.Windows.Forms.Button();
            this.btnChooseLocation = new System.Windows.Forms.Button();
            this.lblVirtualEvents = new System.Windows.Forms.Label();
            this.lblInPersonEvents = new System.Windows.Forms.Label();
            this.btnEventsSignUp = new System.Windows.Forms.Button();
            this.listVirtualEvents = new System.Windows.Forms.ListView();
            this.listInPersonEvents = new System.Windows.Forms.ListView();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.btnCreateNewGroup = new System.Windows.Forms.Button();
            this.btnLeaveGroup = new System.Windows.Forms.Button();
            this.btnJoinGroup = new System.Windows.Forms.Button();
            this.lblGroups = new System.Windows.Forms.Label();
            this.listGroups = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabUserArea.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUserArea);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabGroups);
            this.tabControl1.Location = new System.Drawing.Point(-6, -4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 502);
            this.tabControl1.TabIndex = 7;
            // 
            // tabUserArea
            // 
            this.tabUserArea.Controls.Add(this.btnEventResults);
            this.tabUserArea.Controls.Add(this.btnUploadEventResults);
            this.tabUserArea.Controls.Add(this.btnCheckInAtEvent);
            this.tabUserArea.Controls.Add(this.lblPastEvents);
            this.tabUserArea.Controls.Add(this.listPastEvents);
            this.tabUserArea.Controls.Add(this.btnCreateNewEvent);
            this.tabUserArea.Controls.Add(this.btnFindEvents);
            this.tabUserArea.Controls.Add(this.btnUserAreaLogOut);
            this.tabUserArea.Controls.Add(this.lblGreeting);
            this.tabUserArea.Controls.Add(this.lblUpcomingEvents);
            this.tabUserArea.Controls.Add(this.listUpcomingEvents);
            this.tabUserArea.Location = new System.Drawing.Point(4, 25);
            this.tabUserArea.Name = "tabUserArea";
            this.tabUserArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserArea.Size = new System.Drawing.Size(834, 473);
            this.tabUserArea.TabIndex = 1;
            this.tabUserArea.Text = "User area";
            this.tabUserArea.UseVisualStyleBackColor = true;
            // 
            // btnEventResults
            // 
            this.btnEventResults.Location = new System.Drawing.Point(648, 256);
            this.btnEventResults.Name = "btnEventResults";
            this.btnEventResults.Size = new System.Drawing.Size(135, 23);
            this.btnEventResults.TabIndex = 14;
            this.btnEventResults.Text = "See event results";
            this.btnEventResults.UseVisualStyleBackColor = true;
            this.btnEventResults.Click += new System.EventHandler(this.btnEventResults_Click);
            // 
            // btnUploadEventResults
            // 
            this.btnUploadEventResults.Location = new System.Drawing.Point(648, 201);
            this.btnUploadEventResults.Name = "btnUploadEventResults";
            this.btnUploadEventResults.Size = new System.Drawing.Size(154, 24);
            this.btnUploadEventResults.TabIndex = 13;
            this.btnUploadEventResults.Text = "Upload your results";
            this.btnUploadEventResults.UseVisualStyleBackColor = true;
            this.btnUploadEventResults.Click += new System.EventHandler(this.btnUploadEventResults_Click);
            // 
            // btnCheckInAtEvent
            // 
            this.btnCheckInAtEvent.Location = new System.Drawing.Point(648, 155);
            this.btnCheckInAtEvent.Name = "btnCheckInAtEvent";
            this.btnCheckInAtEvent.Size = new System.Drawing.Size(154, 23);
            this.btnCheckInAtEvent.TabIndex = 12;
            this.btnCheckInAtEvent.Text = "Check in at an event";
            this.btnCheckInAtEvent.UseVisualStyleBackColor = true;
            this.btnCheckInAtEvent.Click += new System.EventHandler(this.btnCheckInAtEvent_Click);
            // 
            // lblPastEvents
            // 
            this.lblPastEvents.AutoSize = true;
            this.lblPastEvents.Location = new System.Drawing.Point(30, 225);
            this.lblPastEvents.Name = "lblPastEvents";
            this.lblPastEvents.Size = new System.Drawing.Size(115, 17);
            this.lblPastEvents.TabIndex = 11;
            this.lblPastEvents.Text = "Your past events";
            // 
            // listPastEvents
            // 
            this.listPastEvents.FullRowSelect = true;
            this.listPastEvents.HideSelection = false;
            this.listPastEvents.Location = new System.Drawing.Point(33, 245);
            this.listPastEvents.MultiSelect = false;
            this.listPastEvents.Name = "listPastEvents";
            this.listPastEvents.Size = new System.Drawing.Size(587, 190);
            this.listPastEvents.TabIndex = 10;
            this.listPastEvents.UseCompatibleStateImageBehavior = false;
            this.listPastEvents.View = System.Windows.Forms.View.Details;
            // 
            // btnCreateNewEvent
            // 
            this.btnCreateNewEvent.Location = new System.Drawing.Point(649, 103);
            this.btnCreateNewEvent.Name = "btnCreateNewEvent";
            this.btnCreateNewEvent.Size = new System.Drawing.Size(153, 28);
            this.btnCreateNewEvent.TabIndex = 9;
            this.btnCreateNewEvent.Text = "Create new event";
            this.btnCreateNewEvent.UseVisualStyleBackColor = true;
            this.btnCreateNewEvent.Click += new System.EventHandler(this.btnCreateNewEvent_Click);
            // 
            // btnFindEvents
            // 
            this.btnFindEvents.Location = new System.Drawing.Point(649, 63);
            this.btnFindEvents.Name = "btnFindEvents";
            this.btnFindEvents.Size = new System.Drawing.Size(134, 23);
            this.btnFindEvents.TabIndex = 8;
            this.btnFindEvents.Text = "Find more events";
            this.btnFindEvents.UseVisualStyleBackColor = true;
            this.btnFindEvents.Click += new System.EventHandler(this.btnFindEvents_Click);
            // 
            // btnUserAreaLogOut
            // 
            this.btnUserAreaLogOut.Location = new System.Drawing.Point(649, 412);
            this.btnUserAreaLogOut.Name = "btnUserAreaLogOut";
            this.btnUserAreaLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnUserAreaLogOut.TabIndex = 7;
            this.btnUserAreaLogOut.Text = "Log out";
            this.btnUserAreaLogOut.UseVisualStyleBackColor = true;
            this.btnUserAreaLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(27, 12);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(46, 17);
            this.lblGreeting.TabIndex = 6;
            this.lblGreeting.Text = "label3";
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Location = new System.Drawing.Point(27, 43);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(149, 17);
            this.lblUpcomingEvents.TabIndex = 5;
            this.lblUpcomingEvents.Text = "Your upcoming events";
            // 
            // listUpcomingEvents
            // 
            this.listUpcomingEvents.FullRowSelect = true;
            this.listUpcomingEvents.HideSelection = false;
            this.listUpcomingEvents.Location = new System.Drawing.Point(33, 63);
            this.listUpcomingEvents.MultiSelect = false;
            this.listUpcomingEvents.Name = "listUpcomingEvents";
            this.listUpcomingEvents.Size = new System.Drawing.Size(590, 150);
            this.listUpcomingEvents.TabIndex = 4;
            this.listUpcomingEvents.UseCompatibleStateImageBehavior = false;
            this.listUpcomingEvents.View = System.Windows.Forms.View.Details;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.btnSignUpGroup);
            this.tabEvents.Controls.Add(this.btnChooseLocation);
            this.tabEvents.Controls.Add(this.lblVirtualEvents);
            this.tabEvents.Controls.Add(this.lblInPersonEvents);
            this.tabEvents.Controls.Add(this.btnEventsSignUp);
            this.tabEvents.Controls.Add(this.listVirtualEvents);
            this.tabEvents.Controls.Add(this.listInPersonEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(834, 473);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // btnSignUpGroup
            // 
            this.btnSignUpGroup.Location = new System.Drawing.Point(609, 97);
            this.btnSignUpGroup.Name = "btnSignUpGroup";
            this.btnSignUpGroup.Size = new System.Drawing.Size(141, 23);
            this.btnSignUpGroup.TabIndex = 6;
            this.btnSignUpGroup.Text = "Sign up a group";
            this.btnSignUpGroup.UseVisualStyleBackColor = true;
            this.btnSignUpGroup.Click += new System.EventHandler(this.btnSignUpGroup_Click);
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.Location = new System.Drawing.Point(609, 151);
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.Size = new System.Drawing.Size(130, 23);
            this.btnChooseLocation.TabIndex = 5;
            this.btnChooseLocation.Text = "Choose location";
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.btnChooseLocation_Click);
            // 
            // lblVirtualEvents
            // 
            this.lblVirtualEvents.AutoSize = true;
            this.lblVirtualEvents.Location = new System.Drawing.Point(18, 209);
            this.lblVirtualEvents.Name = "lblVirtualEvents";
            this.lblVirtualEvents.Size = new System.Drawing.Size(94, 17);
            this.lblVirtualEvents.TabIndex = 4;
            this.lblVirtualEvents.Text = "Virtual events";
            // 
            // lblInPersonEvents
            // 
            this.lblInPersonEvents.AutoSize = true;
            this.lblInPersonEvents.Location = new System.Drawing.Point(18, 20);
            this.lblInPersonEvents.Name = "lblInPersonEvents";
            this.lblInPersonEvents.Size = new System.Drawing.Size(113, 17);
            this.lblInPersonEvents.TabIndex = 3;
            this.lblInPersonEvents.Text = "In person events";
            // 
            // btnEventsSignUp
            // 
            this.btnEventsSignUp.Location = new System.Drawing.Point(609, 40);
            this.btnEventsSignUp.Name = "btnEventsSignUp";
            this.btnEventsSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnEventsSignUp.TabIndex = 2;
            this.btnEventsSignUp.Text = "Sign Up";
            this.btnEventsSignUp.UseVisualStyleBackColor = true;
            this.btnEventsSignUp.Click += new System.EventHandler(this.btnEventsSignUp_Click);
            // 
            // listVirtualEvents
            // 
            this.listVirtualEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listVirtualEvents.FullRowSelect = true;
            this.listVirtualEvents.HideSelection = false;
            this.listVirtualEvents.Location = new System.Drawing.Point(20, 232);
            this.listVirtualEvents.MultiSelect = false;
            this.listVirtualEvents.Name = "listVirtualEvents";
            this.listVirtualEvents.Size = new System.Drawing.Size(544, 208);
            this.listVirtualEvents.TabIndex = 1;
            this.listVirtualEvents.UseCompatibleStateImageBehavior = false;
            this.listVirtualEvents.View = System.Windows.Forms.View.Details;
            // 
            // listInPersonEvents
            // 
            this.listInPersonEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listInPersonEvents.FullRowSelect = true;
            this.listInPersonEvents.HideSelection = false;
            this.listInPersonEvents.Location = new System.Drawing.Point(24, 40);
            this.listInPersonEvents.MultiSelect = false;
            this.listInPersonEvents.Name = "listInPersonEvents";
            this.listInPersonEvents.Size = new System.Drawing.Size(544, 151);
            this.listInPersonEvents.TabIndex = 0;
            this.listInPersonEvents.UseCompatibleStateImageBehavior = false;
            this.listInPersonEvents.View = System.Windows.Forms.View.Details;
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.btnCreateNewGroup);
            this.tabGroups.Controls.Add(this.btnLeaveGroup);
            this.tabGroups.Controls.Add(this.btnJoinGroup);
            this.tabGroups.Controls.Add(this.lblGroups);
            this.tabGroups.Controls.Add(this.listGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 25);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(834, 473);
            this.tabGroups.TabIndex = 3;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewGroup
            // 
            this.btnCreateNewGroup.Location = new System.Drawing.Point(580, 161);
            this.btnCreateNewGroup.Name = "btnCreateNewGroup";
            this.btnCreateNewGroup.Size = new System.Drawing.Size(153, 23);
            this.btnCreateNewGroup.TabIndex = 4;
            this.btnCreateNewGroup.Text = "Create a new group";
            this.btnCreateNewGroup.UseVisualStyleBackColor = true;
            this.btnCreateNewGroup.Click += new System.EventHandler(this.btnCreateNewGroup_Click);
            // 
            // btnLeaveGroup
            // 
            this.btnLeaveGroup.Location = new System.Drawing.Point(580, 109);
            this.btnLeaveGroup.Name = "btnLeaveGroup";
            this.btnLeaveGroup.Size = new System.Drawing.Size(124, 23);
            this.btnLeaveGroup.TabIndex = 3;
            this.btnLeaveGroup.Text = "Leave a group";
            this.btnLeaveGroup.UseVisualStyleBackColor = true;
            this.btnLeaveGroup.Click += new System.EventHandler(this.btnLeaveGroup_Click);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Location = new System.Drawing.Point(580, 52);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(124, 23);
            this.btnJoinGroup.TabIndex = 2;
            this.btnJoinGroup.Text = "Join a group";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(32, 6);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(86, 17);
            this.lblGroups.TabIndex = 1;
            this.lblGroups.Text = "User groups";
            // 
            // listGroups
            // 
            this.listGroups.FullRowSelect = true;
            this.listGroups.HideSelection = false;
            this.listGroups.Location = new System.Drawing.Point(35, 26);
            this.listGroups.MultiSelect = false;
            this.listGroups.Name = "listGroups";
            this.listGroups.Size = new System.Drawing.Size(493, 342);
            this.listGroups.TabIndex = 0;
            this.listGroups.UseCompatibleStateImageBehavior = false;
            this.listGroups.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "JoggingPal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUserArea.ResumeLayout(false);
            this.tabUserArea.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUserArea;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.ListView listInPersonEvents;
        private System.Windows.Forms.ListView listVirtualEvents;
        private System.Windows.Forms.Label lblVirtualEvents;
        private System.Windows.Forms.Label lblInPersonEvents;
        private System.Windows.Forms.Button btnEventsSignUp;
        private System.Windows.Forms.Label lblUpcomingEvents;
        private System.Windows.Forms.ListView listUpcomingEvents;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnUserAreaLogOut;
        private System.Windows.Forms.Button btnChooseLocation;
        private System.Windows.Forms.Button btnFindEvents;
        private System.Windows.Forms.ListView listGroups;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Button btnCreateNewEvent;
        private System.Windows.Forms.Button btnSignUpGroup;
        private System.Windows.Forms.Button btnCreateNewGroup;
        private System.Windows.Forms.Button btnLeaveGroup;
        private System.Windows.Forms.Button btnJoinGroup;
        private System.Windows.Forms.Label lblPastEvents;
        private System.Windows.Forms.ListView listPastEvents;
        private System.Windows.Forms.Button btnUploadEventResults;
        private System.Windows.Forms.Button btnCheckInAtEvent;
        private System.Windows.Forms.Button btnEventResults;
    }
}