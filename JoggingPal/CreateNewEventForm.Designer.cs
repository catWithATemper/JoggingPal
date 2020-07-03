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
            this.txtAvgSpeedTab1 = new System.Windows.Forms.TextBox();
            this.listLocations = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInPersonEvent = new System.Windows.Forms.TabPage();
            this.btnCancelTab1 = new System.Windows.Forms.Button();
            this.lblAvgSpeedKmhTab1 = new System.Windows.Forms.Label();
            this.txtEventTitleTab1 = new System.Windows.Forms.TextBox();
            this.lblEventTitleTab1 = new System.Windows.Forms.Label();
            this.btnCreateNewLocation = new System.Windows.Forms.Button();
            this.btnCreateNewInPersonEventOK = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAvgSpeedTab1 = new System.Windows.Forms.Label();
            this.lblDateAndTimeTab1 = new System.Windows.Forms.Label();
            this.tabVirtualEvent = new System.Windows.Forms.TabPage();
            this.btnCancelTab2 = new System.Windows.Forms.Button();
            this.lblAvgSpeedKmhTab2 = new System.Windows.Forms.Label();
            this.txtEventTitleTab2 = new System.Windows.Forms.TextBox();
            this.lblEventTitleTab2 = new System.Windows.Forms.Label();
            this.btnCreateNewVirtualEventoOk = new System.Windows.Forms.Button();
            this.txtAvgSpeedTab2 = new System.Windows.Forms.TextBox();
            this.lblAvgSpeedTab2 = new System.Windows.Forms.Label();
            this.lblLengthTab1 = new System.Windows.Forms.Label();
            this.lblDateAndTimeTab2 = new System.Windows.Forms.Label();
            this.txtLengthTab2 = new System.Windows.Forms.TextBox();
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
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtAvgSpeedTab1
            // 
            this.txtAvgSpeedTab1.Location = new System.Drawing.Point(35, 136);
            this.txtAvgSpeedTab1.Name = "txtAvgSpeedTab1";
            this.txtAvgSpeedTab1.Size = new System.Drawing.Size(100, 22);
            this.txtAvgSpeedTab1.TabIndex = 2;
            // 
            // listLocations
            // 
            this.listLocations.FullRowSelect = true;
            this.listLocations.HideSelection = false;
            this.listLocations.Location = new System.Drawing.Point(262, 61);
            this.listLocations.MultiSelect = false;
            this.listLocations.Name = "listLocations";
            this.listLocations.Size = new System.Drawing.Size(480, 175);
            this.listLocations.TabIndex = 3;
            this.listLocations.UseCompatibleStateImageBehavior = false;
            this.listLocations.View = System.Windows.Forms.View.Details;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInPersonEvent);
            this.tabControl1.Controls.Add(this.tabVirtualEvent);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 479);
            this.tabControl1.TabIndex = 4;
            // 
            // tabInPersonEvent
            // 
            this.tabInPersonEvent.Controls.Add(this.btnCancelTab1);
            this.tabInPersonEvent.Controls.Add(this.lblAvgSpeedKmhTab1);
            this.tabInPersonEvent.Controls.Add(this.txtEventTitleTab1);
            this.tabInPersonEvent.Controls.Add(this.lblEventTitleTab1);
            this.tabInPersonEvent.Controls.Add(this.btnCreateNewLocation);
            this.tabInPersonEvent.Controls.Add(this.btnCreateNewInPersonEventOK);
            this.tabInPersonEvent.Controls.Add(this.lblLocation);
            this.tabInPersonEvent.Controls.Add(this.lblAvgSpeedTab1);
            this.tabInPersonEvent.Controls.Add(this.lblDateAndTimeTab1);
            this.tabInPersonEvent.Controls.Add(this.listLocations);
            this.tabInPersonEvent.Controls.Add(this.dateTimePicker1);
            this.tabInPersonEvent.Controls.Add(this.txtAvgSpeedTab1);
            this.tabInPersonEvent.Location = new System.Drawing.Point(4, 25);
            this.tabInPersonEvent.Name = "tabInPersonEvent";
            this.tabInPersonEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabInPersonEvent.Size = new System.Drawing.Size(802, 450);
            this.tabInPersonEvent.TabIndex = 0;
            this.tabInPersonEvent.Text = "In person event";
            this.tabInPersonEvent.UseVisualStyleBackColor = true;
            // 
            // btnCancelTab1
            // 
            this.btnCancelTab1.Location = new System.Drawing.Point(376, 341);
            this.btnCancelTab1.Name = "btnCancelTab1";
            this.btnCancelTab1.Size = new System.Drawing.Size(75, 25);
            this.btnCancelTab1.TabIndex = 17;
            this.btnCancelTab1.Text = "Cancel";
            this.btnCancelTab1.UseVisualStyleBackColor = true;
            this.btnCancelTab1.Click += new System.EventHandler(this.btnCancelTab1_Click);
            // 
            // lblAvgSpeedKmhTab1
            // 
            this.lblAvgSpeedKmhTab1.AutoSize = true;
            this.lblAvgSpeedKmhTab1.Location = new System.Drawing.Point(147, 141);
            this.lblAvgSpeedKmhTab1.Name = "lblAvgSpeedKmhTab1";
            this.lblAvgSpeedKmhTab1.Size = new System.Drawing.Size(38, 17);
            this.lblAvgSpeedKmhTab1.TabIndex = 16;
            this.lblAvgSpeedKmhTab1.Text = "km/h";
            // 
            // txtEventTitleTab1
            // 
            this.txtEventTitleTab1.Location = new System.Drawing.Point(35, 205);
            this.txtEventTitleTab1.Name = "txtEventTitleTab1";
            this.txtEventTitleTab1.Size = new System.Drawing.Size(100, 22);
            this.txtEventTitleTab1.TabIndex = 15;
            // 
            // lblEventTitleTab1
            // 
            this.lblEventTitleTab1.AutoSize = true;
            this.lblEventTitleTab1.Location = new System.Drawing.Point(33, 185);
            this.lblEventTitleTab1.Name = "lblEventTitleTab1";
            this.lblEventTitleTab1.Size = new System.Drawing.Size(70, 17);
            this.lblEventTitleTab1.TabIndex = 14;
            this.lblEventTitleTab1.Text = "Event title";
            // 
            // btnCreateNewLocation
            // 
            this.btnCreateNewLocation.Location = new System.Drawing.Point(569, 23);
            this.btnCreateNewLocation.Name = "btnCreateNewLocation";
            this.btnCreateNewLocation.Size = new System.Drawing.Size(173, 32);
            this.btnCreateNewLocation.TabIndex = 13;
            this.btnCreateNewLocation.Text = "Create new location";
            this.btnCreateNewLocation.UseVisualStyleBackColor = true;
            this.btnCreateNewLocation.Click += new System.EventHandler(this.btnCreateNewLocation_Click);
            // 
            // btnCreateNewInPersonEventOK
            // 
            this.btnCreateNewInPersonEventOK.Location = new System.Drawing.Point(144, 345);
            this.btnCreateNewInPersonEventOK.Name = "btnCreateNewInPersonEventOK";
            this.btnCreateNewInPersonEventOK.Size = new System.Drawing.Size(75, 25);
            this.btnCreateNewInPersonEventOK.TabIndex = 12;
            this.btnCreateNewInPersonEventOK.Text = "Ok";
            this.btnCreateNewInPersonEventOK.UseVisualStyleBackColor = true;
            this.btnCreateNewInPersonEventOK.Click += new System.EventHandler(this.btnCreateNewInPersonEventOK_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(259, 38);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // lblAvgSpeedTab1
            // 
            this.lblAvgSpeedTab1.AutoSize = true;
            this.lblAvgSpeedTab1.Location = new System.Drawing.Point(33, 116);
            this.lblAvgSpeedTab1.Name = "lblAvgSpeedTab1";
            this.lblAvgSpeedTab1.Size = new System.Drawing.Size(104, 17);
            this.lblAvgSpeedTab1.TabIndex = 7;
            this.lblAvgSpeedTab1.Text = "Average speed";
            // 
            // lblDateAndTimeTab1
            // 
            this.lblDateAndTimeTab1.AutoSize = true;
            this.lblDateAndTimeTab1.Location = new System.Drawing.Point(32, 38);
            this.lblDateAndTimeTab1.Name = "lblDateAndTimeTab1";
            this.lblDateAndTimeTab1.Size = new System.Drawing.Size(96, 17);
            this.lblDateAndTimeTab1.TabIndex = 6;
            this.lblDateAndTimeTab1.Text = "Date and time";
            // 
            // tabVirtualEvent
            // 
            this.tabVirtualEvent.Controls.Add(this.btnCancelTab2);
            this.tabVirtualEvent.Controls.Add(this.lblAvgSpeedKmhTab2);
            this.tabVirtualEvent.Controls.Add(this.txtEventTitleTab2);
            this.tabVirtualEvent.Controls.Add(this.lblEventTitleTab2);
            this.tabVirtualEvent.Controls.Add(this.btnCreateNewVirtualEventoOk);
            this.tabVirtualEvent.Controls.Add(this.txtAvgSpeedTab2);
            this.tabVirtualEvent.Controls.Add(this.lblAvgSpeedTab2);
            this.tabVirtualEvent.Controls.Add(this.lblLengthTab1);
            this.tabVirtualEvent.Controls.Add(this.lblDateAndTimeTab2);
            this.tabVirtualEvent.Controls.Add(this.txtLengthTab2);
            this.tabVirtualEvent.Controls.Add(this.dateTimePicker2);
            this.tabVirtualEvent.Location = new System.Drawing.Point(4, 25);
            this.tabVirtualEvent.Name = "tabVirtualEvent";
            this.tabVirtualEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabVirtualEvent.Size = new System.Drawing.Size(802, 450);
            this.tabVirtualEvent.TabIndex = 1;
            this.tabVirtualEvent.Text = "Virtual event";
            this.tabVirtualEvent.UseVisualStyleBackColor = true;
            // 
            // btnCancelTab2
            // 
            this.btnCancelTab2.Location = new System.Drawing.Point(462, 360);
            this.btnCancelTab2.Name = "btnCancelTab2";
            this.btnCancelTab2.Size = new System.Drawing.Size(75, 25);
            this.btnCancelTab2.TabIndex = 25;
            this.btnCancelTab2.Text = "Cancel";
            this.btnCancelTab2.UseVisualStyleBackColor = true;
            this.btnCancelTab2.Click += new System.EventHandler(this.btnCancelTab2_Click);
            // 
            // lblAvgSpeedKmhTab2
            // 
            this.lblAvgSpeedKmhTab2.AutoSize = true;
            this.lblAvgSpeedKmhTab2.Location = new System.Drawing.Point(135, 164);
            this.lblAvgSpeedKmhTab2.Name = "lblAvgSpeedKmhTab2";
            this.lblAvgSpeedKmhTab2.Size = new System.Drawing.Size(38, 17);
            this.lblAvgSpeedKmhTab2.TabIndex = 24;
            this.lblAvgSpeedKmhTab2.Text = "km/h";
            // 
            // txtEventTitleTab2
            // 
            this.txtEventTitleTab2.Location = new System.Drawing.Point(32, 231);
            this.txtEventTitleTab2.Name = "txtEventTitleTab2";
            this.txtEventTitleTab2.Size = new System.Drawing.Size(100, 22);
            this.txtEventTitleTab2.TabIndex = 23;
            // 
            // lblEventTitleTab2
            // 
            this.lblEventTitleTab2.AutoSize = true;
            this.lblEventTitleTab2.Location = new System.Drawing.Point(29, 211);
            this.lblEventTitleTab2.Name = "lblEventTitleTab2";
            this.lblEventTitleTab2.Size = new System.Drawing.Size(70, 17);
            this.lblEventTitleTab2.TabIndex = 22;
            this.lblEventTitleTab2.Text = "Event title";
            // 
            // btnCreateNewVirtualEventoOk
            // 
            this.btnCreateNewVirtualEventoOk.Location = new System.Drawing.Point(200, 360);
            this.btnCreateNewVirtualEventoOk.Name = "btnCreateNewVirtualEventoOk";
            this.btnCreateNewVirtualEventoOk.Size = new System.Drawing.Size(75, 25);
            this.btnCreateNewVirtualEventoOk.TabIndex = 21;
            this.btnCreateNewVirtualEventoOk.Text = "OK";
            this.btnCreateNewVirtualEventoOk.UseVisualStyleBackColor = true;
            this.btnCreateNewVirtualEventoOk.Click += new System.EventHandler(this.btnCreateNewVirtualEventoOk_Click);
            // 
            // txtAvgSpeedTab2
            // 
            this.txtAvgSpeedTab2.Location = new System.Drawing.Point(23, 159);
            this.txtAvgSpeedTab2.Name = "txtAvgSpeedTab2";
            this.txtAvgSpeedTab2.Size = new System.Drawing.Size(100, 22);
            this.txtAvgSpeedTab2.TabIndex = 18;
            // 
            // lblAvgSpeedTab2
            // 
            this.lblAvgSpeedTab2.AutoSize = true;
            this.lblAvgSpeedTab2.Location = new System.Drawing.Point(24, 124);
            this.lblAvgSpeedTab2.Name = "lblAvgSpeedTab2";
            this.lblAvgSpeedTab2.Size = new System.Drawing.Size(106, 17);
            this.lblAvgSpeedTab2.TabIndex = 17;
            this.lblAvgSpeedTab2.Text = "Average Speed";
            // 
            // lblLengthTab1
            // 
            this.lblLengthTab1.AutoSize = true;
            this.lblLengthTab1.Location = new System.Drawing.Point(20, 285);
            this.lblLengthTab1.Name = "lblLengthTab1";
            this.lblLengthTab1.Size = new System.Drawing.Size(89, 17);
            this.lblLengthTab1.TabIndex = 16;
            this.lblLengthTab1.Text = "Route length";
            // 
            // lblDateAndTimeTab2
            // 
            this.lblDateAndTimeTab2.AutoSize = true;
            this.lblDateAndTimeTab2.Location = new System.Drawing.Point(20, 25);
            this.lblDateAndTimeTab2.Name = "lblDateAndTimeTab2";
            this.lblDateAndTimeTab2.Size = new System.Drawing.Size(96, 17);
            this.lblDateAndTimeTab2.TabIndex = 14;
            this.lblDateAndTimeTab2.Text = "Date and time";
            // 
            // txtLengthTab2
            // 
            this.txtLengthTab2.Location = new System.Drawing.Point(23, 305);
            this.txtLengthTab2.Name = "txtLengthTab2";
            this.txtLengthTab2.Size = new System.Drawing.Size(100, 22);
            this.txtLengthTab2.TabIndex = 12;
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
            this.ClientSize = new System.Drawing.Size(803, 475);
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
        private System.Windows.Forms.TextBox txtAvgSpeedTab1;
        private System.Windows.Forms.ListView listLocations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInPersonEvent;
        private System.Windows.Forms.TabPage tabVirtualEvent;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAvgSpeedTab1;
        private System.Windows.Forms.Label lblDateAndTimeTab1;
        private System.Windows.Forms.Label lblLengthTab1;
        private System.Windows.Forms.Label lblDateAndTimeTab2;
        private System.Windows.Forms.TextBox txtLengthTab2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtAvgSpeedTab2;
        private System.Windows.Forms.Label lblAvgSpeedTab2;
        private System.Windows.Forms.Button btnCreateNewInPersonEventOK;
        private System.Windows.Forms.Button btnCreateNewVirtualEventoOk;
        private System.Windows.Forms.Button btnCreateNewLocation;
        private System.Windows.Forms.TextBox txtEventTitleTab1;
        private System.Windows.Forms.Label lblEventTitleTab1;
        private System.Windows.Forms.Label lblEventTitleTab2;
        private System.Windows.Forms.TextBox txtEventTitleTab2;
        private System.Windows.Forms.Label lblAvgSpeedKmhTab1;
        private System.Windows.Forms.Label lblAvgSpeedKmhTab2;
        private System.Windows.Forms.Button btnCancelTab1;
        private System.Windows.Forms.Button btnCancelTab2;
    }
}