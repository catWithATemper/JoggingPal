﻿namespace JoggingPal
{
    partial class BrowseLocationsForm
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
            this.listLocations = new System.Windows.Forms.ListView();
            this.btnChooseLocationOK = new System.Windows.Forms.Button();
            this.btnChooseLocationCancel = new System.Windows.Forms.Button();
            this.btnCreateNewLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLocations
            // 
            this.listLocations.HideSelection = false;
            this.listLocations.Location = new System.Drawing.Point(31, 41);
            this.listLocations.Name = "listLocations";
            this.listLocations.Size = new System.Drawing.Size(426, 175);
            this.listLocations.TabIndex = 0;
            this.listLocations.UseCompatibleStateImageBehavior = false;
            this.listLocations.View = System.Windows.Forms.View.List;
            // 
            // btnChooseLocationOK
            // 
            this.btnChooseLocationOK.Location = new System.Drawing.Point(42, 256);
            this.btnChooseLocationOK.Name = "btnChooseLocationOK";
            this.btnChooseLocationOK.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLocationOK.TabIndex = 1;
            this.btnChooseLocationOK.Text = "ok";
            this.btnChooseLocationOK.UseVisualStyleBackColor = true;
            this.btnChooseLocationOK.Click += new System.EventHandler(this.btnChooseLocationOK_Click);
            // 
            // btnChooseLocationCancel
            // 
            this.btnChooseLocationCancel.Location = new System.Drawing.Point(319, 256);
            this.btnChooseLocationCancel.Name = "btnChooseLocationCancel";
            this.btnChooseLocationCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLocationCancel.TabIndex = 2;
            this.btnChooseLocationCancel.Text = "Cancel";
            this.btnChooseLocationCancel.UseVisualStyleBackColor = true;
            this.btnChooseLocationCancel.Click += new System.EventHandler(this.btnChooseLocationCancel_Click);
            // 
            // btnCreateNewLocation
            // 
            this.btnCreateNewLocation.Location = new System.Drawing.Point(496, 52);
            this.btnCreateNewLocation.Name = "btnCreateNewLocation";
            this.btnCreateNewLocation.Size = new System.Drawing.Size(75, 69);
            this.btnCreateNewLocation.TabIndex = 3;
            this.btnCreateNewLocation.Text = "Create new location";
            this.btnCreateNewLocation.UseVisualStyleBackColor = true;
            this.btnCreateNewLocation.Click += new System.EventHandler(this.btnCreateNewLocation_Click);
            // 
            // BrowseLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 335);
            this.Controls.Add(this.btnCreateNewLocation);
            this.Controls.Add(this.btnChooseLocationCancel);
            this.Controls.Add(this.btnChooseLocationOK);
            this.Controls.Add(this.listLocations);
            this.Name = "BrowseLocationsForm";
            this.Text = "Browse Locations";
            this.Load += new System.EventHandler(this.BrowseLocationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listLocations;
        private System.Windows.Forms.Button btnChooseLocationOK;
        private System.Windows.Forms.Button btnChooseLocationCancel;
        private System.Windows.Forms.Button btnCreateNewLocation;
    }
}