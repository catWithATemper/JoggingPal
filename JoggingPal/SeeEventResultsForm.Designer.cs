namespace JoggingPal
{
    partial class SeeEventResultsForm
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
            this.tabAvgSpeed = new System.Windows.Forms.TabPage();
            this.tabMaxSpeed = new System.Windows.Forms.TabPage();
            this.tabAvgHeartRate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAverageSpeed = new System.Windows.Forms.ListView();
            this.listMaxSpeed = new System.Windows.Forms.ListView();
            this.listAvgHeartRate = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabAvgSpeed.SuspendLayout();
            this.tabMaxSpeed.SuspendLayout();
            this.tabAvgHeartRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAvgSpeed);
            this.tabControl1.Controls.Add(this.tabMaxSpeed);
            this.tabControl1.Controls.Add(this.tabAvgHeartRate);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAvgSpeed
            // 
            this.tabAvgSpeed.Controls.Add(this.listAverageSpeed);
            this.tabAvgSpeed.Controls.Add(this.label1);
            this.tabAvgSpeed.Location = new System.Drawing.Point(4, 25);
            this.tabAvgSpeed.Name = "tabAvgSpeed";
            this.tabAvgSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvgSpeed.Size = new System.Drawing.Size(687, 298);
            this.tabAvgSpeed.TabIndex = 0;
            this.tabAvgSpeed.Text = "Average speed";
            this.tabAvgSpeed.UseVisualStyleBackColor = true;
            // 
            // tabMaxSpeed
            // 
            this.tabMaxSpeed.Controls.Add(this.listMaxSpeed);
            this.tabMaxSpeed.Controls.Add(this.label2);
            this.tabMaxSpeed.Location = new System.Drawing.Point(4, 25);
            this.tabMaxSpeed.Name = "tabMaxSpeed";
            this.tabMaxSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaxSpeed.Size = new System.Drawing.Size(687, 298);
            this.tabMaxSpeed.TabIndex = 1;
            this.tabMaxSpeed.Text = "Maximum speed";
            this.tabMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // tabAvgHeartRate
            // 
            this.tabAvgHeartRate.Controls.Add(this.listAvgHeartRate);
            this.tabAvgHeartRate.Controls.Add(this.label3);
            this.tabAvgHeartRate.Location = new System.Drawing.Point(4, 25);
            this.tabAvgHeartRate.Name = "tabAvgHeartRate";
            this.tabAvgHeartRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvgHeartRate.Size = new System.Drawing.Size(687, 298);
            this.tabAvgHeartRate.TabIndex = 2;
            this.tabAvgHeartRate.Text = "Average heart rate";
            this.tabAvgHeartRate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // listAverageSpeed
            // 
            this.listAverageSpeed.HideSelection = false;
            this.listAverageSpeed.Location = new System.Drawing.Point(13, 57);
            this.listAverageSpeed.Name = "listAverageSpeed";
            this.listAverageSpeed.Size = new System.Drawing.Size(626, 220);
            this.listAverageSpeed.TabIndex = 1;
            this.listAverageSpeed.UseCompatibleStateImageBehavior = false;
            this.listAverageSpeed.View = System.Windows.Forms.View.List;
            // 
            // listMaxSpeed
            // 
            this.listMaxSpeed.HideSelection = false;
            this.listMaxSpeed.Location = new System.Drawing.Point(24, 49);
            this.listMaxSpeed.Name = "listMaxSpeed";
            this.listMaxSpeed.Size = new System.Drawing.Size(597, 210);
            this.listMaxSpeed.TabIndex = 1;
            this.listMaxSpeed.UseCompatibleStateImageBehavior = false;
            this.listMaxSpeed.View = System.Windows.Forms.View.List;
            // 
            // listAvgHeartRate
            // 
            this.listAvgHeartRate.HideSelection = false;
            this.listAvgHeartRate.Location = new System.Drawing.Point(15, 43);
            this.listAvgHeartRate.Name = "listAvgHeartRate";
            this.listAvgHeartRate.Size = new System.Drawing.Size(630, 223);
            this.listAvgHeartRate.TabIndex = 1;
            this.listAvgHeartRate.UseCompatibleStateImageBehavior = false;
            this.listAvgHeartRate.View = System.Windows.Forms.View.List;
            // 
            // SeeEventResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 316);
            this.Controls.Add(this.tabControl1);
            this.Name = "SeeEventResultsForm";
            this.Text = "SeeEventResultsForm";
            this.Load += new System.EventHandler(this.SeeEventResultsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAvgSpeed.ResumeLayout(false);
            this.tabAvgSpeed.PerformLayout();
            this.tabMaxSpeed.ResumeLayout(false);
            this.tabMaxSpeed.PerformLayout();
            this.tabAvgHeartRate.ResumeLayout(false);
            this.tabAvgHeartRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAvgSpeed;
        private System.Windows.Forms.ListView listAverageSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMaxSpeed;
        private System.Windows.Forms.ListView listMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabAvgHeartRate;
        private System.Windows.Forms.ListView listAvgHeartRate;
        private System.Windows.Forms.Label label3;
    }
}