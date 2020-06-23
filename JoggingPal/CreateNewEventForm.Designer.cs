namespace JoggingPal
{
    partial class CreateNewEventForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAvgSpeed = new System.Windows.Forms.TextBox();
            this.listLocations = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInPersonEvent = new System.Windows.Forms.TabPage();
            this.btnCreateNewLocation = new System.Windows.Forms.Button();
            this.btnCreateNewInPersonEventOK = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAvgSpeed = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tabVirtualEvent = new System.Windows.Forms.TabPage();
            this.btnCreateNewVirtualEventoOk = new System.Windows.Forms.Button();
            this.txtVirtEventAvgSpeed = new System.Windows.Forms.TextBox();
            this.lblVirtEventAvgSpeed = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.txtVirtualEventLength = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabInPersonEvent.SuspendLayout();
            this.tabVirtualEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtAvgSpeed
            // 
            this.txtAvgSpeed.Location = new System.Drawing.Point(35, 198);
            this.txtAvgSpeed.Name = "txtAvgSpeed";
            this.txtAvgSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtAvgSpeed.TabIndex = 2;
            // 
            // listLocations
            // 
            this.listLocations.HideSelection = false;
            this.listLocations.Location = new System.Drawing.Point(316, 67);
            this.listLocations.MultiSelect = false;
            this.listLocations.Name = "listLocations";
            this.listLocations.Size = new System.Drawing.Size(426, 175);
            this.listLocations.TabIndex = 3;
            this.listLocations.UseCompatibleStateImageBehavior = false;
            this.listLocations.View = System.Windows.Forms.View.List;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInPersonEvent);
            this.tabControl1.Controls.Add(this.tabVirtualEvent);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 449);
            this.tabControl1.TabIndex = 4;
            // 
            // tabInPersonEvent
            // 
            this.tabInPersonEvent.Controls.Add(this.btnCreateNewLocation);
            this.tabInPersonEvent.Controls.Add(this.btnCreateNewInPersonEventOK);
            this.tabInPersonEvent.Controls.Add(this.lblLocation);
            this.tabInPersonEvent.Controls.Add(this.lblAvgSpeed);
            this.tabInPersonEvent.Controls.Add(this.lblDateTime);
            this.tabInPersonEvent.Controls.Add(this.listLocations);
            this.tabInPersonEvent.Controls.Add(this.dateTimePicker1);
            this.tabInPersonEvent.Controls.Add(this.txtAvgSpeed);
            this.tabInPersonEvent.Location = new System.Drawing.Point(4, 25);
            this.tabInPersonEvent.Name = "tabInPersonEvent";
            this.tabInPersonEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabInPersonEvent.Size = new System.Drawing.Size(802, 420);
            this.tabInPersonEvent.TabIndex = 0;
            this.tabInPersonEvent.Text = "In person event";
            this.tabInPersonEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewLocation
            // 
            this.btnCreateNewLocation.Location = new System.Drawing.Point(644, 23);
            this.btnCreateNewLocation.Name = "btnCreateNewLocation";
            this.btnCreateNewLocation.Size = new System.Drawing.Size(98, 32);
            this.btnCreateNewLocation.TabIndex = 13;
            this.btnCreateNewLocation.Text = "Create new location";
            this.btnCreateNewLocation.UseVisualStyleBackColor = true;
            this.btnCreateNewLocation.Click += new System.EventHandler(this.btnCreateNewLocation_Click);
            // 
            // btnCreateNewInPersonEventOK
            // 
            this.btnCreateNewInPersonEventOK.Location = new System.Drawing.Point(142, 303);
            this.btnCreateNewInPersonEventOK.Name = "btnCreateNewInPersonEventOK";
            this.btnCreateNewInPersonEventOK.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewInPersonEventOK.TabIndex = 12;
            this.btnCreateNewInPersonEventOK.Text = "Ok";
            this.btnCreateNewInPersonEventOK.UseVisualStyleBackColor = true;
            this.btnCreateNewInPersonEventOK.Click += new System.EventHandler(this.btnCreateNewInPersonEventOK_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(313, 38);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.AutoSize = true;
            this.lblAvgSpeed.Location = new System.Drawing.Point(32, 163);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(104, 17);
            this.lblAvgSpeed.TabIndex = 7;
            this.lblAvgSpeed.Text = "Average speed";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(32, 38);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(96, 17);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "Date and time";
            // 
            // tabVirtualEvent
            // 
            this.tabVirtualEvent.Controls.Add(this.btnCreateNewVirtualEventoOk);
            this.tabVirtualEvent.Controls.Add(this.txtVirtEventAvgSpeed);
            this.tabVirtualEvent.Controls.Add(this.lblVirtEventAvgSpeed);
            this.tabVirtualEvent.Controls.Add(this.lblLength);
            this.tabVirtualEvent.Controls.Add(this.lblDateAndTime);
            this.tabVirtualEvent.Controls.Add(this.txtVirtualEventLength);
            this.tabVirtualEvent.Controls.Add(this.dateTimePicker2);
            this.tabVirtualEvent.Location = new System.Drawing.Point(4, 25);
            this.tabVirtualEvent.Name = "tabVirtualEvent";
            this.tabVirtualEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabVirtualEvent.Size = new System.Drawing.Size(802, 420);
            this.tabVirtualEvent.TabIndex = 1;
            this.tabVirtualEvent.Text = "Virtual event";
            this.tabVirtualEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewVirtualEventoOk
            // 
            this.btnCreateNewVirtualEventoOk.Location = new System.Drawing.Point(204, 302);
            this.btnCreateNewVirtualEventoOk.Name = "btnCreateNewVirtualEventoOk";
            this.btnCreateNewVirtualEventoOk.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewVirtualEventoOk.TabIndex = 21;
            this.btnCreateNewVirtualEventoOk.Text = "OK";
            this.btnCreateNewVirtualEventoOk.UseVisualStyleBackColor = true;
            this.btnCreateNewVirtualEventoOk.Click += new System.EventHandler(this.btnCreateNewVirtualEventoOk_Click);
            // 
            // txtVirtEventAvgSpeed
            // 
            this.txtVirtEventAvgSpeed.Location = new System.Drawing.Point(23, 159);
            this.txtVirtEventAvgSpeed.Name = "txtVirtEventAvgSpeed";
            this.txtVirtEventAvgSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtVirtEventAvgSpeed.TabIndex = 18;
            // 
            // lblVirtEventAvgSpeed
            // 
            this.lblVirtEventAvgSpeed.AutoSize = true;
            this.lblVirtEventAvgSpeed.Location = new System.Drawing.Point(24, 124);
            this.lblVirtEventAvgSpeed.Name = "lblVirtEventAvgSpeed";
            this.lblVirtEventAvgSpeed.Size = new System.Drawing.Size(106, 17);
            this.lblVirtEventAvgSpeed.TabIndex = 17;
            this.lblVirtEventAvgSpeed.Text = "Average Speed";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(24, 213);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(89, 17);
            this.lblLength.TabIndex = 16;
            this.lblLength.Text = "Route length";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(20, 25);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(96, 17);
            this.lblDateAndTime.TabIndex = 14;
            this.lblDateAndTime.Text = "Date and time";
            // 
            // txtVirtualEventLength
            // 
            this.txtVirtualEventLength.Location = new System.Drawing.Point(23, 247);
            this.txtVirtualEventLength.Name = "txtVirtualEventLength";
            this.txtVirtualEventLength.Size = new System.Drawing.Size(100, 22);
            this.txtVirtualEventLength.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // CreateNewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateNewEventForm";
            this.Text = "Create new event";
            this.Load += new System.EventHandler(this.CreateNewEventForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInPersonEvent.ResumeLayout(false);
            this.tabInPersonEvent.PerformLayout();
            this.tabVirtualEvent.ResumeLayout(false);
            this.tabVirtualEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAvgSpeed;
        private System.Windows.Forms.ListView listLocations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInPersonEvent;
        private System.Windows.Forms.TabPage tabVirtualEvent;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAvgSpeed;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.TextBox txtVirtualEventLength;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtVirtEventAvgSpeed;
        private System.Windows.Forms.Label lblVirtEventAvgSpeed;
        private System.Windows.Forms.Button btnCreateNewInPersonEventOK;
        private System.Windows.Forms.Button btnCreateNewVirtualEventoOk;
        private System.Windows.Forms.Button btnCreateNewLocation;
    }
}