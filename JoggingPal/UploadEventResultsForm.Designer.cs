namespace JoggingPal
{
    partial class UploadEventResultsForm
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
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.txtAvgHeartRate = new System.Windows.Forms.TextBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.lblAvgHeartRate = new System.Windows.Forms.Label();
            this.btnUploadResults = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMaxSpeedKmh = new System.Windows.Forms.Label();
            this.lblAvgBpm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(36, 67);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(142, 22);
            this.txtTotalTime.TabIndex = 0;
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(35, 134);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(141, 22);
            this.txtMaxSpeed.TabIndex = 1;
            // 
            // txtAvgHeartRate
            // 
            this.txtAvgHeartRate.Location = new System.Drawing.Point(34, 200);
            this.txtAvgHeartRate.Name = "txtAvgHeartRate";
            this.txtAvgHeartRate.Size = new System.Drawing.Size(142, 22);
            this.txtAvgHeartRate.TabIndex = 2;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(33, 38);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(70, 17);
            this.lblTotalTime.TabIndex = 3;
            this.lblTotalTime.Text = "Total time";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(33, 114);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(109, 17);
            this.lblMaxSpeed.TabIndex = 4;
            this.lblMaxSpeed.Text = "Maximum speed";
            // 
            // lblAvgHeartRate
            // 
            this.lblAvgHeartRate.AutoSize = true;
            this.lblAvgHeartRate.Location = new System.Drawing.Point(33, 180);
            this.lblAvgHeartRate.Name = "lblAvgHeartRate";
            this.lblAvgHeartRate.Size = new System.Drawing.Size(134, 17);
            this.lblAvgHeartRate.TabIndex = 5;
            this.lblAvgHeartRate.Text = "Average Heart Rate";
            // 
            // btnUploadResults
            // 
            this.btnUploadResults.Location = new System.Drawing.Point(278, 38);
            this.btnUploadResults.Name = "btnUploadResults";
            this.btnUploadResults.Size = new System.Drawing.Size(125, 25);
            this.btnUploadResults.TabIndex = 6;
            this.btnUploadResults.Text = "Upload results";
            this.btnUploadResults.UseVisualStyleBackColor = true;
            this.btnUploadResults.Click += new System.EventHandler(this.btnUploadResults_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(184, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 17);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "hh:mm:ss";
            // 
            // lblMaxSpeedKmh
            // 
            this.lblMaxSpeedKmh.AutoSize = true;
            this.lblMaxSpeedKmh.Location = new System.Drawing.Point(184, 139);
            this.lblMaxSpeedKmh.Name = "lblMaxSpeedKmh";
            this.lblMaxSpeedKmh.Size = new System.Drawing.Size(38, 17);
            this.lblMaxSpeedKmh.TabIndex = 8;
            this.lblMaxSpeedKmh.Text = "km/h";
            // 
            // lblAvgBpm
            // 
            this.lblAvgBpm.AutoSize = true;
            this.lblAvgBpm.Location = new System.Drawing.Point(184, 205);
            this.lblAvgBpm.Name = "lblAvgBpm";
            this.lblAvgBpm.Size = new System.Drawing.Size(35, 17);
            this.lblAvgBpm.TabIndex = 9;
            this.lblAvgBpm.Text = "bpm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UploadEventResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvgBpm);
            this.Controls.Add(this.lblMaxSpeedKmh);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnUploadResults);
            this.Controls.Add(this.lblAvgHeartRate);
            this.Controls.Add(this.lblMaxSpeed);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.txtAvgHeartRate);
            this.Controls.Add(this.txtMaxSpeed);
            this.Controls.Add(this.txtTotalTime);
            this.Name = "UploadEventResultsForm";
            this.Text = "Upload event results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.TextBox txtAvgHeartRate;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label lblAvgHeartRate;
        private System.Windows.Forms.Button btnUploadResults;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMaxSpeedKmh;
        private System.Windows.Forms.Label lblAvgBpm;
        private System.Windows.Forms.Button button1;
    }
}