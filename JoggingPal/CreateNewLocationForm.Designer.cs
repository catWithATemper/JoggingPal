namespace JoggingPal
{
    partial class CreateNewLocationForm
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
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCreateNewLocationOK = new System.Windows.Forms.Button();
            this.btnCreateNewLocationCancel = new System.Windows.Forms.Button();
            this.lblRouteLengthKm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(49, 44);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(198, 22);
            this.txtRouteName.TabIndex = 0;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(49, 103);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(199, 22);
            this.txtLatitude.TabIndex = 1;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(48, 162);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(199, 22);
            this.txtLongitude.TabIndex = 2;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(48, 224);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(198, 22);
            this.txtLength.TabIndex = 3;
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Location = new System.Drawing.Point(46, 24);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(85, 17);
            this.lblRouteName.TabIndex = 4;
            this.lblRouteName.Text = "Route name";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(46, 83);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(59, 17);
            this.lblLatitude.TabIndex = 5;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(46, 142);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(71, 17);
            this.lblLongitude.TabIndex = 6;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(46, 204);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(94, 17);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Route Length";
            // 
            // btnCreateNewLocationOK
            // 
            this.btnCreateNewLocationOK.Location = new System.Drawing.Point(459, 51);
            this.btnCreateNewLocationOK.Name = "btnCreateNewLocationOK";
            this.btnCreateNewLocationOK.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewLocationOK.TabIndex = 8;
            this.btnCreateNewLocationOK.Text = "OK";
            this.btnCreateNewLocationOK.UseVisualStyleBackColor = true;
            this.btnCreateNewLocationOK.Click += new System.EventHandler(this.btnCreateNewLocationOK_Click);
            // 
            // btnCreateNewLocationCancel
            // 
            this.btnCreateNewLocationCancel.Location = new System.Drawing.Point(459, 120);
            this.btnCreateNewLocationCancel.Name = "btnCreateNewLocationCancel";
            this.btnCreateNewLocationCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewLocationCancel.TabIndex = 9;
            this.btnCreateNewLocationCancel.Text = "Cancel";
            this.btnCreateNewLocationCancel.UseVisualStyleBackColor = true;
            // 
            // lblRouteLengthKm
            // 
            this.lblRouteLengthKm.AutoSize = true;
            this.lblRouteLengthKm.Location = new System.Drawing.Point(252, 229);
            this.lblRouteLengthKm.Name = "lblRouteLengthKm";
            this.lblRouteLengthKm.Size = new System.Drawing.Size(26, 17);
            this.lblRouteLengthKm.TabIndex = 10;
            this.lblRouteLengthKm.Text = "km";
            // 
            // CreateNewLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 308);
            this.Controls.Add(this.lblRouteLengthKm);
            this.Controls.Add(this.btnCreateNewLocationCancel);
            this.Controls.Add(this.btnCreateNewLocationOK);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblRouteName);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtRouteName);
            this.Name = "CreateNewLocationForm";
            this.Text = "Create New Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCreateNewLocationOK;
        private System.Windows.Forms.Button btnCreateNewLocationCancel;
        private System.Windows.Forms.Label lblRouteLengthKm;
    }
}