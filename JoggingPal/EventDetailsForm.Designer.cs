namespace JoggingPal
{
    partial class EventDetailsForm
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
            this.listEventDetails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listEventDetails
            // 
            this.listEventDetails.FullRowSelect = true;
            this.listEventDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listEventDetails.HideSelection = false;
            this.listEventDetails.Location = new System.Drawing.Point(13, 12);
            this.listEventDetails.Name = "listEventDetails";
            this.listEventDetails.Size = new System.Drawing.Size(585, 375);
            this.listEventDetails.TabIndex = 0;
            this.listEventDetails.UseCompatibleStateImageBehavior = false;
            this.listEventDetails.View = System.Windows.Forms.View.Details;
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.listEventDetails);
            this.Name = "EventDetailsForm";
            this.Text = "Event Details";
            this.Load += new System.EventHandler(this.EventDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEventDetails;
    }
}